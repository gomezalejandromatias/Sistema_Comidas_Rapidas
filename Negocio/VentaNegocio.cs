using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> listaventa(string filtro = "")
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (filtro == "")
                {
                    // Si no mandás fecha → devuelve todas las ventas
                    datos.SetearConsulta(
                        "SELECT IDVenta, NumeroVenta, FechaVenta, FormaPago, TotalPrecio " +
                        "FROM Ventas " +
                        "ORDER BY FechaVenta"
                    );
                }
                else
                {
                    // Si mandás fecha → filtra por esa fecha exacta
                    datos.SetearConsulta(
                        "SELECT IDVenta, NumeroVenta, FechaVenta, FormaPago, TotalPrecio " +
                        "FROM Ventas " +
                        "WHERE CONVERT(varchar(10), FechaVenta, 103) = @Fecha " +
                        "ORDER BY FechaVenta"
                    );

                    datos.SetearParametro("@Fecha", filtro);
                }

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Venta v = new Venta();

                    v.IDVenta = (int)datos.Lector["IDVenta"];
                    v.NumeroVenta = (int)datos.Lector["NumeroVenta"];
                    v.FechaVenta = (DateTime)datos.Lector["FechaVenta"];
                    v.FormaPago = (string)datos.Lector["FormaPago"];
                    v.TotalPrecio = (decimal)datos.Lector["TotalPrecio"];

                    lista.Add(v);
                }
            }
            finally
            {
                datos.CerrarConexion();
            }

            return lista;
        }
        public List<Venta> listaventaFiltrada(DateTime desde, DateTime hasta)
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Solo ventas entre esas fechas (ignorando la hora)
                datos.SetearConsulta(
                    "SELECT IDVenta, NumeroVenta, FechaVenta, FormaPago, TotalPrecio " +
                    "FROM Ventas " +
                    "WHERE CONVERT(date, FechaVenta) BETWEEN @Desde AND @Hasta " +
                    "ORDER BY FechaVenta"
                );

                datos.SetearParametro("@Desde", desde.Date);
                datos.SetearParametro("@Hasta", hasta.Date);

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Venta v = new Venta();

                    v.IDVenta = (int)datos.Lector["IDVenta"];
                    v.NumeroVenta = (int)datos.Lector["NumeroVenta"];
                    v.FechaVenta = (DateTime)datos.Lector["FechaVenta"];
                    v.FormaPago = (string)datos.Lector["FormaPago"];
                    v.TotalPrecio = (decimal)datos.Lector["TotalPrecio"];

                    lista.Add(v);
                }
            }
            finally
            {
                datos.CerrarConexion();
            }

            return lista;
        }
        public void guardarventa(Venta venta)
        {
            // 1) Armar la tabla que va a viajar como TVP (@Detalles)
            DataTable tablaDetalles = new DataTable();
            tablaDetalles.Columns.Add("IdCombo", typeof(int));
            tablaDetalles.Columns.Add("Cantidad", typeof(int));
            tablaDetalles.Columns.Add("PrecioUnitario", typeof(decimal));

            // Cargo las filas con lo que tenés en venta.Detalles
            foreach (var det in venta.Detalles)
            {
                tablaDetalles.Rows.Add(det.IdCombo, det.Cantidad, det.PrecioUnitario);
            }

            AccesoDatos datos = new AccesoDatos();

            try
            {
                // 2) Indico que voy a ejecutar un SP
                datos.SetearProcedimiento("SP_GuardarVentaCompleta");

                // 3) Parámetros escalares
                datos.SetearParametro("@NumeroVenta", venta.NumeroVenta);
                datos.SetearParametro("@TotalPrecio", venta.TotalPrecio);
                datos.SetearParametro("@FormaPago", venta.FormaPago);

                // 4) Parámetro TVP (tabla DetalleVentaTVP)
                datos.SetearParametroTVP("@Detalles", "dbo.DetalleVentaTVP", tablaDetalles);

                // 5) Ejecutar el procedimiento
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                // El SP te puede tirar errores de stock (RAISERROR)
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }







    }
}
