using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tienda.Modelo;
using Tienda.Vista;



namespace Tienda.Modelo
{
    class Modelo_ListadoProductos

        
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
            comando.CommandText = "	select Productos.*,categorias.nombre_producto from Productos inner join categorias on Productos.IDcategoriap = categorias.IDcategoria";
            //comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexx.CerrarConexion();
            return tabla;

        }
    }
 }
