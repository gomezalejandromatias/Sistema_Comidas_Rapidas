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

        public static void BotonAmarilloPremium(Button btn)
        {
            // 🎨 PALETA Warning moderna
            Color colorBase = Color.FromArgb(241, 196, 15);   // Amarillo fuerte
            Color colorHover = Color.FromArgb(243, 203, 49);  // Amarillo más suave
            Color colorClick = Color.FromArgb(212, 172, 13);  // Amarillo oscuro para click

            // Estilo base
            btn.BackColor = colorBase;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Bordes redondeados (si ya usás esto en otros)
            btn.Region = System.Drawing.Region.FromHrgn(
                UIHelper.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 18, 18)
            );

            // Hover, Leave, Click, Up
            btn.MouseEnter += (s, e) => btn.BackColor = colorHover;
            btn.MouseLeave += (s, e) => btn.BackColor = colorBase;
            btn.MouseDown += (s, e) => btn.BackColor = colorClick;
            btn.MouseUp += (s, e) => btn.BackColor = colorHover;

            // Mantener redondeado si cambia el tamaño
            btn.Resize += (s, e) =>
            {
                btn.Region = System.Drawing.Region.FromHrgn(
                    UIHelper.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 18, 18)
                );
            };
        }

        public static void LabelPremium(Label lbl)
        {
            lbl.ForeColor = Color.FromArgb(44, 62, 80); // Gris oscuro elegante
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        public static void LabelTituloPremium(Label lbl)
        {
            lbl.ForeColor = Color.FromArgb(26, 82, 118); // Azul profesional oscuro
            lbl.Font = new Font("Segoe UI", 22, FontStyle.Bold);
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

        public static void ListViewModerno(ListView lv)
        {
            // Vista en detalles (columnas)
            lv.View = View.Details;

            // Selección linda
            lv.FullRowSelect = true;
            lv.HideSelection = false;
            lv.MultiSelect = false;

            // Estilo general
            lv.BackColor = Color.White;
            lv.ForeColor = Color.FromArgb(44, 62, 80);          // gris azulado premium
            lv.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Borde limpio
            lv.BorderStyle = BorderStyle.None;

            // Líneas de grilla (si querés más “tabla”, poné true)
            lv.GridLines = false;

            // Encabezados no clickeables (más “app” que “explorador de archivos”)
            lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            // Color de selección más parecido al DataGridView
            lv.OwnerDraw = true;

            lv.DrawColumnHeader += (s, e) =>
            {
                using (var backBrush = new SolidBrush(Color.FromArgb(52, 152, 219))) // azul header
                using (var textBrush = new SolidBrush(Color.White))
                using (var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, new Font("Segoe UI", 10, FontStyle.Bold), textBrush, e.Bounds, sf);
                }
            };

            lv.DrawItem += (s, e) =>
            {
                // Nada acá, se dibuja en DrawSubItem
            };

            lv.DrawSubItem += (s, e) =>
            {
                bool selected = (e.ItemState & ListViewItemStates.Selected) != 0;

                Color backColor = selected
                    ? Color.FromArgb(52, 152, 219)   // azul selección
                    : Color.White;

                Color textColor = selected ? Color.White : Color.FromArgb(44, 62, 80);

                using (var backBrush = new SolidBrush(backColor))
                using (var textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(e.SubItem.Text, lv.Font, textBrush, e.Bounds);
                }
            };
        }

        public static void ComboBoxModerno(ComboBox cb)
        {
            // Fondo y texto
            cb.BackColor = Color.White;
            cb.ForeColor = Color.FromArgb(44, 62, 80);   // gris azulado premium
            cb.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            cb.FlatStyle = FlatStyle.Flat;
            cb.Cursor = Cursors.Hand;

            cb.DrawMode = DrawMode.OwnerDrawFixed;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

            cb.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;

                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

                Color backColor = selected
                    ? Color.FromArgb(52, 152, 219)     // Azul selección
                    : Color.White;

                Color textColor = selected
                    ? Color.White
                    : Color.FromArgb(44, 62, 80);

                using (SolidBrush bg = new SolidBrush(backColor))
                    e.Graphics.FillRectangle(bg, e.Bounds);

                // 👇 ESTA ES LA CLAVE: respeta DisplayMember
                string texto = cb.GetItemText(cb.Items[e.Index]);

                using (SolidBrush tx = new SolidBrush(textColor))
                    e.Graphics.DrawString(texto, cb.Font, tx, e.Bounds);

                e.DrawFocusRectangle();
            };
        }









    }
}
