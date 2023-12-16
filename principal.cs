using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareaaaaaaaaa222
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias objMaterias = new materias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void parquimetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehiculos objvehiculos = new vehiculos();
            objvehiculos.MdiParent = this;
            objvehiculos.Show();
        }
    }
}
