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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace farmasup
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// data_source é o caminho do banco de dados
                /// </summary>
                string data_source = "datasource=localhost;username=root;password='';database=farmacia";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into usuario(nome,email,senha,cargo, ativo) values (@nome,@email,@senha,@cargo, 1)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = txtsenha.Text.Trim();// limpar os espaços gerados
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                command.Parameters.AddWithValue("@nome", txtnome.Text);
                command.Parameters.AddWithValue("@email", txtemail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", txtcargo.Text);
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }
    }
}
    

