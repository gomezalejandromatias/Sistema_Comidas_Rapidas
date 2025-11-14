using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MovimientosStock
    {

           public int IDMovimiento {  get; set; }
        public string TipoMovimiento { get; set; }
        public Producto producto { get; set; }
        public string Motivo { get; set; }
        public int Cantidad     { get; set; }
        public DateTime FechaMovimiento { get; set; }



    }
}
