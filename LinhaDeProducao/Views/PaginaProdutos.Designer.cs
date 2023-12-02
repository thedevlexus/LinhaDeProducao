namespace LinhaDeProducao.Views
{
    partial class PaginaProdutos
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
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.btRemFuncionario = new System.Windows.Forms.Button();
            this.btCadProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(12, 12);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(993, 555);
            this.listViewProdutos.TabIndex = 4;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btRemFuncionario
            // 
            this.btRemFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRemFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemFuncionario.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btRemFuncionario.FlatAppearance.BorderSize = 0;
            this.btRemFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemFuncionario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRemFuncionario.Location = new System.Drawing.Point(273, 515);
            this.btRemFuncionario.Name = "btRemFuncionario";
            this.btRemFuncionario.Size = new System.Drawing.Size(210, 37);
            this.btRemFuncionario.TabIndex = 7;
            this.btRemFuncionario.Text = "Remover Produto";
            this.btRemFuncionario.UseVisualStyleBackColor = false;
            this.btRemFuncionario.Click += new System.EventHandler(this.btRemFuncionario_Click);
            // 
            // btCadProduto
            // 
            this.btCadProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCadProduto.FlatAppearance.BorderSize = 0;
            this.btCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProduto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadProduto.Location = new System.Drawing.Point(30, 515);
            this.btCadProduto.Name = "btCadProduto";
            this.btCadProduto.Size = new System.Drawing.Size(237, 37);
            this.btCadProduto.TabIndex = 6;
            this.btCadProduto.Text = "Cadastrar Novo Produto";
            this.btCadProduto.UseVisualStyleBackColor = false;
            // 
            // PaginaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 599);
            this.Controls.Add(this.btRemFuncionario);
            this.Controls.Add(this.btCadProduto);
            this.Controls.Add(this.listViewProdutos);
            this.Name = "PaginaProdutos";
            this.Text = "PaginaProdutos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.Button btRemFuncionario;
        private System.Windows.Forms.Button btCadProduto;
    }
}