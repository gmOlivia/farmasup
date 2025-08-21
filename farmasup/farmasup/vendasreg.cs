using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace farmasup
{
    public partial class vendasreg : Form
    {
        MySqlConnection conexao;
        private string connStr = "server=localhost;database=farmacia;uid=root;pwd=senha;";

        public vendasreg()
        {
            InitializeComponent();
        }

        private void AtualizarTotal()
        {
            decimal total = 0;

            foreach(DataGridViewRow row in dgvVenda.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
        }
        private void vendasreg_Load(object sender, EventArgs e)
        {
            dgvVenda.Columns.Clear(); // Limpa colunas existentes, se houver

            dgvVenda.AllowUserToAddRows = false; // Impede que o usuário adicione novas linhas manualmente

            // Configurações iniciais do formulário de vendas
            dgvVenda.Columns.Add("Nome", "Nome");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("PrecoUnit", "Preço Unit.");
            dgvVenda.Columns.Add("Desconto", "Desconto");
            dgvVenda.Columns.Add("Subtotal", "Subtotal");

            cmbpgto.Items.AddRange(new string[] { "Dinheiro", "Débito", "Crédito", "Pix" });
            cmbpgto.SelectedIndex = 0;

            lbltotal.Text = "R$0,00";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connStr))
            {
                try
                {
                    conexao.Open();

                    string sql = "SELECT * FROM produtos WHERE nome LIKE @nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", "%" + txtbusca.Text + "%");

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblNome.Text = dr["nome"].ToString();
                        lblValor.Text = Convert.ToDecimal(dr["preco"]).ToString("C");
                        lblEstoque.Text = dr["estoque"].ToString();
                        lblTipo.Text = dr["tipo"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }

                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            } // 🔹 aqui o using garante que a conexão feche automaticamente
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            if (lblNome.Tag == null) return;

            int codigo = Convert.ToInt32(lblNome.Tag);
            string nome = lblNome.Text;
            decimal preco = decimal.Parse(lblValor.Text, System.Globalization.NumberStyles.Currency);
            int estoque = int.Parse(lblEstoque.Text);
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

        private void btnregistro_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connStr))
            {
                conexao.Open();
                var trans = conexao.BeginTransaction();

                try
                {
                    //calcular valor total da venda
                    decimal totalVenda = 0;
                    foreach (DataGridViewRow row in dgvVenda.Rows)
                    {
                        if (row.Cells["Subtotal"].Value != null)
                        {
                            totalVenda += decimal.Parse(row.Cells["Subtotal"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                        }
                    }

                    //inserir venda
                    var cmdVenda = new MySqlCommand("INSERT INTO venda (dataVenda, totalVenda, formaPagamento, desconto) VALUES (NOW(),@totalVenda, @fp, 0); SELECT LAST_INSERT_ID()", conexao, trans);
                    cmdVenda.Parameters.AddWithValue("@fp", cmbPagamento.SelectedItem.ToString());
                    cmdVenda.Parameters.AddWithValue("totalVenda", totalVenda);

                    int idVenda = Convert.ToInt32(cmdVenda.ExecuteScalar());


                    //inserir itens da venda
                    foreach(DataGridViewRow row in dgvVenda.Rows)
                    {
                        int codigoProduto = Convert.ToInt32(row.Cells["Codigo"].Value);
                        int qtd = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        decimal preco = decimal.Parse(row.Cells["PrecoUnit"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                        decimal desconto = decimal.Parse(row.Cells["Desconto"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                        var cmdItem = new MySqlCommand("INSERT INTO vendaitem (idVenda, codigoProduto, quantidade, precoUnitario, desconto) VALUES (@idVenda, @codigoProduto, @quantidade, @precoUnitario, @desconto)", conexao, trans);

                        cmdItem.Parameters.AddWithValue("@idVenda", idVenda);
                        cmdItem.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                        cmdItem.Parameters.AddWithValue("@quantidade", qtd);
                        cmdItem.Parameters.AddWithValue("@precoUnitario", preco);
                        cmdItem.Parameters.AddWithValue("@desconto", desconto);
                        cmdItem.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
