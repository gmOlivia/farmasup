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
    public partial class estcad : Form
    {
        MySqlConnection conexao;
        public estcad()
        {
            InitializeComponent();
        }

        private void estcad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// data_source é o caminho do banco de dados
                /// </summary>
                string data_source = "datasource=localhost;username=root;password='';database=farmacia";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into produto(nome,valor,descricao,quantidade,tipo,foto) values (@nome,@valor,@descricao,@quantidade,@tipo,@foto)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                command.Parameters.AddWithValue("@nome", txtnomep.Text);
                command.Parameters.AddWithValue("@valor",Convert.ToDecimal(txtvalor.Text));
                command.Parameters.AddWithValue("@descricao", txtdesc.Text);
                command.Parameters.AddWithValue("@quantidade",Convert.ToInt32(txtquantidade.Text));
                command.Parameters.AddWithValue("@foto", lblfoto.Text);
                command.Parameters.AddWithValue("@tipo",Convert.ToInt32(txttipo.Text));
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //chama caixa de dialogo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem| *.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecione a Imagem do Produto";

            //verifica se pressionou ok
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pega o caminho das fotos
                string caminhocompletofotooriginal = openFileDialog.FileName;
                //pega o nome do arquivo
                string nomeArquivo = Path.GetFileName(caminhocompletofotooriginal);
                //criando o caminho da pasta de imagem no sistema
                string pastaDestino = Path.Combine(Application.StartupPath, "Produto");
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
                    lblfoto.Text = Path.Combine("Produto", nomeArquivo);
                    //carregando a foto na picture
                    Foto.Image = Image.FromFile(lblfoto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar a imagem:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblfoto.Text = "";
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}