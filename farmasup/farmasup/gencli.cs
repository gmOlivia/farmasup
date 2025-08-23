using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace farmasup
{
    public partial class gencli : Form
    {
        MySqlConnection conexao;
        int clienteSelecionado = -1;
        private string connStr = "server=localhost;database=farmacia;uid=root;pwd='';";
        public gencli()
        {
            InitializeComponent();
            conexao = new MySqlConnection(connStr);
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            cmbCategoria.Items.Add("Paciente");
            cmbCategoria.Items.Add("Profissional");
            cmbCategoria.Items.Add("Estabelecimento");
            cmbCategoria.SelectedIndex = 0;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int categoriaCodigo = cmbCategoria.SelectedIndex + 1;

            try
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();

                conexao.Open();

                string query = "SELECT codigocliente, nome, fone, email, cpf, cep FROM cliente WHERE categoria = @categoria";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@categoria", categoriaCodigo);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar clientes: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void gencli_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Paciente");
            cmbCategoria.Items.Add("Profissional");
            cmbCategoria.Items.Add("Estabelecimento");
            cmbCategoria.SelectedIndex = 0; // Seleciona "Paciente" por padrão
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                clienteSelecionado = Convert.ToInt32(row.Cells["codigocliente"].Value);

                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtFone.Text = row.Cells["fone"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtCpf.Text = row.Cells["cpf"].Value.ToString();
                txtCep.Text = row.Cells["cep"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    string query = "DELETE FROM cliente WHERE codigocliente = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", clienteSelecionado);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso!");
                    btnPesquisa.PerformClick(); // Recarrega os dados
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
      

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                string query = "UPDATE cliente SET nome = @nome, fone = @fone, email = @email, cpf = @cpf, cep = @cep WHERE codigocliente = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@fone", txtFone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                cmd.Parameters.AddWithValue("@id", clienteSelecionado);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado com sucesso!");
                btnPesquisa.PerformClick(); // Recarrega os dados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cliente: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
