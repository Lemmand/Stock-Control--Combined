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
    }
}
