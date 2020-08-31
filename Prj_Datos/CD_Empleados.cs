using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Prj_Entidades;



namespace Prj_Datos
{
    public class CD_Empleados
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        #region variables 
        SqlDataReader scaner;
         DataTable  tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        #endregion

        public DataTable MostrarTodos() 
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "proc_EmpleadosLoadAll";
                cmd.CommandType = CommandType.StoredProcedure;
                scaner = cmd.ExecuteReader();
                tabla.Load(scaner);

                return tabla;
            }
            catch (Exception)
            {

                return null; 
            }
            finally { conexion.CerrarConexion(); }


        }
        /*
        public CD_Empleados BuscarEmpleado(int EmpNo) 
        {
            CD_Empleados empleado = new CD_Empleados();

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "proc_EmpleadosLoadByPrimaryKey";
            cmd.CommandType = CommandType.StoredProcedure;
           
            return empleado; 
        }*/

        public void InsertarEmpleados(Ent_Empleados empleado) 
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "proc_EmpleadosInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpNo", empleado.EmpNo);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@Oficio", empleado.Oficio);
            cmd.Parameters.AddWithValue("@FechaAlta", empleado.FechaAlta);
            cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }

        }
        public void EditarEmpleados(Ent_Empleados empleado)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "proc_EmpleadosUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpNo", empleado.EmpNo);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@Oficio", empleado.Oficio);
            cmd.Parameters.AddWithValue("@FechaAlta", empleado.FechaAlta);
            cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }

        }
        public void EliminarEmpleados(int Empno)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "proc_EmpleadosDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpNo", Empno);
            
          
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }

        }
    }
}
