namespace LinhaDeProducao.Views
{
    partial class PaginaClientes
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
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.btCadCliente = new System.Windows.Forms.Button();
            this.btRemCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewClientes
            // 
            this.listViewClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.listViewClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(12, 12);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(993, 555);
            this.listViewClientes.TabIndex = 1;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.SelectedIndexChanged += new System.EventHandler(this.listViewFuncionario_SelectedIndexChanged);
            // 
            // btCadCliente
            // 
            this.btCadCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCadCliente.FlatAppearance.BorderSize = 0;
            this.btCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadCliente.Location = new System.Drawing.Point(30, 515);
            this.btCadCliente.Name = "btCadCliente";
            this.btCadCliente.Size = new System.Drawing.Size(210, 37);
            this.btCadCliente.TabIndex = 2;
            this.btCadCliente.Text = "Cadastrar Novo Cliente";
            this.btCadCliente.UseVisualStyleBackColor = false;
            this.btCadCliente.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btRemCliente
            // 
            this.btRemCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRemCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btRemCliente.FlatAppearance.BorderSize = 0;
            this.btRemCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRemCliente.Location = new System.Drawing.Point(246, 515);
            this.btRemCliente.Name = "btRemCliente";
            this.btRemCliente.Size = new System.Drawing.Size(210, 37);
            this.btRemCliente.TabIndex = 3;
            this.btRemCliente.Text = "Remover Cliente";
            this.btRemCliente.UseVisualStyleBackColor = false;
            // 
            // PaginaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 604);
            this.Controls.Add(this.btRemCliente);
            this.Controls.Add(this.btCadCliente);
            this.Controls.Add(this.listViewClientes);
            this.Name = "PaginaClientes";
            this.Text = "PaginaClientes";
            this.Load += new System.EventHandler(this.PaginaClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.Button btCadCliente;
        private System.Windows.Forms.Button btRemCliente;
    }
}