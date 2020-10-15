using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    /*Vista: presentación UI
    Modelo: Datos y negocio
    Controlador: eventos y las comunicaciones entre modelo y vista.*/
    public class Modelo_Productos
    {

        




        public Conexion conexx = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        //Metodos Crud
        //Metodo, para agregar los registros
        public DataTable Mostrar()
        {

            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = "select * from Productos";
            //comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexx.CerrarConexion();
            return tabla;

        }
        
        public void Insertar(int idproductos, string nombre_producto, int codigo, string stock, string fechvencimiento, string descripcion, int idcategoria, string estado )
        {
            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = ("insert into Productos values (" + idproductos + ",'" + nombre_producto + "'," + codigo + "," + stock + ",'" + fechvencimiento + "','" + descripcion + "'," + idcategoria + ",'" + estado + "')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();


        }
        public void Editar(int idproductos, string nombre_producto, int codigo, string stock, string fechvencimiento, string descripcion, int idcategoria, string estado)
        {
            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = "ModificarRegistro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Idproductos", idproductos);
            comando.Parameters.AddWithValue("@nombre_producto", nombre_producto);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@fecha_vencimiento", fechvencimiento);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@@IDcategoriap", idcategoria);
            comando.Parameters.AddWithValue("@@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexx.CerrarConexion();
        }
        public void Eliminar(int idproductos)
        {
            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexx.CerrarConexion();
        }

    }

}
