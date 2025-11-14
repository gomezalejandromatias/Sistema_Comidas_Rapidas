using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
    
       public int IDProducto { get; set; }  
        public string CodigoProducto { get; set; }

        public string Nombre {  get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Stock {  get; set; }
        public decimal Precio { get; set; } 
        public bool     activo { get; set; }
        public string Categoria { get; set; }


    
    
    
    
    }
}
