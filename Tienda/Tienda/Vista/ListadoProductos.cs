using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Tienda.Vista
{
    public partial class ListadoProductos : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public ListadoProductos()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }





        private void panelLeftBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Categorias_Click(object sender, EventArgs e)
        {

        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
