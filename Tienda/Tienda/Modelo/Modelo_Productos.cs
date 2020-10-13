using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public class Modelo_Productos
    {
        //bradigson y roshby modificamos aqui
        int idproductos;
        string nombre;
        string codigo;
        string stock;
        string fechvencimiento;
        string descripcion;
        int idcategoria;
        string estado;


        public int IDPRODUCTOS { get; set; }
        public string NOMBRE { get; set; }
        public string CODIGO { get; set; }
        public string STOCK{ get; set; }
        public string FECHVENCIMIENTO  { get; set; }
        //public DateTime FECHVENCIMIENTO  { get; set; }
        public string DESCRIPCION { get; set; }
        public int IDCATEGORIA{ get; set; }
        public string ESTADO { get; set; }

    }

}
