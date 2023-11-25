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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                Insumos insumos = new Insumos();


                insumos.id_produto = 8;
                insumos.nome = "1 Etapa - Lavar";
                insumos.quantidade = 9;
                insumos.unidade = "1";

                insumos.Insert();  

                MessageBox.Show("Add");
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
