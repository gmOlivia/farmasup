using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmasup.Classe;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace farmasup
{
    public partial class login : Form
    {
        MySqlConnection conexao;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusuario.Text == "")
                {
                    lblaviso.Text = "Usuário está vazio!";
                    return;
                }
                if (txtsenha.Text == "")
                {
                    lblaviso.Text = "Senha está vazio!";
                    return;
                }
                string data_source = "datasource=localhost;username=root;password='';database=farmacia";

                conexao = new MySqlConnection(data_source);
                string sql = "select codigo,nome,email,senha,ativo, cargo from usuario where email=@email";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@email", txtusuario.Text);
                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    Sessaouser.Cargouser = Convert.ToInt32(reader["cargo"]);
                    Sessaouser.UsuarioLogado = reader["nome"].ToString();
                    Sessaouser.Codigo = Convert.ToInt32(reader["codigo"]);
                    string senha = reader["senha"].ToString();
                    int ativo = Convert.ToInt32(reader["ativo"].ToString());
                    if (ativo == 0)
                    {
                        lblaviso.Text = "Sua conta está desativada";
                        return;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(txtsenha.Text, senha))
                        {
                            MessageBox.Show($"Bem Vindo, {Sessaouser.UsuarioLogado} ");
                            menu principal = new menu();
                            principal.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
    

