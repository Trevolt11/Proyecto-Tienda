using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Tienda.Vista
{
    public partial class Main : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            /*
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            */
        }

        //Structs

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95,77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
                private void DisableButton()
            {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);

        }

        private void Categorias_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBcolors.color1);
            Form MC = new MantenimientoCategorias();
            MC.TopLevel = false;
            panelEscritorio.Controls.Add(MC);
            panelEscritorio.Tag = MC;
            MC.Show();
            //this.Close();

        }

        private void Productos_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBcolors.color2);

            Form MCC = new MantenimientoProductos();
            MCC.TopLevel = false;
            panelEscritorio.Controls.Add(MCC);
            panelEscritorio.Tag = MCC;
            MCC.Show();
            //v2.Show();
            //this.Close();
        }

        private void Listado_Click(object sender, EventArgs e)
        {
            

            ActivateButton(sender, RGBcolors.color4);
            Form MC = new ListadoProductos();
            MC.TopLevel = false;
            panelEscritorio.Controls.Add(MC);
            panelEscritorio.Tag = MC;
            MC.Show();
            //this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            Main vmain = new Main();
            vmain.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {
            Main vmain = new Main();
            vmain.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
