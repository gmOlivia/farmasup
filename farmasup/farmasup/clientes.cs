using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmasup
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcli cadcli = new cadcli();
            cadcli.MdiParent = this; 
            cadcli.Show();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gencli gencli = new gencli();
            gencli.MdiParent = this;
            gencli.Show();
        }
    }
}
