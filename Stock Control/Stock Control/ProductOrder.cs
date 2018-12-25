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

        int order_id = -1;
        int vendor_id = -1;

        public ProductOrder(int orderid, int vendorid)
        {
            vendor_id = vendorid;
            order_id = orderid;
            InitializeComponent();
            disp_Orders_View();
            DisplayData();
            dgvProducts.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(DgvProducts_RowHeaderMouseClick);

        }


        int ID = 0;
        SqlDataAdapter adapt;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");



        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SET IDENTITY_INSERT TBL_PO_ITEMS ON INSERT INTO TBL_PO_ITEMS (NUM_POID, NUM_itemID, NUM_quantity)" +
                "VALUES(@NUM_POID, @NUM_itemID, @NUM_quantity)", conn);

            /*cmd = new SqlCommand("UPDATE TBL_PRODUCT_CATEGORIES set " +
                       "CHR_Category_name = '" + txtCategoryName.Text + "', " +
                       "CHR_Description = '" + txtCategoryDescription.Text + "' WHERE NUM_Category_id = " + txt_orderID.Text + "", conn);

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();*/

            if (txt_itemID.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }

            else
            {
                cmd.Parameters.AddWithValue("@NUM_POID", order_id);
                cmd.Parameters.AddWithValue("@NUM_itemID", txt_itemID.Text);
                cmd.Parameters.AddWithValue("@NUM_quantity", txt_quantity.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Item added Successfully");

                ClearData();


            }
            conn.Close();
            disp_Orders_View();
        }

        private void ClearData()
        {
            txt_itemID.Text = "";
            txt_quantity.Text = "";
            txt_search_product_id.Text = "";
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            conn.Open();


            String query = "DELETE FROM TBL_PO_ITEMS WHERE NUM_POID = " + order_id;

            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Deleted Successfully");

            ClearData();

            conn.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            disp_Orders_View();
            DisplayData();
        }
        public void disp_Orders_View()
        {
           
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TBL_PO_ITEMS WHERE NUM_POID =" + order_id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProductOrder.DataSource = dt;
            conn.Close();
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select NUM_itemID,CHR_item_name,FT_price,CHR_info, NUM_manufacturer,NUM_Quantity, CHR_Product_saleflag, TBL_VAT_CATEGORIES.NUM_Vat_rate, NUM_Product_category, NUM_Barcode from TBL_SC_ITEMS FULL JOIN TBL_VAT_CATEGORIES ON TBL_SC_ITEMS.NUM_Vat_category=TBL_VAT_CATEGORIES.NUM_Vat_id WHERE NUM_manufacturer =" + vendor_id, conn);
            adapt.Fill(dt1);
            dgvProducts.DataSource = dt1;

            this.dgvProducts.DefaultCellStyle.ForeColor = Color.Blue;

            dgvProducts.Columns[0].HeaderCell.Value = "ID";
            dgvProducts.Columns[1].HeaderCell.Value = "Name";
            dgvProducts.Columns[2].HeaderCell.Value = "Price";
            dgvProducts.Columns[3].HeaderCell.Value = "Info";
            dgvProducts.Columns[4].HeaderCell.Value = "Vendor";
            dgvProducts.Columns[5].HeaderCell.Value = "Quantity";
            dgvProducts.Columns[6].HeaderCell.Value = "Sale Flag";
            dgvProducts.Columns[7].HeaderCell.Value = "VAT";
            dgvProducts.Columns[8].HeaderCell.Value = "Category";
            dgvProducts.Columns[9].HeaderCell.Value = "Barcode";

            conn.Close();
        }

        private void DgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_itemID.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();

        }


        private void ProductOrder_Load(object sender, EventArgs e)
        {
            disp_Orders_View();
            DisplayData();

        }

        private void txt_OrderIDSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_product_id_Click(object sender, EventArgs e)
        {      
            if (txt_search_product_id.Text == "")
            {
                MessageBox.Show("Please Enter A Value In Product ID");
                DisplayData();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                int textisnum = 0;
                if (txt_search_product_id.Text.All(Char.IsLetter) || txt_search_product_id.Text.Contains(" "))
                {
                    textisnum = 0;
                }
                else
                {
                    textisnum = Int32.Parse(txt_search_product_id.Text);
                }

                cmd.CommandText = "SELECT * FROM TBL_SC_ITEMS WHERE NUM_itemID = " + textisnum + " OR NUM_Barcode = " + textisnum + " OR CHR_item_name = '" + txt_search_product_id.Text.ToString() + "' AND NUM_manufacturer =" + vendor_id;

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvProducts.DataSource = dt;
                conn.Close();
                ClearData();
                if (dgvProducts.RowCount == 0)
                {
                    MessageBox.Show("No Results Found");
                    DisplayData();
                }
            }


        }
    }
}

