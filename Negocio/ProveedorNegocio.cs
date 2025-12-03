using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProveedorNegocio
    {

          public List<Proveedores> ListaProveedores() 
          {
            List<Proveedores> lista = new List<Proveedores>();
            AccesoDatos accesoDatos = new AccesoDatos();

            accesoDatos.SetearConsulta(
                "SELECT p.IDProveedor, p.Nombre, p.Telefono, p.Direccion, p.Email, p.Descripcion " +
                "FROM Proveedores p " +
                "WHERE p.Activo = 1"
            );
            accesoDatos.EjecutarLectura();

            try
            {
                while (accesoDatos.Lector.Read())
                {
                    Proveedores aux = new Proveedores();

                    aux.idproveedor = (int)accesoDatos.Lector["IDProveedor"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];

                    // Pueden venir null en la BD, así que los controlo:
                    aux.Telefono = accesoDatos.Lector["Telefono"] != DBNull.Value
                        ? accesoDatos.Lector["Telefono"].ToString()
                        : "";

                    aux.Direccion = accesoDatos.Lector["Direccion"] != DBNull.Value
                        ? accesoDatos.Lector["Direccion"].ToString()
                        : "";

                    aux.Email = accesoDatos.Lector["Email"] != DBNull.Value
                        ? accesoDatos.Lector["Email"].ToString()
                        : "";

                    aux.Descripcion = accesoDatos.Lector["Descripcion"] != DBNull.Value
                        ? accesoDatos.Lector["Descripcion"].ToString()
                        : "";

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

        public void AgregarProveedor(Proveedores prov)
        {


            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {

                accesoDatos.SetearConsulta("insert into Proveedores(Nombre,Telefono,Direccion,Email,Descripcion,Activo) " + 
                "VALUES (@Nombre,@Telefono,@Direccion,@Email,@Descripcion,1)" );

                accesoDatos.SetearParametro("@Nombre", prov.Nombre);
                accesoDatos.SetearParametro("@Telefono", prov.Telefono);
                accesoDatos.SetearParametro("@Direccion", prov.Direccion);
                accesoDatos.SetearParametro("@Email", prov.Email);
                accesoDatos.SetearParametro("@Descripcion", prov.Descripcion);
                accesoDatos.SetearParametro("1", prov.Activo);

                accesoDatos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }




        }
        public void EliminarProv(int id)
        {

            AccesoDatos accesoDatos = new AccesoDatos();


            try
            {


                accesoDatos.SetearConsulta("update Proveedores set Activo=0 where IDProveedor=@id ");

                accesoDatos.SetearParametro("@id", id);

                accesoDatos.EjecutarAccion();
                  




            }
            catch (Exception ex)
            {

                throw ex;
            }





        }

        public void ModificarProv(Proveedores prov)
        {

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta(
                    "UPDATE Proveedores SET " +
                    "Nombre = @Nombre, " +
                    "Telefono = @Telefono, " +
                    "Direccion = @Direccion, " +
                    "Email = @Email, " +
                    "Descripcion = @Descripcion " +
                    "WHERE IDProveedor = @IDProveedor"
                );

                accesoDatos.SetearParametro("@Nombre", prov.Nombre);
                accesoDatos.SetearParametro("@Telefono", prov.Telefono);
                accesoDatos.SetearParametro("@Direccion", prov.Direccion);
                accesoDatos.SetearParametro("@Email", prov.Email);
                accesoDatos.SetearParametro("@Descripcion", prov.Descripcion);
                accesoDatos.SetearParametro("@IDProveedor", prov.idproveedor);

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
