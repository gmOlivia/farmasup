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
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venreg venreg = new venreg();
            venreg.MdiParent = this;
            venreg.Show();
        }
    }
}
