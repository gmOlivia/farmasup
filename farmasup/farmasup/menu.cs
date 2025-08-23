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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            estoque estoque = new estoque();
            estoque.ShowDialog();
        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            vendas.ShowDialog();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.ShowDialog();
        }


        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
