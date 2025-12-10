using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {

        public int IDProducto { get; set; }
        [DisplayName("Código")]
        public string CodigoProducto { get; set; }
        [DisplayName("Nombre Del Producto")]
        public string NombreProducto { get; set; }
        public int IDProveedor { get; set; }
        public string Proveedor { get; set; }

        [DisplayName("Unidades por Paquetes / Cantidad de kilos")]
        public int UnidadPaquete { get; set; }

        [DisplayName("Cantidad de Paquetes / Cantidad en Gramos")]
        public int CantidadUnidad { get; set; }

        [DisplayName("Precio p/u y/o KiloGramos")]
        public decimal PrecioUnidad { get; set; }
        [DisplayName("Fecha de Alta del Producto")]
        public DateTime FechaIngreso { get; set; }
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        [DisplayName("Stock Actual")]
        public int Stock { get; set; }
        [DisplayName("Precio Total")]
        public decimal PrecioFinal { get; set; }
        public bool Activo { get; set; }



    










    }
}
