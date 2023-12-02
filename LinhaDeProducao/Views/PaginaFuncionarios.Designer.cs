namespace LinhaDeProducao.Views
{
    partial class PaginaFuncionarios
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
            this.listViewFuncionarios = new System.Windows.Forms.ListView();
            this.btRemFuncionario = new System.Windows.Forms.Button();
            this.btCadFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFuncionarios
            // 
            this.listViewFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.listViewFuncionarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFuncionarios.HideSelection = false;
            this.listViewFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.listViewFuncionarios.Name = "listViewFuncionarios";
            this.listViewFuncionarios.Size = new System.Drawing.Size(993, 555);
            this.listViewFuncionarios.TabIndex = 0;
            this.listViewFuncionarios.UseCompatibleStateImageBehavior = false;
            this.listViewFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.btRemFuncionario.TabIndex = 5;
            this.btRemFuncionario.Text = "Remover Funcionario";
            this.btRemFuncionario.UseVisualStyleBackColor = false;
            // 
            // btCadFuncionario
            // 
            this.btCadFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCadFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadFuncionario.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCadFuncionario.FlatAppearance.BorderSize = 0;
            this.btCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadFuncionario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadFuncionario.Location = new System.Drawing.Point(30, 515);
            this.btCadFuncionario.Name = "btCadFuncionario";
            this.btCadFuncionario.Size = new System.Drawing.Size(237, 37);
            this.btCadFuncionario.TabIndex = 4;
            this.btCadFuncionario.Text = "Cadastrar Novo Funcionario";
            this.btCadFuncionario.UseVisualStyleBackColor = false;
            this.btCadFuncionario.Click += new System.EventHandler(this.btCadFuncionario_Click);
            // 
            // PaginaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 599);
            this.Controls.Add(this.btRemFuncionario);
            this.Controls.Add(this.btCadFuncionario);
            this.Controls.Add(this.listViewFuncionarios);
            this.Name = "PaginaFuncionarios";
            this.Text = "PaginaFuncionarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFuncionarios;
        private System.Windows.Forms.Button btRemFuncionario;
        private System.Windows.Forms.Button btCadFuncionario;
    }
}