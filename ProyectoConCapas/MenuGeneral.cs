using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoConCapas
{
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEmpleados me = new MenuEmpleados();
            this.Hide();
            me.Show(); 
        }
    }
}
