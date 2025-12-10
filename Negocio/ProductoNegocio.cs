using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {

        public List<Producto> listaproducto()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();


            datos.SetearConsulta(
        "SELECT p.IdProducto, p.CodigoProducto, p.NombreProducto, p.UnidadPaquete, p.CantidadUnidad, " +
    "p.PrecioUnidad, p.FechaIngreso, p.Categoria, p.Stock, p.PrecioFinal, " +
    "p.IDProveedor, " +
    "pr.Nombre AS Proveedor " +
    "FROM Producto p " +
    "INNER JOIN Proveedores pr ON p.IDProveedor = pr.IDProveedor " +
    "WHERE p.Activo = 1"
        );
            datos.EjecutarLectura();

            while (datos.Lector.Read())
            {

                try
                {
                    Producto aux = new Producto();

                    aux.IDProducto = (int)datos.Lector["IdProducto"];
                    aux.CodigoProducto = (string)datos.Lector["CodigoProducto"];
                    aux.NombreProducto = (string)datos.Lector["NombreProducto"];
                    aux.UnidadPaquete = (int)datos.Lector["UnidadPaquete"];
                    aux.CantidadUnidad = (int)datos.Lector["CantidadUnidad"];
                    aux.PrecioUnidad = (decimal)datos.Lector["PrecioUnidad"];
                    aux.FechaIngreso = (DateTime)datos.Lector["FechaIngreso"];
                    aux.Categoria = datos.Lector["Categoria"] is DBNull ? "" : (string)datos.Lector["Categoria"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.PrecioFinal = (decimal)datos.Lector["PrecioFinal"];

                    aux.IDProveedor = (int)datos.Lector["IDProveedor"];
                    aux.Proveedor = (string)datos.Lector["Proveedor"];




                    lista.Add(aux);
                }
                catch (Exception ex)
                {

                    throw ex;
                }




            }
            return lista;





        }

        public void AgregarProducto(Producto producto)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta(
              "INSERT INTO Producto (CodigoProducto, NombreProducto, UnidadPaquete, CantidadUnidad, PrecioUnidad, FechaIngreso, Categoria, Stock, PrecioFinal,IDProveedor) " +
              "VALUES (@CodigoProducto, @NombreProducto, @UnidadPaquete, @CantidadUnidad, @PrecioUnidad, @FechaIngreso, @Categoria, @Stock, @PrecioFinal,@IDProveedor)"
                 );

                accesoDatos.SetearParametro("@CodigoProducto", producto.CodigoProducto);
                accesoDatos.SetearParametro("@NombreProducto", producto.NombreProducto);
                accesoDatos.SetearParametro("@UnidadPaquete", producto.UnidadPaquete);
                accesoDatos.SetearParametro("@CantidadUnidad", producto.CantidadUnidad);
                accesoDatos.SetearParametro("@PrecioUnidad", producto.PrecioUnidad);
                accesoDatos.SetearParametro("@FechaIngreso", producto.FechaIngreso);
                accesoDatos.SetearParametro("@Categoria", producto.Categoria);
                accesoDatos.SetearParametro("@Stock", producto.Stock);
                accesoDatos.SetearParametro("@PrecioFinal", producto.PrecioFinal);
                accesoDatos.SetearParametro("@IDProveedor", producto.IDProveedor);

                accesoDatos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { accesoDatos.CerrarConexion(); }





        }

        public void EliminarProducto(int id)
        {


            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();


                accesoDatos.SetearConsulta("update  Producto set  Activo=0 where   IdProducto=@id");
                accesoDatos.SetearParametro("@id", id);
                accesoDatos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void ModificarProducto(Producto producto) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
               

                accesoDatos.SetearConsulta("update Producto set CodigoProducto=@CodigoProducto,NombreProducto=@NombreProducto,UnidadPaquete=@UnidadPaquete,CantidadUnidad=@CantidadUnidad, "+
                    "PrecioUnidad=@PrecioUnidad,FechaIngreso=@FechaIngreso,Categoria=@Categoria,Stock=@Stock,PrecioFinal=@PrecioFinal,IDProveedor=@IDProveedor WHERE IdProducto = @IdProducto");
                accesoDatos.SetearParametro("@CodigoProducto", producto.CodigoProducto);
                accesoDatos.SetearParametro("@NombreProducto", producto.NombreProducto);
                accesoDatos.SetearParametro("@UnidadPaquete", producto.UnidadPaquete);
                accesoDatos.SetearParametro("@CantidadUnidad", producto.CantidadUnidad);
                accesoDatos.SetearParametro("@PrecioUnidad", producto.PrecioUnidad);
                accesoDatos.SetearParametro("@FechaIngreso", producto.FechaIngreso);
                accesoDatos.SetearParametro("@Categoria", producto.Categoria);
                accesoDatos.SetearParametro("@Stock", producto.Stock);
                accesoDatos.SetearParametro("@PrecioFinal", producto.PrecioFinal);
                accesoDatos.SetearParametro("@IDProveedor", producto.IDProveedor);
                accesoDatos.SetearParametro("@IdProducto", producto.IDProducto);

                accesoDatos.EjecutarAccion();




            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }
        
        
        
        
        
        }
        public void ModificarStock(Producto producto)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta(
                    "UPDATE Producto SET Stock = @Stock " +
                    "WHERE IdProducto = @IdProducto");

                accesoDatos.SetearParametro("@Stock", producto.Stock);
                accesoDatos.SetearParametro("@IdProducto", producto.IDProducto);

                accesoDatos.EjecutarAccion();
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




    }
}
