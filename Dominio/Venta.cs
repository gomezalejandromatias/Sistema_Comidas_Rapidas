using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int IDVenta { get; set; }

        public DateTime FechaVenta { get; set; }
        public decimal TotalPrecio { get; set; }
        public string FormaPago { get; set; }
        public int NumeroVenta { get; set; }
        public List<Producto> Productos { get; set; }


         // public Combo list<Combo> ListaCombo = new Combo

              public Empleados empleado { get; set; }









    }
}
