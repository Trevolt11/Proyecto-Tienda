using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Vista
{
    public partial class MantenimientoCategorias : Form
    {
        //Construtor
        public MantenimientoCategorias()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
