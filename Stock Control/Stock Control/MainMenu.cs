using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Control
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
        private void searchStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.MdiParent = this;
            search.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AddItem addItem = new AddItem();
                addItem.MdiParent = this;
                addItem.Show();
            
        }

        private void interactiveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractiveReport interactive_report = new InteractiveReport();
            interactive_report.MdiParent = this;
            interactive_report.Show();
        }

        private void MainMenu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vendorMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVendor vendormenu = new AddVendor();
            vendormenu.MdiParent = this;
            vendormenu.Show();
        }

        private void customerMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customermenu = new Customer();
            customermenu.MdiParent = this;
            customermenu.Show();
        }

        private void restockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restock restockmenu = new Restock();
            restockmenu.MdiParent = this;
            restockmenu.Show();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Orders ordermenu = new Orders();
            ordermenu.MdiParent = this;
            ordermenu.Show();*/
        }

        private void productCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCategories productcatmenu = new ProductCategories();
            productcatmenu.MdiParent = this;
            productcatmenu.Show();
        }

        private void productOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VatCategories vatCat = new VatCategories();
            vatCat.MdiParent = this;
            vatCat.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.MdiParent = this;
            addItem.Show();
        }

        private void productSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.MdiParent = this;
            search.Show();
        }

        private void productCategoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductCategories productcatmenu = new ProductCategories();
            productcatmenu.MdiParent = this;
            productcatmenu.Show();
        }

        private void orderViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders ordermenu = new Orders();
            ordermenu.MdiParent = this;
            ordermenu.Show();
        }

        private void createOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
            NewOrder newordermenu = new NewOrder();
            newordermenu.MdiParent = this;
            newordermenu.Show();
        }

        private void fillCreatedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductOrder FillOrder = new ProductOrder(0,0);
            FillOrder.MdiParent = this;
            FillOrder.Show();
        }
    }
}
