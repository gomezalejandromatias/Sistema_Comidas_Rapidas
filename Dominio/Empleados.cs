using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Empleados
    {
        public int IDEmpleado { get; set; }             // Identificador único
        public string Nombre { get; set; }              // Nombre del empleado
        public string Apellido { get; set; }            // Apellido
        public string DNI { get; set; }                 // Documento
        public DateTime FechaNacimiento { get; set; }   // Fecha de nacimiento
        public string Telefono { get; set; }            // Teléfono
        public string Email { get; set; }               // Correo
        public string Direccion { get; set; }           // Dirección completa

        // Datos laborales
        public DateTime FechaIngreso { get; set; }      // Día que empezó a trabajar
        public string Puesto { get; set; }              // Cajero, Cocinero, Encargado, etc.
        public decimal Sueldo { get; set; }             // Sueldo mensual
        public bool Activo { get; set; }




    }
}
