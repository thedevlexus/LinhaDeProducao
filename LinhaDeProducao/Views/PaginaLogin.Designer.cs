namespace LinhaDeProducao
{
    partial class PaginaLogin
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.labelDireitosReservados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(27, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(306, 50);
            this.textBoxEmail.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSenha.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(27, 140);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(306, 50);
            this.textBoxSenha.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelLogin.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(142, 29);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 42);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLogar
            // 
            this.buttonLogar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.buttonLogar.FlatAppearance.BorderSize = 0;
            this.buttonLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogar.Location = new System.Drawing.Point(118, 242);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(124, 39);
            this.buttonLogar.TabIndex = 3;
            this.buttonLogar.Text = "ENTRAR";
            this.buttonLogar.UseMnemonic = false;
            this.buttonLogar.UseVisualStyleBackColor = false;
            this.buttonLogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDireitosReservados
            // 
            this.labelDireitosReservados.AutoSize = true;
            this.labelDireitosReservados.Location = new System.Drawing.Point(162, 319);
            this.labelDireitosReservados.Name = "labelDireitosReservados";
            this.labelDireitosReservados.Size = new System.Drawing.Size(184, 13);
            this.labelDireitosReservados.TabIndex = 4;
            this.labelDireitosReservados.Text = "Todos os direitos reservados. © 2023";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deus seja louvado.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Esqueceu sua senha? Se vira.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PaginaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(358, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDireitosReservados);
            this.Controls.Add(this.buttonLogar);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PaginaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogar;
        private System.Windows.Forms.Label labelDireitosReservados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}