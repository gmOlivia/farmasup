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

            foreach (DataGridViewRow row in dgvVenda.Rows)
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

            dgvVenda.Columns.Add("Codigo", "Código");
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
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connStr))
                {
                    conexao.Open();

                    // Pega os valores da tela
                    string nomeProduto = lblNome.Text;
                    int quantidadeVenda = (int)numQuantidade.Value;
                    decimal precoUnitario = decimal.Parse(lblValor.Text);
                    decimal desconto = string.IsNullOrEmpty(txtdesconto.Text) ? 0 : decimal.Parse(txtdesconto.Text);

                    // Verifica estoque disponível
                    int estoqueAtual = int.Parse(lblEstoque.Text);
                    if (quantidadeVenda > estoqueAtual)
                    {
                        MessageBox.Show("Estoque insuficiente para essa venda!");
                        return;
                    }

                    // Calcula valor final (já com desconto aplicado por unidade)
                    decimal valorFinal = (precoUnitario - desconto) * quantidadeVenda;

                    // --- 1. Registrar a venda (tabela 'vendas') ---
                    string sqlVenda = @"INSERT INTO vendas (produto, quantidade, preco_unitario, desconto, valor_total, data_venda) 
                                VALUES (@produto, @quantidade, @preco, @desconto, @total, NOW())";

                    MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, conexao);
                    cmdVenda.Parameters.AddWithValue("@produto", nomeProduto);
                    cmdVenda.Parameters.AddWithValue("@quantidade", quantidadeVenda);
                    cmdVenda.Parameters.AddWithValue("@preco", precoUnitario);
                    cmdVenda.Parameters.AddWithValue("@desconto", desconto);
                    cmdVenda.Parameters.AddWithValue("@total", valorFinal);
                    cmdVenda.ExecuteNonQuery();

                    // --- 2. Atualizar o estoque do produto ---
                    string sqlEstoque = "UPDATE produtos SET estoque = estoque - @qtd WHERE nome = @produto";
                    MySqlCommand cmdEstoque = new MySqlCommand(sqlEstoque, conexao);
                    cmdEstoque.Parameters.AddWithValue("@qtd", quantidadeVenda);
                    cmdEstoque.Parameters.AddWithValue("@produto", nomeProduto);
                    cmdEstoque.ExecuteNonQuery();

                    MessageBox.Show("Venda registrada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar venda: " + ex.Message);
            }
        }
    }
}
