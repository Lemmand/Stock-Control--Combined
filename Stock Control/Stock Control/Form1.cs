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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_password.Text == "")
            {
                MainMenu mainmenu = new MainMenu();
                mainmenu.Show();
                closeform();
            }
        }

        public void closeform()
        {
            this.Hide();
        }
    }
}
