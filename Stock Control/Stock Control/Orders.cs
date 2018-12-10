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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            disp_Orders_View();
            DisplayDataVendors();
        }

        SqlDataReader myReader = null;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapt;
        int userid = 1234;
        int vendorid = 2345;

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO TBL_PURCHASE_ORDER (NUM_POID, CHR_notes, NUM_userID, NUM_tax, DT_delivery_date, DT_created_date, CHR_terms, CHR_deliveryAddress, NUM_vendorID, FT_total, NUM_POstatus)" +
                "VALUES (@NUM_POID, @CHR_notes, @NUM_userID, @NUM_tax, @DT_delivery_date, @DT_created_date, @CHR_terms, @CHR_deliveryAddress, @NUM_vendorID, @FT_total, @NUM_POstatus)", conn);


            if (txt_orderID.Text == "")

            {
                MessageBox.Show("Please fill necessary fields");
            }

            else
            {
                cmd.Parameters.AddWithValue("@NUM_POID", txt_orderID.Text);
                
                cmd.Parameters.AddWithValue("@NUM_userID", userid);
                
                cmd.Parameters.AddWithValue("@NUM_vendorID", vendorid);
                


                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Created Successfully");
                ClearData();
            }
            conn.Close();

        }



        private void ClearData()
        {
            txt_orderID.Text = "";
            txt_vendorID.Text = "";
           
        }


        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txt_orderID.Text == "")
            {
                MessageBox.Show("Insert the Order ID to Delete");
            }
            else
            {

                String query = "DELETE from TBL_PO_ITEMS where NUM_POID = '" + txt_orderID.Text + "'" +
                    "DELETE from TBL_PURCHASE_ORDER where NUM_POID = '"+txt_orderID.Text+"'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");

                ClearData();
            }
            conn.Close();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductOrder product_order = new ProductOrder();
            product_order.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

       

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void checkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restock check_order = new Restock();
            check_order.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            disp_Orders_View();
            DisplayDataVendors();
        }

        public void disp_Orders_View()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_PURCHASE_ORDER", conn);
            adapt.Fill(dt1);
            gridviewOrders.DataSource = dt1;

            this.gridviewOrders.DataSource = dt1;

            gridviewOrders.Columns[0].HeaderCell.Value = "Order ID";
            gridviewOrders.Columns[1].HeaderCell.Value = "Notes";
            gridviewOrders.Columns[2].HeaderCell.Value = "User ID";
            gridviewOrders.Columns[3].HeaderCell.Value = "Tax";
            gridviewOrders.Columns[4].HeaderCell.Value = "Delivery Date";
            gridviewOrders.Columns[5].HeaderCell.Value = "Created Date";
            gridviewOrders.Columns[6].HeaderCell.Value = "Terms";
            gridviewOrders.Columns[7].HeaderCell.Value = "Delivery Address";
            gridviewOrders.Columns[8].HeaderCell.Value = "Vendor ID";
            gridviewOrders.Columns[9].HeaderCell.Value = "Total";
            gridviewOrders.Columns[10].HeaderCell.Value = "Status";

            conn.Close();
        }
        private void DisplayDataVendors()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_VENDOR", conn);
            adapt.Fill(dt1);
            gridviewVendors.DataSource = dt1;

            this.gridviewVendors.DefaultCellStyle.ForeColor = Color.Blue;

            gridviewVendors.Columns[0].HeaderCell.Value = "ID";
            gridviewVendors.Columns[1].HeaderCell.Value = "Phone";
            gridviewVendors.Columns[2].HeaderCell.Value = "Address";
            gridviewVendors.Columns[3].HeaderCell.Value = "Company Name";
            gridviewVendors.Columns[4].HeaderCell.Value = "Company Type";
            gridviewVendors.Columns[5].HeaderCell.Value = "Country";
            gridviewVendors.Columns[6].HeaderCell.Value = "City";
            gridviewVendors.Columns[7].HeaderCell.Value = "Title";
            gridviewVendors.Columns[8].HeaderCell.Value = "First Name";
            gridviewVendors.Columns[9].HeaderCell.Value = "Surname";
            gridviewVendors.Columns[10].HeaderCell.Value = "Email";

            conn.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ProductOrder productordermenu = new ProductOrder();
            productordermenu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBox1.seletedI)
        }

        private void gridviewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_orderID.Text = gridviewOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_orderID.Text = gridviewOrders.SelectedCells[0].Value.ToString();
        }

        private void gridViewVendors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_vendorID.Text = gridviewVendors.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_orderID.Text == "")
            {
                MessageBox.Show("Please Enter A Value In Product ID");
                disp_Orders_View();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TBL_PURCHASE_ORDER where NUM_POID = '" + txt_orderID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridviewOrders.DataSource = dt;
                conn.Close();
                ClearData();
            }
        }

        private void btn_searchVendor_Click(object sender, EventArgs e)
        {
            if (txt_vendorID.Text == "")
            {
                MessageBox.Show("Please Enter A Value In Vendor ID");
                DisplayDataVendors();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TBL_VENDOR where NUM_Vendor_ID = '" + txt_vendorID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridviewVendors.DataSource = dt;
                conn.Close();
                ClearData();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewOrder newordermenu = new NewOrder();
            newordermenu.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ProductOrder productordermenu = new ProductOrder();
            productordermenu.Show();
        }
    }
}

