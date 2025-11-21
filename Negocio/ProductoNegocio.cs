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
                CantidadUnidad = 1,                 // Cantidad por transacción o unidad
                UnidadPaquete = 1,            // Si viene por unidad
                Proveedores = new List<Proveedores>(), // Lista vacía (podés agregar después)
                PrecioUnidad = 100,           // Precio por unidad
                NombreProcducto = "Pancho Simple",
                FechaIngreso = DateTime.Now,
                Stock = 50,
                PrecioFinal = 100,            // Precio final (Unidad * Cantidad o precio al público)
                Activo = true,
                Categoria = "Panchos"
            });

            lista.Add(new Producto
            {
                IDProducto = 2,
                CodigoProducto = "P002",
                CantidadUnidad = 1,
                UnidadPaquete = 1,
                Proveedores = new List<Proveedores>(),
                PrecioUnidad = 150,
                NombreProcducto = "Pancho Completo",
                FechaIngreso = DateTime.Now,
                Stock = 40,
                PrecioFinal = 150,
                Activo = true,
                Categoria = "Panchos"
            });

            lista.Add(new Producto
            {
                IDProducto = 3,
                CodigoProducto = "P003",
                CantidadUnidad = 1,
                UnidadPaquete = 1,
                Proveedores = new List<Proveedores>(),
                PrecioUnidad = 250,
                NombreProcducto = "Milanesa Completa",
                FechaIngreso = DateTime.Now,
                Stock = 50,
                PrecioFinal = 250,
                Activo = true,
                Categoria = "Milanesa"
            });


            return lista;




        } 



    }
}
