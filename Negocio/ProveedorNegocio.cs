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


            accesoDatos.SetearConsulta("select p.Nombre   from Proveedores p where p.Activo= 1");
            accesoDatos.EjecutarLectura();

            try
            {
                while (accesoDatos.Lector.Read())
                {
                    Proveedores aux = new Proveedores();

                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];

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
          
    }
}
