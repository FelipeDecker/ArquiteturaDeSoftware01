using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelipeFormsBanco
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'univilleDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.univilleDataSet.clientes);

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.univilleDataSet);

        }

        private void clientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Update(this.univilleDataSet.clientes);
        }
    }
}
