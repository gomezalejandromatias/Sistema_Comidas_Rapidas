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
        public string NombreProcducto { get; set; }
        public string proveedores { get; set; }
        public int UnidadPaquete { get; set; }
        public int CantidadUnidad { get; set; }
        public List<Proveedores> Proveedores { get; set; } = new List<Proveedores>();

        public decimal PrecioUnidad { get; set; }

        public DateTime FechaIngreso { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public decimal PrecioFinal { get; set; }
        public bool Activo { get; set; }



    










    }
}
