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
            combo.Add(new Combo
            {
                IdCombo = 1,
                CodigoCombo = "C001",
                NombreCombo = "Pancho Completo + Gaseosa 500ml",
                Precio = 220,   // ejemplo
                Activo = true
            });

            combo.Add(new Combo
            {
                IdCombo = 2,
                CodigoCombo = "C002",
                NombreCombo = "Milanesa Completa + Papas Fritas",
                Precio = 350,
                Activo = true
            });

            combo.Add(new Combo
            {
                IdCombo = 3,
                CodigoCombo = "C003",
                NombreCombo = "Pancho Simple + Coca Lata",
                Precio = 180,
                Activo = true
            });

            return combo;



          }



    }
}
