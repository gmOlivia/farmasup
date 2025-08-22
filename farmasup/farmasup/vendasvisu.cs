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
    public partial class vendasvisu : Form
    {
        MySqlConnection conexao;
        public vendasvisu()
        {
            InitializeComponent();
            conexao = new MySqlConnection("server=localhost;database=farmacia;uid=root;pwd=senha;");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                string sql = @"SELECT v.id AS 'Código Venda',
                                      v.data_venda AS 'Data',
                                      v.total AS 'Total',
                                      v.forma_pagamento AS 'Forma de Pagamento'
                               FROM vendas v
                               WHERE v.data_venda BETWEEN @dataDe AND @dataAte
                               ORDER BY v.data_venda";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@dataDe", dtpDe.Value.Date);
                cmd.Parameters.AddWithValue("@dataAte", dtpAte.Value.Date.AddDays(1).AddSeconds(-1));
                //
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvVendas.DataSource = dt;
                // calcula o total do período
                decimal soma = 0;
                foreach (DataRow row in dt.Rows)
                {
                    soma += Convert.ToDecimal(row["Total"]);
                }

                lblTotalPeriodo.Text = $"Total no período: R$ {soma:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar vendas: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
        
