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
using Tienda.controlador;
using Tienda.Modelo;
namespace Tienda.Vista

{
    public partial class ListadoProductos : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public DataGridView dataGridView1;
        public Button btn_sech;
        public TextBox txtSech;
        private Form currentChildForm;
        ListadoControlador objN = new ListadoControlador();

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

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sech = new System.Windows.Forms.Button();
            this.txtSech = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1135, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_sech
            // 
            this.btn_sech.Location = new System.Drawing.Point(325, 36);
            this.btn_sech.Name = "btn_sech";
            this.btn_sech.Size = new System.Drawing.Size(75, 23);
            this.btn_sech.TabIndex = 1;
            this.btn_sech.Text = "button1";
            this.btn_sech.UseVisualStyleBackColor = true;
            // 
            // txtSech
            // 
            this.txtSech.Location = new System.Drawing.Point(138, 38);
            this.txtSech.Name = "txtSech";
            this.txtSech.Size = new System.Drawing.Size(146, 20);
            this.txtSech.TabIndex = 2;
            // 
            // ListadoProductos
            // 
            this.ClientSize = new System.Drawing.Size(1185, 680);
            this.Controls.Add(this.txtSech);
            this.Controls.Add(this.btn_sech);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoProductos";
            this.Load += new System.EventHandler(this.ListadoProductos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //CODIGO DE MOSTRAR.
        private void ListadoProductos_Load_1(object sender, EventArgs e)
        {
            Mostrarr();
        }

        private void Mostrarr()
        {
            dataGridView1.DataSource = objN.MostrarProd();
        }
    }
}
