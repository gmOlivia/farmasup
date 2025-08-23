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

namespace farmasup
{
    public partial class estgen : Form
    {
        MySqlConnection conexao;
        private string connStr = "server=localhost;database=farmacia;uid=root;pwd='';";

        public estgen()
        {
            InitializeComponent();
            conexao = new MySqlConnection(connStr);
            CarregarTipos();
        }

        private void CarregarTipos()
        {
            cmbTipo.Items.Add("Frutado");
            cmbTipo.Items.Add("Chá");
            cmbTipo.Items.Add("Cremoso");
            cmbTipo.SelectedIndex = 0;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int tipoCodigo = Convert.ToInt32(cmbTipo.SelectedValue);

            try
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();

                conexao.Open();

                string query = "SELECT codigoProduto, nome, descricao, valor, estoque FROM produto WHERE tipo = @tipo";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@tipo", tipoCodigo);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ConfigurarDataGridView();
                dgvEstoque.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar produtos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void estgen_Load(object sender, EventArgs e)
        {
            try
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();

                conexao.Open();

                string query = "SELECT codigotipo, tipo FROM tipo";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTipo.DataSource = dt;
                cmbTipo.DisplayMember = "tipo";       // O que aparece para o usuário
                cmbTipo.ValueMember = "codigotipo";   // O valor interno usado na pesquisa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tipos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

     
        }

        private void ConfigurarDataGridView()
        {
            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.MultiSelect = false;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ReadOnly = false;

            dgvEstoque.Columns.Clear();

            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "codigoProduto",
                HeaderText = "Código",
                Name = "codigoProduto",
                ReadOnly = true
            });

            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nome",
                HeaderText = "Nome",
                Name = "nome"
            });

            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "descricao",
                HeaderText = "Descrição",
                Name = "descricao"
            });

            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "valor",
                HeaderText = "Valor",
                Name = "valor"
            });

            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "estoque",
                HeaderText = "Estoque",
                Name = "estoque"
            });
        }

        
        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];

                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtDescricao.Text = row.Cells["descricao"].Value.ToString();
                txtValor.Text = row.Cells["valor"].Value.ToString();
                txtEstoque.Text = row.Cells["estoque"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            int codigoProduto = Convert.ToInt32(dgvEstoque.SelectedRows[0].Cells["codigoProduto"].Value);
            string novoNome = dgvEstoque.SelectedRows[0].Cells["nome"].Value.ToString();
            string novaDescricao = dgvEstoque.SelectedRows[0].Cells["descricao"].Value.ToString();
            decimal novoValor = Convert.ToDecimal(dgvEstoque.SelectedRows[0].Cells["valor"].Value);
            int novoEstoque = Convert.ToInt32(dgvEstoque.SelectedRows[0].Cells["estoque"].Value);

            try
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();

                conexao.Open();

                string query = @"UPDATE produto 
                         SET nome = @nome, descricao = @descricao, valor = @valor, estoque = @estoque 
                         WHERE codigoProduto = @codigoProduto";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", novoNome);
                cmd.Parameters.AddWithValue("@descricao", novaDescricao);
                cmd.Parameters.AddWithValue("@valor", novoValor);
                cmd.Parameters.AddWithValue("@estoque", novoEstoque);
                cmd.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar produto: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            int codigoProduto = Convert.ToInt32(dgvEstoque.SelectedRows[0].Cells["codigoProduto"].Value);

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo);
            if (resultado != DialogResult.Yes)
                return;

            try
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();

                conexao.Open();

                string query = "DELETE FROM produto WHERE codigoProduto = @codigoProduto";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
