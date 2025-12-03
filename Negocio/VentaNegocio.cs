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






            }
           



         }



    }
}
