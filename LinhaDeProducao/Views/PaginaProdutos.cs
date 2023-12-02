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
    public partial class PaginaProdutos : Form
    {
        public PaginaProdutos()
        {
            InitializeComponent();
            try
            {

                Produtos osProdutos = new Produtos();

                listViewProdutos.Bounds = new Rectangle(new Point(10, 10), new Size(910, 500));
                listViewProdutos.View = View.Details;
                listViewProdutos.LabelEdit = true;
                listViewProdutos.AllowColumnReorder = true;
                listViewProdutos.CheckBoxes = true;
                listViewProdutos.FullRowSelect = true;
                listViewProdutos.GridLines = true;
                listViewProdutos.Sorting = SortOrder.Ascending;

                listViewProdutos.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("ID_EMPRESA", -2, HorizontalAlignment.Center);

                foreach (Produtos produto in osProdutos.GetListaProdutos())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(osProdutos.id.ToString());
                    item.SubItems.Add(osProdutos.nome);
                    item.SubItems.Add(osProdutos.id_empresa.ToString());
                    listViewProdutos.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btRemFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
