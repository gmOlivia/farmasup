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
        private string connStr = "server=localhost;database=farmacia;uid=root;pwd='';";

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

                    string sql = "SELECT * FROM produto WHERE nome LIKE @nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", "%" + txtbusca.Text + "%");

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        label12.Text= dr["codigoProduto"].ToString();
                        lblNome.Text = dr["nome"].ToString();
                        lblValor.Text = dr["valor"].ToString();
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
            if (lblNome.Text == null) return;

            int codigo = Convert.ToInt32(label12.Text);
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

            dgvVenda.Rows.Add(codigo, nome, qtd, preco.ToString(), desconto.ToString(), subtotal.ToString());
            decimal total = 0;
            
            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            lbltotal.Text = total.ToString();
            // AtualizarTotal();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connStr))
                {
                    conexao.Open();

                    // Pega os valores da tela
                    //precisa fazer a leitura do datagridview em vex da tela
                    int codigo = 0;

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
                    string sqlVenda = @"INSERT INTO vendas (total, data_venda,forma_pagamento) 
                                VALUES (@total, NOW(),@forma)";

                    MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, conexao);
                    cmdVenda.Parameters.AddWithValue("@forma", cmbpgto.Text);
                    cmdVenda.Parameters.AddWithValue("@total", lbltotal.Text);
                    cmdVenda.ExecuteNonQuery();
                    int venda = Convert.ToInt32(cmdVenda.LastInsertedId);
                    // --- 1. Registrar a venda (tabela 'vendas') ---
                    string sqlVendaitens = @"INSERT INTO venda_itens (produto_id,venda_id, quantidade, preco_unitario, desconto) 
                                VALUES (@produto_id,@venda_id, @quantidade, @preco, @desconto)";
                    // Percorre todas as linhas do DataGridView
                    for (int i = 0; i < dgvVenda.Rows.Count; i++)
                    {
                        // Verifica se a linha não é a linha de "novos registros" (se houver)
                        if (!dgvVenda.Rows[i].IsNewRow)
                        {
                            // Obtém os valores das células de uma linha
                            codigo = Convert.ToInt32(dgvVenda.Rows[i].Cells[0].Value.ToString()); // Assumindo que o ID está na primeira coluna
                            quantidadeVenda = Convert.ToInt32(dgvVenda.Rows[i].Cells[2].Value.ToString()); // Assumindo que o nome está na segunda coluna
                            precoUnitario = Convert.ToDecimal(dgvVenda.Rows[i].Cells[3].Value.ToString());
                            desconto = Convert.ToDecimal(dgvVenda.Rows[i].Cells[4].Value.ToString());

                    
                    MySqlCommand cmdVendaitens = new MySqlCommand(sqlVendaitens, conexao);
                        cmdVendaitens.Parameters.AddWithValue("@produto_id", codigo);
                        cmdVendaitens.Parameters.AddWithValue("@venda_id", venda);

                        cmdVendaitens.Parameters.AddWithValue("@quantidade", quantidadeVenda);
                        cmdVendaitens.Parameters.AddWithValue("@preco", precoUnitario);
                        cmdVendaitens.Parameters.AddWithValue("@desconto", desconto);
                        cmdVendaitens.ExecuteNonQuery();
                        }
                    }
               
                    // --- 2. Atualizar o estoque do produto ---
                    string sqlEstoque = "UPDATE produto SET estoque = estoque - @qtd WHERE nome = @produto";
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
