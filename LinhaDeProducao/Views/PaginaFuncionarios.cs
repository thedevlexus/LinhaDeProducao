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

namespace LinhaDeProducao.Views
{
    public partial class PaginaFuncionarios : Form
    {
        public PaginaFuncionarios()
        {
            InitializeComponent();
            try
            {

                Funcionario funcionarios = new Funcionario();

                listViewFuncionarios.Bounds = new Rectangle(new Point(10, 10), new Size(910, 500));
                listViewFuncionarios.View = View.Details;
                listViewFuncionarios.LabelEdit = true;
                listViewFuncionarios.AllowColumnReorder = true;
                listViewFuncionarios.CheckBoxes = true;
                listViewFuncionarios.FullRowSelect = true;
                listViewFuncionarios.GridLines = true;
                listViewFuncionarios.Sorting = SortOrder.Ascending;

                listViewFuncionarios.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewFuncionarios.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewFuncionarios.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewFuncionarios.Columns.Add("EMAIL", -2, HorizontalAlignment.Left);
                listViewFuncionarios.Columns.Add("NIVEL", -2, HorizontalAlignment.Center);

                foreach (Funcionario funcionario in funcionarios.GetListaFuncionario())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(funcionario.id.ToString());
                    item.SubItems.Add(funcionario.nome);
                    item.SubItems.Add(funcionario.email);
                    item.SubItems.Add(funcionario.GetNivel().ToString());
                    listViewFuncionarios.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCadFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
