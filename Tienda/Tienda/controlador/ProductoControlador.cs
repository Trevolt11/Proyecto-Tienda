using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Modelo;
using Tienda.Vista;


namespace Tienda.controlador
{
    class ProductoControlador
    {
        //esta parte la trabajamos roshby y bradigson y esta es parte de nuestro controlador
        ListadoProductos vista;//esto era el cliente view 
        //Constructor
        public ProductoControlador(ListadoProductos view)
        {
            vista = view;
            //Inicializar eventos de la vista
            vista.Load += new EventHandler(Clientelist); // en el entreparentecis ponemos el metodo de abajo que esta en privado(Clientelist)

        }
        private void Clientelist(object sender, EventArgs e)
        {
            Clientes db = new Clientes();
            vista.dataGridView1.DataSource = db.VerRegistros(vista.textBox1.Text);//este metodo se encuentra en la (clase ClienteDao).
                                                                                  //En el entreparentecis del VerRegistro, se agrega el textbox de busqueda para recibir los datos digitados
        }

    }
}
