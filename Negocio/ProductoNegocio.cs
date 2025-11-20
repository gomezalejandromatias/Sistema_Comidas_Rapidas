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

        public List<Producto>listaproducto()
        {  
             List<Producto> lista = new List<Producto>();
         /* AccesoDatos AccesoDatos = new AccesoDatos();


            //   AccesoDatos.SetearConsulta()
            // AccesoDatos.EjecutarAccion();

            while (AccesoDatos.Lector.Read())
            {
                Producto aux = new Producto();

                aux.CodigoProducto = (string)AccesoDatos.Lector["CodigoProducto"];



            }
            return lista;*/

            lista.Add(new Producto
            {
                IDProducto = 1,
                CodigoProducto = "P001",
                Nombre = "Pancho Simple",
                FechaIngreso = DateTime.Now,
                Stock = 50,
                Precio = 100,
                Activo = true,
                Categoria = "Panchos"
            });

            lista.Add(new Producto
            {
                IDProducto = 2,
                CodigoProducto = "P002",
                Nombre = "Pancho Completo",
                FechaIngreso = DateTime.Now,
                Stock = 40,
                Precio = 150,
                Activo = true,
                Categoria = "Panchos"
            }); 
            lista.Add(new Producto
            {
                IDProducto = 3,
                CodigoProducto = "P003",
                Nombre = "Milanesa Completa",
                FechaIngreso = DateTime.Now,
                Stock = 50,
                Precio = 250,
                Activo = true,
                Categoria = "Milanesa"
            });



            return lista;




        } 



    }
}
