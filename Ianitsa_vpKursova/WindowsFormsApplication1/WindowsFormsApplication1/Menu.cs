using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listOfCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomer frm1 = new SearchCustomer();
            //NewCostumers frm1 = new NewCostumers();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer frm =new  NewCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void redactionCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedactionCustomer frm = new RedactionCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSales frm = new SearchSales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void newSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSales frm = new NewSales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void redactionSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedactionSales frm = new RedactionSales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReports frm = new ProductReports();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products frm = new Products();
            frm.MdiParent = this;
            frm.Show();
        }

        private void forProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForProducts frm = new ForProducts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void horizontalOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form aForm in this.MdiChildren)
            {
                if (aForm.IsMdiContainer != true)
                {
                    aForm.Close();
                }
            }
        }

        
    }
}
