using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class VentaCombo
    {
        public int IDVentaCombo { get; set; }
        public int IDVenta { get; set; }

        public int IdCombo { get; set; }      // qué combo se vendió
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal
        {
            get { return Cantidad * PrecioUnitario; }
        }




    }
}
