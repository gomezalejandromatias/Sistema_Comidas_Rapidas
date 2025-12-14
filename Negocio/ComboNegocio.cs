using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComboNegocio
    {

        public List<Combo> listacombo()
        {

            List<Combo> combo = new List<Combo>();

            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetearConsulta(
                "SELECT IdCombo, CodigoCombo, Nombre, Ingredientes,Precio,FechaAlta " +
                "FROM Combo " +
                "WHERE Activo = 1"
            );

            accesoDatos.EjecutarLectura();

            try
            {
                while (accesoDatos.Lector.Read())
                {
                    Combo aux = new Combo();

                    aux.IdCombo = (int)accesoDatos.Lector["IdCombo"];
                    aux.CodigoCombo = accesoDatos.Lector["CodigoCombo"].ToString();
                    aux.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    aux.Ingredientes = accesoDatos.Lector["Ingredientes"].ToString();   // 👈 acá va TODO el texto
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    aux.FechaAlta = (DateTime)accesoDatos.Lector["FechaAlta"];
                    aux.Activo = true;

                    combo.Add(aux);
                }

                return combo;
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

        public int AgregarCombo(Combo combo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta(
                    "INSERT INTO Combo (CodigoCombo, Nombre, Ingredientes, Precio, Activo, FechaAlta) " +
                    "VALUES (@CodigoCombo, @Nombre, @Ingredientes, @Precio, @Activo, GETDATE()); " +
                    "SELECT SCOPE_IDENTITY();"
                );

                accesoDatos.SetearParametro("@CodigoCombo", combo.CodigoCombo);
                accesoDatos.SetearParametro("@Nombre", combo.Nombre);
                accesoDatos.SetearParametro("@Ingredientes", combo.Ingredientes);
                accesoDatos.SetearParametro("@Precio", combo.Precio);
                accesoDatos.SetearParametro("@Activo", combo.Activo);

                int idCombo = Convert.ToInt32(accesoDatos.EjecutarEscalar());
                return idCombo;
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

        public void EliminarCombo(int id) 
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {

                accesoDatos.SetearConsulta("update  Combo set Activo=0 where  IdCombo=@id");

                accesoDatos.SetearParametro("@id",id);


                accesoDatos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }
           
        
        }

        public void ModificarCombo(Combo combo)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
            accesoDatos.SetearConsulta("update Combo set Nombre=@Nombre,Precio=@Precio,Ingredientes=@Ingredientes where IdCombo=@IdCombo");
                accesoDatos.SetearParametro("@Nombre", combo.Nombre);
                accesoDatos.SetearParametro("@Precio", combo.Precio);
                accesoDatos.SetearParametro("@Ingredientes", combo.Ingredientes);
                accesoDatos.SetearParametro("@IdCombo", combo.IdCombo);

                accesoDatos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }

             



        }

        public void AgregarComboProducto(int idCombo, int idProducto, int cantidad)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(
                    "INSERT INTO ComboProducto (IdCombo, IdProducto, CantidadProducto) " +
                    "VALUES (@IdCombo, @IdProducto, @CantidadProducto)"
                );

                datos.SetearParametro("@IdCombo", idCombo);
                datos.SetearParametro("@IdProducto", idProducto);
                datos.SetearParametro("@CantidadProducto", cantidad);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public List<Combo> listacomboParaVenta()
        {
            List<Combo> lista = new List<Combo>();
            AccesoDatos datos = new AccesoDatos();

            datos.SetearConsulta(
                "SELECT c.IdCombo, c.CodigoCombo, c.Nombre, c.Ingredientes, c.Precio, c.FechaAlta " +
                "FROM Combo c " +
                "WHERE c.Activo = 1 " +
                "AND NOT EXISTS ( " +
                "   SELECT 1 " +
                "   FROM ComboProducto cd " +
                "   INNER JOIN Producto p ON p.IdProducto = cd.IdProducto " +
                "   WHERE cd.IdCombo = c.IdCombo " +
                "     AND p.Activo = 0 " +
                ")"
            );

            datos.EjecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Combo aux = new Combo();
                    aux.IdCombo = (int)datos.Lector["IdCombo"];
                    aux.CodigoCombo = datos.Lector["CodigoCombo"].ToString();
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.Ingredientes = datos.Lector["Ingredientes"].ToString();
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.FechaAlta = (DateTime)datos.Lector["FechaAlta"];
                    aux.Activo = true;

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
                datos.CerrarConexion();
            }
        }

    }
}
