using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Entidades;
using Prj_Logica;

namespace ProyectoConCapas
{
    public partial class MenuEmpleados : Form
    {
        private LG_Empleados EmpleadosMng = new LG_Empleados();
        public MenuEmpleados()
        {
            InitializeComponent();
            MostrarEmpelados();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Ent_Empleados empleado = new Ent_Empleados
            {
                EmpNo = Convert.ToInt32(tbxNroEmp.Text),
                Apellido = tbxApellido.Text,
                Oficio = tbxOficio.Text,
                Salario = float.Parse(tbxSalario.Text),
                FechaAlta = tbxFechaAlta.Value,

            };
            try { 
            EmpleadosMng.InsertarEmpleado(empleado);
                MessageBox.Show("Usuario insertado correctamente");
                DgvMenuEmpleados.Update();
                
            }
            catch (Exception) 
            {
                MessageBox.Show("Error al insertar nuevo usuario");

            }
        }
        private void MostrarEmpelados() 
        {
            DgvMenuEmpleados.DataSource = EmpleadosMng.MostrarEmpleados();
        }
    }
}
