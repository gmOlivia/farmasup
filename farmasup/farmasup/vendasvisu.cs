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
            string connectionString = "datasource=localhost;username=root;password='';database=farmacia";
            conexao = new MySqlConnection(connectionString);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpDe.Value.Date;
            DateTime dataFim = dtpAte.Value.Date.AddDays(1).AddSeconds(-1);

            string query = @"
                SELECT id, data_venda, total, forma_pagamento
                FROM vendas
                WHERE data_venda BETWEEN @inicio AND @fim
                ORDER BY data_venda";

            DataTable dtVendas = new DataTable();
            decimal totalFaturado = 0;

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@inicio", dataInicio);
                cmd.Parameters.AddWithValue("@fim", dataFim);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtVendas);

                dgvVendas.DataSource = dtVendas;

                foreach (DataRow row in dtVendas.Rows)
                {
                    totalFaturado += Convert.ToDecimal(row["total"]);
                }

                lblQtdVendas.Text = dtVendas.Rows.Count.ToString();
                lblTotalFaturado.Text = totalFaturado.ToString("C");
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

        private void vendasvisu_Load(object sender, EventArgs e)
        {

        }
    }
}