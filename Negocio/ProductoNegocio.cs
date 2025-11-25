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


            datos.SetearConsulta("select p.CodigoProducto,p.NombreProducto,p.UnidadPaquete,p.CantidadUnidad,p.PrecioUnidad,p.FechaIngreso,p.Categoria,p.Stock,p.PrecioFinal from Producto p");
            datos.EjecutarLectura();

            while (datos.Lector.Read())
            {

                try
                {
                    Producto aux = new Producto();

                  
                    aux.CodigoProducto = (string)datos.Lector["CodigoProducto"];
                    aux.NombreProcducto = (string)datos.Lector["NombreProducto"];
                    aux.UnidadPaquete = (int)datos.Lector["UnidadPaquete"];
                    aux.CantidadUnidad = (int)datos.Lector["CantidadUnidad"];
                    aux.PrecioUnidad = (decimal)datos.Lector["PrecioUnidad"];
                    aux.FechaIngreso = (DateTime)datos.Lector["FechaIngreso"];
                    aux.Categoria = datos.Lector["Categoria"] is DBNull ? "" : (string)datos.Lector["Categoria"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.PrecioFinal = (decimal)datos.Lector["PrecioFinal"];
                  //  aux.Activo = (bool)datos.Lector["Activo"];


                    lista.Add(aux);
                }
                catch (Exception ex)
                {

                    throw ex;
                }




            }
                     return lista;





        }



    }
}
