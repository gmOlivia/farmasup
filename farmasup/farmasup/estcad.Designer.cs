namespace farmasup
{
    partial class estcad
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
            this.Foto = new System.Windows.Forms.PictureBox();
            this.txtnomep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncads = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(486, 51);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(273, 328);
            this.Foto.TabIndex = 0;
            this.Foto.TabStop = false;
            // 
            // txtnomep
            // 
            this.txtnomep.Location = new System.Drawing.Point(34, 75);
            this.txtnomep.Name = "txtnomep";
            this.txtnomep.Size = new System.Drawing.Size(377, 22);
            this.txtnomep.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(34, 148);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(176, 148);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 22);
            this.txttipo.TabIndex = 6;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(311, 148);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(100, 22);
            this.txtquantidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(37, 245);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(377, 22);
            this.txtdesc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição";
            // 
            // btncads
            // 
            this.btncads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.btncads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncads.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncads.ForeColor = System.Drawing.SystemColors.Control;
            this.btncads.Location = new System.Drawing.Point(37, 348);
            this.btncads.Name = "btncads";
            this.btncads.Size = new System.Drawing.Size(107, 30);
            this.btncads.TabIndex = 11;
            this.btncads.Text = "Cadastrar";
            this.btncads.UseVisualStyleBackColor = false;
            this.btncads.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(486, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Inserir foto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(486, 386);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(74, 16);
            this.lblfoto.TabIndex = 13;
            this.lblfoto.Text = "Nome Foto";
            this.lblfoto.Click += new System.EventHandler(this.label6_Click);
            // 
            // estcad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomep);
            this.Controls.Add(this.Foto);
            this.Name = "estcad";
            this.Text = "estcad";
            this.Load += new System.EventHandler(this.estcad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.TextBox txtnomep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncads;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblfoto;
    }
}