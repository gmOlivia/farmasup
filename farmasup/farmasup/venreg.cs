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
    public partial class venreg : Form
    {
        public venreg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (lblnomeproduto.Tag == null) return;

            int codigo = Convert.ToInt32(lblnomeproduto.Tag);
            string nome = lblnomeproduto.Text;
            decimal preco = decimal.Parse(lblvalor.Text, System.Globalization.NumberStyles.Currency);
            int estoque = int.Parse(lblestoque.Text);
            int qtd = (int)numQuantidade.Value;
            decimal desconto = 0;

            decimal.TryParse(txtdesconto.Text, out desconto);

            if (qtd <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida!");
                return;
            }

            if (qtd > estoque)
            {
                MessageBox.Show("Estoque insuficiente!");
                return;
            }

            decimal subtotal = (preco * qtd) - desconto;

            dgvVenda.Rows.Add(codigo, nome, qtd, preco.ToString("C"), desconto.ToString("C"), subtotal.ToString("C"));

            AtualizarTotal();
        }
    }
}
