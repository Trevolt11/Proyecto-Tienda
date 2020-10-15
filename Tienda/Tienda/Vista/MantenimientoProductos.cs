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
using Tienda.Modelo;

namespace Tienda.Vista

   
{
    public partial class MantenimientoProductos : Form
    {
        private string Idproductos = null;
        string txt;
        ProductoControlador objN = new ProductoControlador();
        private bool Editar = false;

        public MantenimientoProductos()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;



        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            Mostrarr();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        public void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objN.InsertarPRod(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                    MessageBox.Show("Se inserto correctamente");
                    Mostrarr();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erros al insertar: " + ex);
                }
            }
            if (Editar == true) {
                objN.InsertarPRod(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                MessageBox.Show("Se inserto correctamente");
                Mostrarr();
                Editar = false;
            }

        }

        private void Mostrarr()

        {
            ProductoControlador objA = new ProductoControlador();
            dataGridView1.DataSource = objN.MostrarProd();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells["Idproductos"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["nombre_producto"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["fecha_vencimiento"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["IDcategoriap"].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void limpiarForm()
        {
  
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarPRod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProdctos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
    }
}
