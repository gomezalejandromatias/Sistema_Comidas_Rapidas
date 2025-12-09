using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Comidas_Rapidas.Helpers
{
     public static class UIHelper
     {
        public static void BotonPrincipal(Button btn)
        {
            Color color1 = Color.FromArgb(52, 152, 219);   // Celeste moderno
            Color colorHover = Color.FromArgb(41, 128, 185);
            Color colorClick = Color.FromArgb(31, 97, 141);

            btn.BackColor = color1;
            btn.ForeColor = Color.White;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            // Borde redondeado (solo funciona si lo usás desde Paint)
            btn.Region = System.Drawing.Region.FromHrgn(
                UIHelper.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 18, 18)
            );

            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Eventos para hover y click
            btn.MouseEnter += (s, e) => { btn.BackColor = colorHover; };
            btn.MouseLeave += (s, e) => { btn.BackColor = color1; };
            btn.MouseDown += (s, e) => { btn.BackColor = colorClick; };
            btn.MouseUp += (s, e) => { btn.BackColor = colorHover; };
        }

        public static void BotonSecundarioPremium(Button btn)
        {
            Color colorBase = Color.FromArgb(236, 240, 241);
            Color colorHover = Color.FromArgb(210, 214, 217);
            Color colorClick = Color.FromArgb(189, 195, 199);

            btn.BackColor = colorBase;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // 🔥 ESTO ES LO QUE LE FALTA A TU SECUNDARIO 🔥  
            RedondearSiempre(btn, 18);

            btn.MouseEnter += (s, e) => btn.BackColor = colorHover;
            btn.MouseLeave += (s, e) => btn.BackColor = colorBase;
            btn.MouseDown += (s, e) => btn.BackColor = colorClick;
            btn.MouseUp += (s, e) => btn.BackColor = colorHover;
        }

        public static void BotonPeligroPremium(Button btn)
        {
            Color colorBase = Color.FromArgb(231, 76, 60);     // Rojo moderno (Material)
            Color colorHover = Color.FromArgb(192, 57, 43);    // Más oscuro
            Color colorClick = Color.FromArgb(146, 43, 33);    // Aún más profundo

            btn.BackColor = colorBase;
            btn.ForeColor = Color.White;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            // Borde redondeado profesional
            btn.Region = System.Drawing.Region.FromHrgn(
                UIHelper.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 18, 18)
            );

            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Animación hover/click premium
            btn.MouseEnter += (s, e) => { btn.BackColor = colorHover; };
            btn.MouseLeave += (s, e) => { btn.BackColor = colorBase; };
            btn.MouseDown += (s, e) => { btn.BackColor = colorClick; };
            btn.MouseUp += (s, e) => { btn.BackColor = colorHover; };
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
         public static extern IntPtr CreateRoundRectRgn
                       (
                   int nLeftRect,
                    int nTopRect,
                   int nRightRect,
                          int nBottomRect,
                           int nWidthEllipse,
                          int nHeightEllipse
                         );

        private static void RedondearSiempre(Button btn, int radio)
        {
            void Aplicar()
            {
                if (btn.Width <= 0 || btn.Height <= 0)
                    return;

                btn.Region?.Dispose();
                btn.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, btn.Width, btn.Height, radio, radio)
                );
            }

            // Cuando se crea el botón → redondearlo
            btn.HandleCreated += (s, e) => Aplicar();

            // Cuando cambia de tamaño → redondearlo
            btn.Resize += (s, e) => Aplicar();

            // Si ya está creado cuando llamamos a UIHelper → redondearlo
            if (btn.IsHandleCreated)
                Aplicar();
        }


        public static void DataGridViewModerno(DataGridView dgv)
        {
            // Color de fondo general
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;

            // Quitar bordes feos
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;

            // Filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);  // celeste moderno
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Alternar filas (premium)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Encabezados modernos
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Bordes redondeados simulados (mejora visual)
            dgv.GridColor = Color.FromArgb(220, 220, 220);
        }









    }
}
