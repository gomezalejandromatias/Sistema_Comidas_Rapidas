using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Combo
    {

        public int IdCombo {  get; set; }

        public string CodigoCombo { get; set; }
        public string NombrePromocion { get; set; }

        public string NombreCombo { get; set; }
         public decimal PrecioCombo { get; set; }

        public decimal PrecioPromo {  get; set; }

        public List<string> Ingredientes { get; set; } = new List<string>();
        public string Ingrediente { get; set; }

        public bool Activo {  get; set; }





    }
}
