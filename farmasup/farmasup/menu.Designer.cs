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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btnestoque = new System.Windows.Forms.Button();
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnestoque
            // 
            this.btnestoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnestoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnestoque.Location = new System.Drawing.Point(56, 247);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(182, 47);
            this.btnestoque.TabIndex = 0;
            this.btnestoque.Text = "Estoque";
            this.btnestoque.UseVisualStyleBackColor = false;
            this.btnestoque.Click += new System.EventHandler(this.btnestoque_Click);
            // 
            // btnvendas
            // 
            this.btnvendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnvendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvendas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnvendas.Location = new System.Drawing.Point(56, 163);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(182, 47);
            this.btnvendas.TabIndex = 1;
            this.btnvendas.Text = "Vendas";
            this.btnvendas.UseVisualStyleBackColor = false;
            this.btnvendas.Click += new System.EventHandler(this.btnvendas_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclientes.Location = new System.Drawing.Point(56, 78);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(182, 47);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.groupBox1.Controls.Add(this.btnestoque);
            this.groupBox1.Controls.Add(this.btnvendas);
            this.groupBox1.Controls.Add(this.btnclientes);
            this.groupBox1.Location = new System.Drawing.Point(448, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 378);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnestoque;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}