using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Usuario
    {
         
        public int IDUsuario { get; set; }
        public string Pasword { get; set; }
        public string TipoUsuario { get; set; }
        public bool Activo { get; set; }    
        public Empleados Empleados { get; set; }





    }
}
