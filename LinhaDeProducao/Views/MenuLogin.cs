using LinhaDeProducao.Views;
using Listas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinhaDeProducao
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();

   
        }

        public void AbrirForm<Forms>() where Forms : Form, new () 
        {
            Form formulario;

            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                formulario.FormBorderStyle = FormBorderStyle.None;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;

                formulario.Show();
                formulario.BringToFront();
            }
            else 
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                formulario.BringToFront();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AbrirForm<PaginaClientes>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirForm<PaginaFuncionarios>();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProdutos>();
        }
    }
}
