using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EmpleadoNegocio
    {

        public List<Empleados> listaempleado()
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            List<Empleados> lista = new List<Empleados>();


            accesoDatos.SetearConsulta(
                               "SELECT IDEmpleado, Nombre, Apellido, DNI, FechaNacimiento, " +
                        "Telefono, Email, Direccion, FechaIngreso, Puesto, Sueldo, Activo " +
                      "FROM Empleados"
                                                                           );
            accesoDatos.EjecutarLectura();


            try
            {
                while (accesoDatos.Lector.Read())
                {
                    Empleados aux = new Empleados();

                    aux.IDEmpleado = (int)accesoDatos.Lector["IDEmpleado"];
                    aux.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    aux.Apellido = accesoDatos.Lector["Apellido"].ToString();
                    aux.DNI = accesoDatos.Lector["DNI"].ToString();
                    aux.FechaNacimiento = (DateTime)accesoDatos.Lector["FechaNacimiento"];

                    aux.Telefono = accesoDatos.Lector["Telefono"] != DBNull.Value
                        ? accesoDatos.Lector["Telefono"].ToString()
                        : "";

                    aux.Email = accesoDatos.Lector["Email"] != DBNull.Value
                        ? accesoDatos.Lector["Email"].ToString()
                        : "";

                    aux.Direccion = accesoDatos.Lector["Direccion"] != DBNull.Value
                        ? accesoDatos.Lector["Direccion"].ToString()
                        : "";

                    aux.FechaIngreso = (DateTime)accesoDatos.Lector["FechaIngreso"];
                    aux.Puesto = accesoDatos.Lector["Puesto"].ToString();
                    aux.Sueldo = (decimal)accesoDatos.Lector["Sueldo"];
                    aux.Activo = (bool)accesoDatos.Lector["Activo"];


                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }




        }




    }
}
