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
        //string txt;
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
            
        }
        private void limpiarForm()
        {
  
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void Listado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells["IDProductos"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["Vencimiento"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["IDCategoria"].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();

            }
            else 
                MessageBox.Show("seleccione una fila por favor");
        
    }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Idproductos = dataGridView1.CurrentRow.Cells["IDProductos"].Value.ToString();
                objN.EliminarPRod(Idproductos);
                MessageBox.Show("Eliminado correctamente");
                Mostrarr();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void iconButton4_Click(object sender, EventArgs e)
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
            if (Editar == true)
            {
                objN.InsertarPRod(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                MessageBox.Show("Se inserto correctamente");
                Mostrarr();
                Editar = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

 }


