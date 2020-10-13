using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tienda.Modelo
{
    class Clientes : Conexion
    {
        
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();
        //Metodos Crud
        public List<Modelo_Productos> VerRegistros(string Condicion)
        {
           // Comando.Connection = conexion; esta es la conecion a base de dato la' comentamos
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);
           // conexion.Open(); esta conecion es la de cerrar y tabien la eliminamos
            LeerFilas = Comando.ExecuteReader();
            List<Modelo_Productos> ListaGenerica = new List<Modelo_Productos>();
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new Modelo_Productos
                {
                    IDPRODUCTOS= LeerFilas.GetInt32(0),
                    NOMBRE = LeerFilas.GetString(1),
                    CODIGO = LeerFilas.GetString(2),
                    STOCK = LeerFilas.GetString(3),
                    FECHVENCIMIENTO = LeerFilas.GetString(4),
                    IDCATEGORIA= LeerFilas.GetInt32(4),
                    DESCRIPCION = LeerFilas.GetString(4),
                    ESTADO= LeerFilas.GetString(4),

                });
            }
            //Con esto closes y return se elimina el error de (VerRegistros)
            LeerFilas.Close();
            //conexion.Close();
            return ListaGenerica;


        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }
}
