using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Modelo;
using Tienda.Vista;
using Tienda.controlador;
using System.Data;


namespace Tienda.controlador
{
    public class CategoriaControlador
    {
        private Modelo_Categoria objetoCD = new Modelo_Categoria();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(string IDcategoria, string nombre_producto, string estado)
        {
            objetoCD.Insertar(Convert.ToInt32(IDcategoria), nombre_producto, estado);
        }
        public void EditarProd(string IDcategoria, string nombre_producto, string estado)
        {
            objetoCD.Editar(Convert.ToInt32(IDcategoria), nombre_producto, estado);
        }
        public void EliminarPRod(string IDcategoria)
        {
            objetoCD.Eliminar(Convert.ToInt32(IDcategoria));
        }

    }
}
