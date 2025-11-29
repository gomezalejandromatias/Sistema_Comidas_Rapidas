using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComboNegocio
    {

        public List<Combo> listacombo()
        {

            List<Combo> combo = new List<Combo>();

            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetearConsulta(
                "SELECT IdCombo, CodigoCombo, Nombre, Ingredientes,Precio,FechaAlta " +
                "FROM Combo " +
                "WHERE Activo = 1"
            );

            accesoDatos.EjecutarLectura();

            try
            {
                while (accesoDatos.Lector.Read())
                {
                    Combo aux = new Combo();

                    aux.IdCombo = (int)accesoDatos.Lector["IdCombo"];
                    aux.CodigoCombo = accesoDatos.Lector["CodigoCombo"].ToString();
                    aux.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    aux.Ingredientes = accesoDatos.Lector["Ingredientes"].ToString();   // 👈 acá va TODO el texto
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    aux.FechaAlta = (DateTime)accesoDatos.Lector["FechaAlta"];
                    aux.Activo = true;

                    combo.Add(aux);
                }

                return combo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }




        }

        public void AgregarCombo(Combo combo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta(
                    "INSERT INTO Combo (CodigoCombo,Nombre,Ingredientes,Precio,Activo, FechaAlta) " +
                    "VALUES (@CodigoCombo, @Nombre, @Ingredientes,@Precio,@Activo, GETDATE());"
                );

                accesoDatos.SetearParametro("@CodigoCombo", combo.CodigoCombo);
                accesoDatos.SetearParametro("@Nombre", combo.Nombre);
                accesoDatos.SetearParametro("@Ingredientes", combo.Ingredientes); // 👈 texto del RichTextBox
                accesoDatos.SetearParametro("@Precio", combo.Precio);
                accesoDatos.SetearParametro("@Activo", combo.Activo);

                accesoDatos.EjecutarAccion();   // 👈 ya no necesito SCOPE_IDENTITY
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }




        }



    }
}
