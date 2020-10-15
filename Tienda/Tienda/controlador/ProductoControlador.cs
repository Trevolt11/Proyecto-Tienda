using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Modelo;
using Tienda.Vista;
using Tienda.controlador;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Data;

namespace Tienda.controlador

    //Mantenimiento producto
{
    public class ProductoControlador
    {
        private Modelo_Productos objetoCD = new Modelo_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod (string idproductos, string nombre_producto, string codigo, string stock, string fechvencimiento, string descripcion, string idcategoria, string estado)        
        {
            objetoCD.Insertar(Convert.ToInt32(idproductos), nombre_producto, Convert.ToInt32(codigo), stock, fechvencimiento, descripcion, Convert.ToInt32(idcategoria), estado);
        }
        public void EditarProd(string idproductos, string nombre_producto, string codigo, string stock, string fechvencimiento, string descripcion, string idcategoria, string estado)
        {
            objetoCD.Editar(Convert.ToInt32(idproductos), nombre_producto, Convert.ToInt32(codigo), stock, fechvencimiento, descripcion, Convert.ToInt32(idcategoria), estado);
        }
        public void EliminarPRod(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
