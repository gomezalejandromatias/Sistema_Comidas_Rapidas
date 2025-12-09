using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> listaventa(string filtro = "") 
        {

            AccesoDatos accesoDatos = new AccesoDatos();
            List<Venta> lista = new List<Venta>();

            try
            {
                string consulta =
                    "SELECT NumeroVenta, FechaVenta, FormaPago, TotalPrecio " +
                    "FROM Ventas";

                // Si hay filtro, agrego WHERE
                if (filtro != "")
                {
                    consulta += " WHERE CONVERT(varchar, FechaVenta, 103) LIKE @filtro";
                }

                consulta += " ORDER BY NumeroVenta DESC";

                accesoDatos.SetearConsulta(consulta);

                if (filtro != "")
                {
                    accesoDatos.SetearParametro("@filtro", "%" + filtro + "%");
                }

                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Venta aux = new Venta();

                    aux.NumeroVenta = (int)accesoDatos.Lector["NumeroVenta"];
                    aux.FechaVenta = (DateTime)accesoDatos.Lector["FechaVenta"];
                    aux.FormaPago = accesoDatos.Lector["FormaPago"].ToString();
                    aux.TotalPrecio = (decimal)accesoDatos.Lector["TotalPrecio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }




        }

         public void guardarventa(Venta venta)
         {
            VerificarStockDisponible(venta);
      
            AccesoDatos accesoDatos = new AccesoDatos ();

            int idventa = 0;

            try
            {
                accesoDatos.SetearConsulta(
                      "INSERT INTO Ventas (NumeroVenta, FechaVenta, TotalPrecio, FormaPago) " +
                      "VALUES (@NumeroVenta, GETDATE(), @TotalPrecio, @FormaPago); " +
                      "SELECT SCOPE_IDENTITY();"
                                               );

                accesoDatos.SetearParametro("@NumeroVenta", venta.NumeroVenta);
                accesoDatos.SetearParametro("@TotalPrecio", venta.TotalPrecio);
                accesoDatos.SetearParametro("@FormaPago", venta.FormaPago);
                

                idventa = Convert.ToInt32(accesoDatos.EjecutarEscalar());


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { accesoDatos.CerrarConexion(); }

           
            foreach (var item in venta.Detalles )
            {
              AccesoDatos accesoDatos1 = new AccesoDatos ();
                try
                {  

                    accesoDatos1.SetearConsulta(
                        "INSERT INTO VentaCombo (IDVenta, IdCombo, Cantidad, PrecioUnitario) " +
                            "VALUES (@IDVenta, @IdCombo, @Cantidad, @PrecioUnitario)"
 );

                    accesoDatos1.SetearParametro("@IDVenta", idventa);
                    accesoDatos1.SetearParametro("@IdCombo", item.IdCombo);
                    accesoDatos1.SetearParametro("@Cantidad", item.Cantidad);
                    accesoDatos1.SetearParametro("@PrecioUnitario", item.PrecioUnitario);

                    accesoDatos1.EjecutarAccion();

                }
                catch (Exception)
                {

                    throw;
                }
                finally { accesoDatos1.CerrarConexion(); }

                AccesoDatos datosReceta = new AccesoDatos();
                try
                {
                    // BUSCO LA RECETA DEL COMBO (qué productos usa)
                    datosReceta.SetearConsulta(
                        "SELECT IdProducto, CantidadProducto " +
                        "FROM ComboProducto " +
                        "WHERE IdCombo = @IdCombo"
                    );
                    datosReceta.SetearParametro("@IdCombo", item.IdCombo);
                    datosReceta.EjecutarLectura();

                    // RECORRO CADA PRODUCTO QUE USA EL COMBO
                    while (datosReceta.Lector.Read())
                    {
                        int idProducto = (int)datosReceta.Lector["IdProducto"];

                        // La receta trae un DECIMAL → lo convierto a int
                        int cantidadPorCombo = (int)(decimal)datosReceta.Lector["CantidadProducto"];

                        // 🔢 Cantidad total que tengo que descontar
                        int cantidadTotalDescontar = cantidadPorCombo * item.Cantidad;

                        // 🔥 HAGO EL UPDATE AL STOCK DEL PRODUCTO
                        AccesoDatos datosUpdate = new AccesoDatos();
                        try
                        {
                            datosUpdate.SetearConsulta(
                                "UPDATE Producto " +
                                "SET Stock = Stock - @Cantidad " +
                                "WHERE IdProducto = @IdProducto"
                            );

                            datosUpdate.SetearParametro("@Cantidad", cantidadTotalDescontar);
                            datosUpdate.SetearParametro("@IdProducto", idProducto);

                            datosUpdate.EjecutarAccion();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            datosUpdate.CerrarConexion();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    datosReceta.CerrarConexion();
                }





            }
           



         }

        public void VerificarStockDisponible(Venta venta)
        {
            foreach (var item in venta.Detalles)
            {
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(
                        "SELECT p.IdProducto, p.NombreProducto, p.Stock, cp.CantidadProducto " +
                        "FROM ComboProducto cp " +
                        "INNER JOIN Producto p ON p.IdProducto = cp.IdProducto " +
                        "WHERE cp.IdCombo = @IdCombo"
                    );

                    datos.SetearParametro("@IdCombo", item.IdCombo);
                    datos.EjecutarLectura();

                    bool hayReceta = false;

                    while (datos.Lector.Read())
                    {
                        hayReceta = true;

                        int stockActual = (int)datos.Lector["Stock"];
                        int cantidadPorCombo = (int)(decimal)datos.Lector["CantidadProducto"];
                        int cantidadNecesaria = cantidadPorCombo * item.Cantidad;

                        if (stockActual < cantidadNecesaria)
                        {
                            string nombreProducto = datos.Lector["NombreProducto"].ToString();

                            // Para que veas bien qué pasa:
                            // MessageBox.Show("NO HAY STOCK de " + nombreProducto +
                            //                 "\nStock: " + stockActual +
                            //                 "\nNecesito: " + cantidadNecesaria);

                            throw new Exception(
                                "No hay stock suficiente del producto: " + nombreProducto +
                                ". Stock actual: " + stockActual +
                                ", se necesitan: " + cantidadNecesaria
                            );
                        }
                    }

                    if (!hayReceta)
                    {
                        throw new Exception(
                            "El combo con Id " + item.IdCombo +
                            " no tiene productos cargados en ComboProducto. No se puede verificar el stock."
                        );
                    }
                }
                finally
                {
                    datos.CerrarConexion();
                }
            }
        }





    }
}
