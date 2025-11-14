using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Liquidacion
    {

         public int IDLiquidacion {  get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public float TotalVendido { get; set; }
        public int CantidadVendidas { get; set; }
        public int NumeroLiquidacion { get; set; }





    }
}
