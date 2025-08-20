using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace farmasup
{
    public partial class cadcli : Form
    {
        MySqlConnection conexao;

        public cadcli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chama caixa de dialogo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem| *.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecione a Imagem do Cliente";

            //verifica se pressionou ok
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pega o caminho das fotos
                string caminhocompletofotooriginal = openFileDialog.FileName;
                //pega o nome do arquivo
                string nomeArquivo = Path.GetFileName(caminhocompletofotooriginal);
                //criando o caminho da pasta de imagem no sistema
                string pastaDestino = Path.Combine(Application.StartupPath, "Cliente");
                //verifica se existe o diretorio
                if (!Directory.Exists(pastaDestino))
                {
                    //cria o diretorio
                    Directory.CreateDirectory(pastaDestino);

                }
                string caminhodestino = Path.Combine(pastaDestino, nomeArquivo);
                try
                {
                    //copiando o arquivo para o destino
                    File.Copy(caminhocompletofotooriginal, caminhodestino, true);
                    //mostrando o texto com o nome da foto
                    lblfoto.Text = Path.Combine("Cliente", nomeArquivo);
                    //carregando a foto na picture
                   foto1.Image = Image.FromFile(lblfoto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar a imagem:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblfoto.Text = "";
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// data_source é o caminho do banco de dados
                /// </summary>
                string data_source = "datasource=localhost;username=root;password='';database=farmacia";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into cliente(nome,email,fone,categoria,foto,cpf,cep) values (@nome,@email,@fone,@categoria,@foto,@cpf,@cep)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                command.Parameters.AddWithValue("@nome", txtnome.Text);
                command.Parameters.AddWithValue("@email", txtemail.Text);
                command.Parameters.AddWithValue("@fone", txtfone.Text);
                command.Parameters.AddWithValue("categoria", Convert.ToInt32(txtcategoria.Text));
                command.Parameters.AddWithValue("foto", lblfoto.Text);
                command.Parameters.AddWithValue("cpf", txtcpf.Text);
                command.Parameters.AddWithValue("cep", txtcep.Text);
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadastro realizado!");
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
    }
}
