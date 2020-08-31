using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Prj_Datos;
using Prj_Entidades;


namespace Prj_Logica
{
    public  class LG_Empleados
    {
        CD_Empleados CD_Empleados = new CD_Empleados(); 
        public void InsertarEmpleado(Ent_Empleados Empleados) 
        {
            CD_Empleados.InsertarEmpleados(Empleados);
        }
        public DataTable MostrarEmpleados() 
        {
           DataTable dt = CD_Empleados.MostrarTodos();
            return dt; 
        }
    }
}
