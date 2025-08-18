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
    public partial class estoque : Form
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estcad estcad = new estcad();
            estcad.MdiParent = this;
            estcad.Show();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estgen estgen = new estgen();
            estgen.MdiParent = this;
            estgen.Show();
        }
    }
}
