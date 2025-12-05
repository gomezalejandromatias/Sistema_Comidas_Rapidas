using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ComboProducto
    {

        public int IdComboProducto { get; set; }   // Identity en la BD
        public int IdCombo { get; set; }           // FK al Combo
        public int IdProducto { get; set; }        // FK al Producto
        public int CantidadProducto { get; set; }


    }
}
