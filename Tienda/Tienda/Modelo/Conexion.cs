﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tienda.Modelo
{
    public class Conexion
    {
        //string cadena = "data source = LAPTOP-PIA2F9KS\\SQLEXPRESS; initial catalog = BDA2; user id = Usuario; password = Contraseña";
        //protected SqlConnection conex = new SqlConnection("Server=LAPTOP-PIA2F9KS\SQLEXPRESS;DataBase=BDG2;Integrated Security=true");
        //public SqlConnection conex = new SqlConnection();

        //public SqlConnection conex = new SqlConnection("Server=LAPTOP-PIA2F9KS\\SQLEXPRESS;DataBase=BDG2;Integrated Security=true");
        public SqlConnection conex = new SqlConnection("Data Source = LAPTOP-PIA2F9KS\\SQLEXPRESS; Initial Catalog = BDG2; Integrated Security=true");


        public SqlConnection AbrirConexion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();
            return conex;
        }
        public SqlConnection CerrarConexion()
        {
            if (conex.State == ConnectionState.Open)
                conex.Close();
            return conex;
        }
    

    }
}
