namespace LinhaDeProducao
{
    partial class MenuLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btClientes = new System.Windows.Forms.Button();
            this.btFuncionarios = new System.Windows.Forms.Button();
            this.painelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btProdutos = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.painelCabecalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClientes
            // 
            this.btClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btClientes.FlatAppearance.BorderSize = 0;
            this.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClientes.Location = new System.Drawing.Point(12, 6);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(108, 37);
            this.btClientes.TabIndex = 0;
            this.btClientes.Text = "Clientes";
            this.btClientes.UseVisualStyleBackColor = false;
            this.btClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFuncionarios
            // 
            this.btFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btFuncionarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFuncionarios.FlatAppearance.BorderSize = 0;
            this.btFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionarios.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btFuncionarios.Location = new System.Drawing.Point(3, 49);
            this.btFuncionarios.Name = "btFuncionarios";
            this.btFuncionarios.Size = new System.Drawing.Size(127, 37);
            this.btFuncionarios.TabIndex = 1;
            this.btFuncionarios.Text = "Funcionários";
            this.btFuncionarios.UseVisualStyleBackColor = false;
            this.btFuncionarios.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // painelCabecalho
            // 
            this.painelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.painelCabecalho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.painelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelCabecalho.Controls.Add(this.label1);
            this.painelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelCabecalho.ForeColor = System.Drawing.Color.Yellow;
            this.painelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.painelCabecalho.Name = "painelCabecalho";
            this.painelCabecalho.Size = new System.Drawing.Size(1065, 49);
            this.painelCabecalho.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linha de Produção";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btProdutos);
            this.panel1.Controls.Add(this.btFuncionarios);
            this.panel1.Controls.Add(this.btClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 645);
            this.panel1.TabIndex = 4;
            // 
            // btProdutos
            // 
            this.btProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProdutos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btProdutos.FlatAppearance.BorderSize = 0;
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProdutos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProdutos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btProdutos.Location = new System.Drawing.Point(3, 92);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(127, 37);
            this.btProdutos.TabIndex = 2;
            this.btProdutos.Text = "Produtos";
            this.btProdutos.UseVisualStyleBackColor = false;
            this.btProdutos.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Location = new System.Drawing.Point(136, 49);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(929, 645);
            this.panelConteudo.TabIndex = 5;
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1065, 694);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelCabecalho);
            this.Font = new System.Drawing.Font("CountryBlueprint", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuLogin";
            this.ShowIcon = false;
            this.Text = "Linha de Produção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelCabecalho.ResumeLayout(false);
            this.painelCabecalho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btFuncionarios;
        private System.Windows.Forms.Panel painelCabecalho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btProdutos;
    }
}

