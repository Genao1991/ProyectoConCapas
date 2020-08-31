using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Prj_Datos
{
    class CD_Conexion
    {
        private readonly SqlConnection Conexion = new SqlConnection(@"Server=LAPTOP-M5EHQ7G7\SQLEXPRESS; Database = primerapractica; Integrated Security = True");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion() 
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
