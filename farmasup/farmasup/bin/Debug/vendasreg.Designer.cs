namespace farmasup
{
    partial class vendasreg
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
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.btnaplicar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbpgto = new System.Windows.Forms.ComboBox();
            this.cmbPagto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnregistro = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca";
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(16, 33);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(230, 22);
            this.txtbusca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "EXIBIR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estoque:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(16, 335);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(74, 22);
            this.numQuantidade.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Desconto";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(122, 335);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(62, 22);
            this.txtdesconto.TabIndex = 10;
            // 
            // btnaplicar
            // 
            this.btnaplicar.Location = new System.Drawing.Point(17, 400);
            this.btnaplicar.Name = "btnaplicar";
            this.btnaplicar.Size = new System.Drawing.Size(92, 28);
            this.btnaplicar.TabIndex = 11;
            this.btnaplicar.Text = "Aplicar";
            this.btnaplicar.UseVisualStyleBackColor = true;
            this.btnaplicar.Click += new System.EventHandler(this.btnaplicar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(16, 61);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(74, 28);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "VENDA";
            // 
            // cmbpgto
            // 
            this.cmbpgto.FormattingEnabled = true;
            this.cmbpgto.Items.AddRange(new object[] {
            "Cartão de Credito",
            "Cartão de Debito",
            "PIX",
            "Dinheiro"});
            this.cmbpgto.Location = new System.Drawing.Point(407, 276);
            this.cmbpgto.Name = "cmbpgto";
            this.cmbpgto.Size = new System.Drawing.Size(152, 24);
            this.cmbpgto.TabIndex = 15;
            // 
            // cmbPagto
            // 
            this.cmbPagto.AutoSize = true;
            this.cmbPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagto.Location = new System.Drawing.Point(407, 250);
            this.cmbPagto.Name = "cmbPagto";
            this.cmbPagto.Size = new System.Drawing.Size(152, 18);
            this.cmbPagto.TabIndex = 16;
            this.cmbPagto.Text = "Forma de Pagamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "TOTAL:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(481, 340);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(18, 20);
            this.lbltotal.TabIndex = 18;
            this.lbltotal.Text = "$";
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(407, 400);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(92, 28);
            this.btnregistro.TabIndex = 19;
            this.btnregistro.Text = "Registrar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(410, 81);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.RowHeadersWidth = 51;
            this.dgvVenda.RowTemplate.Height = 24;
            this.dgvVenda.Size = new System.Drawing.Size(429, 150);
            this.dgvVenda.TabIndex = 20;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(78, 175);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 16);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "label11";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(81, 206);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(51, 16);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "label11";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(81, 240);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(51, 16);
            this.lblEstoque.TabIndex = 23;
            this.lblEstoque.Text = "label11";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(81, 273);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 16);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "label11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "label12";
            // 
            // vendasreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 469);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPagto);
            this.Controls.Add(this.cmbpgto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnaplicar);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.label1);
            this.Name = "vendasreg";
            this.Text = "vendasreg";
            this.Load += new System.EventHandler(this.vendasreg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Button btnaplicar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbpgto;
        private System.Windows.Forms.Label cmbPagto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}