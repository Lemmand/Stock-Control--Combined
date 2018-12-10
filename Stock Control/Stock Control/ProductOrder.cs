using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Control
{
    public partial class ProductOrder : Form
    {
        public ProductOrder()
        {
            InitializeComponent();
            disp_Orders_View();

        }

        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JOBDLMB\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO TBL_PO_ITEMS (NUM_POID, NUM_itemID, NUM_quantity)" +
                "VALUES(@NUM_POID, @NUM_itemID, @NUM_quantity)", conn);

            if (txt_orderID.Text == "" || txt_itemID.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }

            else
            {
                cmd.Parameters.AddWithValue("@NUM_POID", txt_orderID.Text);
                cmd.Parameters.AddWithValue("@NUM_itemID", txt_itemID.Text);
                cmd.Parameters.AddWithValue("@NUM_quantity", txt_quantity.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Item added Successfully");

                ClearData();
            }
            conn.Close();
        }

        private void ClearData()
        {
            txt_orderID.Text = "";
            txt_itemID.Text = "";
            txt_quantity.Text = "";

        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txt_orderID.Text == "")
            {
                MessageBox.Show("Enter Order ID to proceed");
            }
            else if (txt_itemID.Text == "")
            {
                MessageBox.Show("Enter Product ID to proceed");
            }

            else
            {
                String query = "DELETE FROM TBL_PO_ITEMS WHERE NUM_POID = '" + txt_orderID.Text + "'";

                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");

                ClearData();
            }
            conn.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            disp_Orders_View();
        }
        public void disp_Orders_View()
        {

            SqlCommand cmd = new SqlCommand("select * from TBL_PO_ITEMS WHERE NUM_POID = '" + txt_orderID.Text + "'", conn);

            conn.Open();

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSuppliers.DataSource = dt;
            conn.Close();
        }
    }
}
