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


        }

        SqlDataReader myReader = null;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapt;
        int userid = 1234;
        int vendorid = 2345;

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO TBL_PURCHASE_ORDER (NUM_POID, CHR_notes, NUM_userID, NUM_tax, DT_delivery_date, DT_created_date, CHR_terms, CHR_deliveryAddress, NUM_vendorID, FT_total, NUM_POstatus)" +
                "VALUES (@NUM_POID, @CHR_notes, @NUM_userID, @NUM_tax, @DT_delivery_date, @DT_created_date, @CHR_terms, @CHR_deliveryAddress, @NUM_vendorID, @FT_total, @NUM_POstatus)", conn);


            if (txt_orderID.Text == "" || txt_deliveryDate.Text == "" || txt_createdDate.Text == "")

            {
                MessageBox.Show("Please fill necessary fields");
            }

            else
            {
                cmd.Parameters.AddWithValue("@NUM_POID", txt_orderID.Text);
                cmd.Parameters.AddWithValue("@CHR_notes", txt_orderNotes.Text);
                cmd.Parameters.AddWithValue("@NUM_userID", userid);
                cmd.Parameters.AddWithValue("@NUM_tax", txt_tax.Text);
                cmd.Parameters.AddWithValue("@DT_delivery_date", txt_deliveryDate.Text);
                cmd.Parameters.AddWithValue("@DT_created_date", txt_createdDate.Text);
                cmd.Parameters.AddWithValue("@CHR_terms", txt_terms.Text);
                cmd.Parameters.AddWithValue("@CHR_deliveryAddress", txt_deliveryAddress.Text);
                cmd.Parameters.AddWithValue("@NUM_vendorID", vendorid);
                cmd.Parameters.AddWithValue("@FT_total", txt_total.Text);
                cmd.Parameters.AddWithValue("@NUM_POstatus", txt_orderStatus.Text);


                /*String query = "insert into TBL_PURCHASE_ORDER values" +
                    "(NUM_POID = , '" + txt_orderID.Text + "', " +
                    "CHR_notes = '" + txt_orderNotes.Text + "', " +
                    "NUM_useriD = '" + txt_userID.Text + "', " +
                    "NUM_tax = '" + txt_tax.Text + "', " +
                    "DT_delivery_date = '" + txt_deliveryDate.Text + "', " +
                    "DT_created_date = '" + txt_createdDate.Text + "', " +
                    "CHR_terms = '" + txt_terms.Text + "'," +
                    "CHR_deliveryAddress = '" + txt_deliveryAddress.Text + "', " +
                    "NUM_vendorID = '" + txt_vendorID.Text + "', " +
                    "FT_total = '" + txt_total.Text + "', " +
                    "NUM_POstatus = '" + txt_orderStatus.Text + "')" ;
   

                
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                */

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Created Successfully");
                ClearData();
            }
            conn.Close();

        }



        private void ClearData()
        {
            txt_orderID.Text = "";
            txt_orderNotes.Text = "";
            txt_userID.Text = "";
            txt_tax.Text = "";
            txt_deliveryDate.Text = "";
            txt_createdDate.Text = "";
            txt_terms.Text = "";
            txt_deliveryAddress.Text = "";
            txt_vendorID.Text = "";
            txt_total.Text = "";
            txt_orderStatus.Text = "";
        }

        private void btn_editOrder_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE TBL_PURCHASE_ORDER set " +
                    "CHR_notes = '" + txt_orderNotes.Text + "', " +
                    "NUM_userID = '" + userid + "', " +
                    "NUM_tax = '" + txt_tax.Text + "'," +
                    "DT_delivery_date = '" + txt_deliveryDate.Text + "', " +
                    "DT_created_date = '" + txt_createdDate.Text + "', " +
                    "CHR_terms = '" + txt_terms.Text + "'," +
                    "CHR_deliveryAddress = '" + txt_deliveryAddress.Text + "', " +
                    "NUM_vendorID = '" + vendorid + "', " +
                    "FT_total = '" + txt_total.Text + "'," +
                    "NUM_POstatus = '" + txt_orderStatus.Text + "' " +
                    "WHERE NUM_POID = '" + txt_orderID.Text + "'", conn);

            conn.Open();
            if (txt_orderID.Text == "")
            {
                MessageBox.Show("Insert the Order ID to Update");
            }
            else
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Entry updated Successfully");
                ClearData();
            }
            conn.Close();
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

                String query = "DELETE from TBL_PURCHASE_ORDER where NUM_POID = '" + txt_orderID.Text + "'";
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

        private void btn_viewOrder_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM TBL_PURCHASE_ORDER WHERE NUM_POID = '" + txt_orderID.Text + "'", conn);
            conn.Open();
            myReader = cmdSelect.ExecuteReader();



            while (myReader.Read())
            {

                txt_orderNotes.Text = (myReader["CHR_notes"].ToString());
                txt_userID.Text = (myReader["NUM_userID"].ToString());
                txt_tax.Text = (myReader["NUM_tax"].ToString());
                txt_deliveryDate.Text = (myReader["DT_delivery_date"].ToString());
                txt_createdDate.Text = (myReader["DT_created_date"].ToString());
                txt_terms.Text = (myReader["CHR_terms"].ToString());
                txt_deliveryAddress.Text = (myReader["CHR_deliveryAddress"].ToString());
                txt_vendorID.Text = (myReader["NUM_vendorID"].ToString());
                txt_total.Text = (myReader["FT_total"].ToString());
                txt_orderStatus.Text = (myReader["NUM_POstatus"].ToString());
            }
            conn.Close();
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
    }
}

