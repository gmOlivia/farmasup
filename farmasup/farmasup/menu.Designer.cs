namespace farmasup
{
    partial class menu
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
            this.btnestoque = new System.Windows.Forms.Button();
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnestoque
            // 
            this.btnestoque.Location = new System.Drawing.Point(50, 206);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(182, 47);
            this.btnestoque.TabIndex = 0;
            this.btnestoque.Text = "Estoque";
            this.btnestoque.UseVisualStyleBackColor = true;
            this.btnestoque.Click += new System.EventHandler(this.btnestoque_Click);
            // 
            // btnvendas
            // 
            this.btnvendas.Location = new System.Drawing.Point(50, 122);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(182, 47);
            this.btnvendas.TabIndex = 1;
            this.btnvendas.Text = "Vendas";
            this.btnvendas.UseVisualStyleBackColor = true;
            this.btnvendas.Click += new System.EventHandler(this.btnvendas_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(50, 37);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(182, 47);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnestoque);
            this.groupBox1.Controls.Add(this.btnvendas);
            this.groupBox1.Controls.Add(this.btnclientes);
            this.groupBox1.Location = new System.Drawing.Point(431, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 378);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fornecedores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "menu";
            this.Text = "menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnestoque;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}