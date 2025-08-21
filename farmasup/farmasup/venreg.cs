using MySql.Data.MySqlClient;
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
    public partial class venreg : Form
    {
        MySqlConnection conexao;
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

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (dgvVenda.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado!");
                return;
            }

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var trans = conn.BeginTransaction();

                try
                {
                    // calcular valor total
                    decimal valorTotal = 0;
                    foreach (DataGridViewRow row in dgvVenda.Rows)
                    {
                        valorTotal += decimal.Parse(row.Cells["Subtotal"].Value.ToString(),
                                        System.Globalization.NumberStyles.Currency);
                    }

                    // inserir venda
                    var cmdVenda = new MySqlCommand(
                        "INSERT INTO venda (dataVenda, formaPagamento, desconto, valorTotal) VALUES (NOW(), @fp, 0, @total); SELECT LAST_INSERT_ID();",
                        conn, trans);
                    cmdVenda.Parameters.AddWithValue("@fp", cmbpagamento.SelectedItem.ToString());
                    cmdVenda.Parameters.AddWithValue("@total", valorTotal);
                    int idVenda = Convert.ToInt32(cmdVenda.ExecuteScalar());

                    // inserir itens
                    foreach (DataGridViewRow row in dgvVenda.Rows)
                    {
                        int codigoProduto = Convert.ToInt32(row.Cells["Codigo"].Value);
                        int qtd = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        decimal preco = decimal.Parse(row.Cells["PrecoUnit"].Value.ToString(),
                                        System.Globalization.NumberStyles.Currency);
                        decimal desconto = decimal.Parse(row.Cells["Desconto"].Value.ToString(),
                                        System.Globalization.NumberStyles.Currency);

                        var cmdItem = new MySqlCommand(
                            "INSERT INTO vendaItem (idVenda, codigoProduto, quantidade, precoUnitario) VALUES (@idVenda, @prod, @qtd, @preco)",
                            conn, trans);
                        cmdItem.Parameters.AddWithValue("@idVenda", idVenda);
                        cmdItem.Parameters.AddWithValue("@prod", codigoProduto);
                        cmdItem.Parameters.AddWithValue("@qtd", qtd);
                        cmdItem.Parameters.AddWithValue("@preco", preco);
                        cmdItem.ExecuteNonQuery();

                        // atualizar estoque
                        var cmdUpdate = new MySqlCommand(
                            "UPDATE produto SET quantidade = quantidade - @qtd WHERE codigoProduto=@id", conn, trans);
                        cmdUpdate.Parameters.AddWithValue("@qtd", qtd);
                        cmdUpdate.Parameters.AddWithValue("@id", codigoProduto);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    trans.Commit();

                    MessageBox.Show("Venda registrada com sucesso!");
                    dgvVenda.Rows.Clear();
                    AtualizarTotal();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao registrar venda: " + ex.Message);
                }
            }
        }
        string connStr = "server=localhost;database=farmacia;uid=root;pwd=senha;";
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    string sql = "SELECT codigoProduto, nome, valor, quantidade, tipo FROM produto WHERE nome LIKE @nome OR codigoProduto = @codigo";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", "%" + txtbuscar.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@codigo", txtbuscar.Text.Trim());

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblnomeproduto.Text = reader["nome"].ToString();
                        lblvalor.Text = Convert.ToDecimal(reader["valor"]).ToString("C");
                        lblestoque.Text = reader["quantidade"].ToString();
                        lbltipo.Text = reader["tipo"].ToString();
                        lblnomeproduto.Tag = reader["codigoProduto"]; // armazenar ID escondido
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }
                }
            }
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
            lbltotal.Text = total.ToString("C");
        }
    }
}
