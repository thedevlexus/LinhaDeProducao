using Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaDeProducao
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;

            Funcionario funcionarios = new Funcionario();

            funcionarios.email = email;
            funcionarios.SetSenha(senha);

            funcionarios.GetFuncionarioEmailESenha();

            if (funcionarios.logado)
            {
                this.Hide();
                MenuLogin menuLogin = new MenuLogin();
                menuLogin.Show();
            }
            else {
                throw new Exception("Erro ao realizar Login.");
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
