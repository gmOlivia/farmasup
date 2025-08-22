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
            conexao = new MySqlConnection("server=localhost;database=farmacia;uid=root;pwd='';");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void vendasvisu_Load(object sender, EventArgs e)
        {
            //formatar o datapicker
            dtpDe.Format = DateTimePickerFormat.Short;
            dtpAte.Format = DateTimePickerFormat.Short;
            dtpDe.Value = DateTime.Today;
            dtpAte.Value = DateTime.Today;

            //configurações de DGV
            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.ReadOnly = true;
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.Columns.Clear();

            //Colunas → DataPropertyName deve bater com os nomes vindos do SELECT
            dgvVendas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "id",
                Width = 60
            });
            dgvVendas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colData",
                HeaderText = "Data/Hora",
                DataPropertyName = "data_venda",
                Width = 150,
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" }
            });
            dgvVendas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFP",
                HeaderText = "Forma de Pagamento",
                DataPropertyName = "forma_pagamento",
                Width = 150
            });
            dgvVendas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Total",
                DataPropertyName = "total",
                Width = 100,
                DefaultCellStyle = { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            LimparResumo();
        }

        private void LimparResumo()
        {
            lblQtdVendas.Text = "0";
            lblQtdVendas.Text = (0m).ToString("C2");
            lblTicketMedio.Text = (0m).ToString("C2");
            lblItensVendidos.Text = "0";
        }
    }
}
        
