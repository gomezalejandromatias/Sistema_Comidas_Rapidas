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

            accesoDatos.SetearConsulta("select  c.IdCombo,c.CodigoCombo,c.Nombre,co.Descripcion,c.Precio,c.FechaAlta   from Combo c LEFT JOIN ComboIngrediente co on co.IdCombo = c.IdCombo where c.Activo=1");
            accesoDatos.EjecutarLectura();

            try
            {
                while (accesoDatos.Lector.Read()) 
                {
                    Combo aux = new Combo();


                    int idCombo = (int)accesoDatos.Lector["IdCombo"];

                    // 1) Buscar si ya existe ese combo en la lista
                     aux = null;
                    for (int i = 0; i < combo.Count; i++)
                    {
                        if (combo[i].IdCombo == idCombo)
                        {
                            aux = combo[i];
                            break;
                        }
                    }

                    // 2) Si no existe, lo creo y lo agrego
                    if (aux == null)
                    {
                        aux = new Combo();
                        aux.IdCombo = idCombo;
                        aux.CodigoCombo = (string)accesoDatos.Lector["CodigoCombo"];
                        aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                        aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                        aux.FechaAlta = (DateTime)accesoDatos.Lector["FechaAlta"];
                        //crea la lista de ingredientes porque sino me muestra el combo 
                        //varias veces si tiene varios ingredientes  vacia lo crea
                        aux.Ingredientes = new List<string>();

                        combo.Add(aux);
                    }

                    // 3) Agregar el ingrediente (si la fila tiene)
                    // Este bloque agrega un ingrediente
                    if (!(accesoDatos.Lector["Descripcion"] is DBNull))
                    {
                        string ingrediente = (string)accesoDatos.Lector["Descripcion"];
                        aux.Ingredientes.Add(ingrediente);
                    }



                }
                   return combo;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }




          }

        public void AgregarCombo(Combo combo) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();


            try
            {
            accesoDatos.SetearConsulta("INSERT INTO Combo (CodigoCombo, Nombre, Precio, Activo) " + 
                "values (@CodigoCombo,@Nombre,@Precio,@Activo)");

                accesoDatos.SetearParametro("@CodigoCombo", combo.CodigoCombo);
                accesoDatos.SetearParametro("@Nombre", combo.Nombre);
                accesoDatos.SetearParametro("@Precio", combo.Precio);
                accesoDatos.SetearParametro("@Activo", combo.Activo);
                accesoDatos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { accesoDatos.CerrarConexion(); }

            // Paso 2: obtener IdCombo del combo que acabamos de insertar
            AccesoDatos datosId = new AccesoDatos();
            int idComboGenerado = 0;
            try
            {
                datosId.SetearConsulta(
                    "SELECT TOP 1 IdCombo " +
                    "FROM Combo " +
                    "WHERE CodigoCombo = @CodigoCombo " +
                    "ORDER BY IdCombo DESC"
                );
                datosId.SetearParametro("@CodigoCombo", combo.CodigoCombo);

                datosId.EjecutarLectura();
                ///asi tomo el id 
                if (datosId.Lector.Read())
                {
                    idComboGenerado = (int)datosId.Lector["IdCombo"];
                }
                else
                {
                    throw new Exception("No se pudo obtener el IdCombo generado.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosId.CerrarConexion();
            }

            // Paso 3: insertar los ingredientes en ComboIngrediente
            if (combo.Ingredientes != null && combo.Ingredientes.Count > 0)
            {
                AccesoDatos datosIng = new AccesoDatos();
                try
                {
                    int orden = 1;

                    foreach (string ing in combo.Ingredientes)
                    {
                        datosIng.SetearConsulta(
                            "INSERT INTO ComboIngrediente (IdCombo, Descripcion, Orden) " +
                            "VALUES (@IdCombo, @Descripcion, @Orden)"
                        );

                        datosIng.SetearParametro("@IdCombo", idComboGenerado);
                        datosIng.SetearParametro("@Descripcion", ing);
                        datosIng.SetearParametro("@Orden", orden);

                        datosIng.EjecutarAccion();
                        orden++;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datosIng.CerrarConexion();
                }
            }










        }



    }
}
