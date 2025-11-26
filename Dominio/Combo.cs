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
        public string Nombre { get; set; }

     
        

        public decimal Precio {  get; set; }
        public DateTime FechaAlta {  get; set; }

        public List<string> Ingredientes { get; set; } = new List<string>();
        public string Ingrediente
        {
            get { return string.Join(", ", Ingredientes); }
        }


        public bool Activo {  get; set; }





    }
}
