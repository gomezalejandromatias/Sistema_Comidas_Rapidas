using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Combo
    {

        public int IdCombo {  get; set; }

        [DisplayName("Código")]
        public string CodigoCombo { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }


        [DisplayName("Precio")]

        public decimal Precio {  get; set; }
        [DisplayName("Fecha")]
        public DateTime FechaAlta {  get; set; }

        [DisplayName("ingrediente")]
        public string Ingredientes {  get; set; }
    


        public bool Activo {  get; set; }


      





    }
}
