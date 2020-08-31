using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace Prj_Entidades
{
    public class Ent_Empleados
    {
       
        public int EmpNo { get; set; }
        public string Apellido { get; set; }
        public string Oficio { get; set; }
        public DateTime FechaAlta { get; set; }
        public float Salario { get; set; }

    }
}
