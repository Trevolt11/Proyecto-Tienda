using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    class Modelo_Categoria
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
            comando.CommandText = "select * from categorias";
            //comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexx.CerrarConexion();
            return tabla;

        }

        public void Insertar(int IDcategoria, string nombre_producto, string estado)
        {
            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = "insert into categorias values(" + IDcategoria + ",'" + nombre_producto + "','" + estado + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();


        }
        public void Editar(int IDcategoria, string nombre_producto, string estado)
        {
            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = "ModificarRegistro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDcategoriap", IDcategoria);
            comando.Parameters.AddWithValue("@nombre_producto", nombre_producto);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexx.CerrarConexion();
        }
        public void Eliminar(int IDcategoria)
        {
            comando.Connection = conexx.AbrirConexion();
            comando.CommandText = ("delete from Productos where Idproductos= " + IDcategoria + "");
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            conexx.CerrarConexion();
        }
    }
}
