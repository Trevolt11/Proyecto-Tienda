using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.controlador;

namespace Tienda.Vista
{
    public partial class MantenimientoCategorias : Form
    {
        //Construtor
        private string IDcategoria = null;

        private bool Editar = false;
        CategoriaControlador objN = new CategoriaControlador();
        public MantenimientoCategorias()
        {
            InitializeComponent();
            //ListadoControlador control = new ListadoControlador(this);

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
            Mostrarr();

        }

        private void Mostrarr()

        {
            CategoriaControlador objA = new CategoriaControlador();
            dataGridView1.DataSource = objN.MostrarProd();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objN.InsertarPRod(textBox1.Text, textBox2.Text, textBox3.Text);
                    MessageBox.Show("Se inserto correctamente");
                    Mostrarr();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erros al insertar: " + ex);
                }
            }
            if (Editar == true)
            {
                objN.InsertarPRod(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Se inserto correctamente");
                Mostrarr();
                Editar = false;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells["IDcategoriap"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["nombre_producto"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDcategoria = dataGridView1.CurrentRow.Cells["IDcategoria"].Value.ToString();
                objN.EliminarPRod(IDcategoria);
                MessageBox.Show("Eliminado correctamente");
                Mostrarr();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
