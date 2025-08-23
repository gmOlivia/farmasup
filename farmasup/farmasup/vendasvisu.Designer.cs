namespace farmasup
{
    partial class vendasvisu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdVendas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalFaturado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas Realizadas";
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(61, 123);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(200, 22);
            this.dtpDe.TabIndex = 1;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(14, 128);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(28, 20);
            this.lblDe.TabIndex = 2;
            this.lblDe.Text = "De";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(14, 157);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(32, 20);
            this.lblAte.TabIndex = 3;
            this.lblAte.Text = "Até";
            // 
            // dtpAte
            // 
            this.dtpAte.Location = new System.Drawing.Point(61, 157);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(200, 22);
            this.dtpAte.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Location = new System.Drawing.Point(168, 200);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(96)))));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(335, 157);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowHeadersWidth = 51;
            this.dgvVendas.RowTemplate.Height = 24;
            this.dgvVendas.Size = new System.Drawing.Size(298, 174);
            this.dgvVendas.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(335, 104);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 21);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "RESULTADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "INFORMAÇÕES";
            // 
            // lblQtdVendas
            // 
            this.lblQtdVendas.AutoSize = true;
            this.lblQtdVendas.Location = new System.Drawing.Point(484, 382);
            this.lblQtdVendas.Name = "lblQtdVendas";
            this.lblQtdVendas.Size = new System.Drawing.Size(14, 16);
            this.lblQtdVendas.TabIndex = 9;
            this.lblQtdVendas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vendas no período:";
            // 
            // lblTotalFaturado
            // 
            this.lblTotalFaturado.AutoSize = true;
            this.lblTotalFaturado.Location = new System.Drawing.Point(484, 411);
            this.lblTotalFaturado.Name = "lblTotalFaturado";
            this.lblTotalFaturado.Size = new System.Drawing.Size(14, 16);
            this.lblTotalFaturado.TabIndex = 11;
            this.lblTotalFaturado.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Faturado:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(-15, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 49);
            this.panel1.TabIndex = 15;
            // 
            // vendasvisu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalFaturado);
            this.Controls.Add(this.lblQtdVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.label1);
            this.Name = "vendasvisu";
            this.Text = "vendasvisu";
            this.Load += new System.EventHandler(this.vendasvisu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdVendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalFaturado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}