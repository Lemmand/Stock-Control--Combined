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
    public partial class NewOrder : Form
    {
        int quantity = 0;
        int count = 0;
        double sum;

        public NewOrder()
        {
            InitializeComponent();
            DisplayDataVendors();
            DisplayDataProducts();
            dt2 = ((DataTable)dgv_products.DataSource).Clone();
            dgv_prod_add.Hide();
            dt2.Columns.Add(new DataColumn("Quantity", typeof(int)));

        }

        SqlCommand cmd,cmd2,cmd3;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapt,adapt2,adapt3;
        DataTable dt1, dt2,dtpo;
        int userid = 1234;
        int vendorid = 2345;

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO TBL_PURCHASE_ORDER (CHR_notes, DT_created_date, CHR_deliveryAddress, NUM_vendorID, FT_total, CHR_POstatus)" +
                "VALUES (@CHR_notes, @DT_created_date, @CHR_deliveryAddress, @NUM_vendorID, @FT_total, @CHR_POstatus)", conn);



           


                cmd.Parameters.AddWithValue("@CHR_notes", txt_orderNotes.Text);
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                
                cmd.Parameters.AddWithValue("@DT_created_date", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@CHR_deliveryAddress", txt_deliveryAddress.Text);
                cmd.Parameters.AddWithValue("@NUM_vendorID", txt_vendorID.Text);
                cmd.Parameters.AddWithValue("@FT_total", sum);
                cmd.Parameters.AddWithValue("@CHR_POstatus", "Created");



                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                ClearData();
            


            cmd3 = new SqlCommand("SELECT TOP 1 * FROM TBL_PURCHASE_ORDER ORDER BY NUM_POID DESC", conn);
            adapt3 = new SqlDataAdapter(cmd3);
            dtpo = new DataTable();
            adapt3.Fill(dtpo);
            int number = dtpo.Rows[0].Field<int>(0);


          
            cmd2 = new SqlCommand("SET IDENTITY_INSERT TBL_PO_ITEMS ON INSERT INTO TBL_PO_ITEMS (NUM_POID, NUM_itemID, NUM_quantity)VALUES(@NUM_POID, @NUM_itemID, @NUM_quantity)", conn);
            cmd2.Parameters.Clear();

            foreach (DataGridViewRow row in dgv_prod_add.Rows)
            {
                try { 
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@NUM_POID", number);
                    cmd2.Parameters.AddWithValue("@NUM_itemID", row.Cells["NUM_itemID"].Value);
                    cmd2.Parameters.AddWithValue("@NUM_quantity", row.Cells["Quantity"].Value);
                    cmd2.ExecuteNonQuery();
                }catch
                {
                    MessageBox.Show("An error has occured");
                }
            }
                conn.Close();

        }

        private void ClearData()
        {
            txt_orderNotes.Text = "";
            txt_deliveryAddress.Text = "";
            txt_vendorID.Text = "";
        }


        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DisplayDataVendors()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_VENDOR", conn);
            adapt.Fill(dt1);
            dgv_suppliers.DataSource = dt1;

            this.dgv_suppliers.DefaultCellStyle.ForeColor = Color.Blue;

            dgv_suppliers.Columns[0].HeaderCell.Value = "ID";
            dgv_suppliers.Columns[1].HeaderCell.Value = "Phone";
            dgv_suppliers.Columns[2].HeaderCell.Value = "Address";
            dgv_suppliers.Columns[3].HeaderCell.Value = "Company Name";
            dgv_suppliers.Columns[4].HeaderCell.Value = "Company Type";
            dgv_suppliers.Columns[5].HeaderCell.Value = "Country";
            dgv_suppliers.Columns[6].HeaderCell.Value = "City";
            dgv_suppliers.Columns[7].HeaderCell.Value = "Title";
            dgv_suppliers.Columns[8].HeaderCell.Value = "First Name";
            dgv_suppliers.Columns[9].HeaderCell.Value = "Surname";
            dgv_suppliers.Columns[10].HeaderCell.Value = "Email";

            conn.Close();
        }

        private void dgv_suppliers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vendorid = Convert.ToInt32(dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_vendorID.Text = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString();

            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select NUM_itemID,CHR_item_name,FT_price,CHR_info, NUM_manufacturer,NUM_Quantity, CHR_Product_saleflag,TBL_VAT_CATEGORIES.NUM_Vat_rate," +
                " NUM_Product_category, NUM_Barcode from TBL_SC_ITEMS FULL JOIN TBL_VAT_CATEGORIES ON TBL_SC_ITEMS.NUM_Vat_category=TBL_VAT_CATEGORIES.NUM_Vat_id WHERE NUM_manufacturer =" + vendorid, conn);

            adapt.Fill(dt1);
            dgv_products.DataSource = dt1;
            conn.Close();

        }

        public void DisplayDataProducts()
        {

            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select NUM_itemID,CHR_item_name,FT_price,CHR_info, NUM_manufacturer,NUM_Quantity, CHR_Product_saleflag,TBL_VAT_CATEGORIES.NUM_Vat_rate, NUM_Product_category, NUM_Barcode from TBL_SC_ITEMS FULL JOIN TBL_VAT_CATEGORIES ON TBL_SC_ITEMS.NUM_Vat_category=TBL_VAT_CATEGORIES.NUM_Vat_id", conn);
            adapt.Fill(dt1);
            dgv_products.DataSource = dt1;

            this.dgv_products.DefaultCellStyle.ForeColor = Color.Blue;

            dgv_products.Columns[0].HeaderCell.Value = "ID";
            dgv_products.Columns[1].HeaderCell.Value = "Name";
            dgv_products.Columns[2].HeaderCell.Value = "Price";
            dgv_products.Columns[3].HeaderCell.Value = "Info";
            dgv_products.Columns[4].HeaderCell.Value = "Vendor";
            dgv_products.Columns[5].HeaderCell.Value = "Quantity";
            dgv_products.Columns[6].HeaderCell.Value = "Sale Flag";
            dgv_products.Columns[7].HeaderCell.Value = "VAT";
            dgv_products.Columns[8].HeaderCell.Value = "Category";
            dgv_products.Columns[9].HeaderCell.Value = "Barcode";

            conn.Close();
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            dgv_suppliers.Hide();
            dgv_prod_add.Show();

            if (txt_quantity.Text == "")
            {
                MessageBox.Show("Please Enter Product Quantity First");
            }
            else
            {
                quantity = Int32.Parse(txt_quantity.Text);

                conn.Open();
                foreach (DataGridViewRow row in dgv_products.SelectedRows)
                {
                    dt2.ImportRow(((DataTable)dgv_products.DataSource).Rows[row.Index]);
                }

                dt2.AcceptChanges();
                dgv_prod_add.Show();
                dgv_prod_add.DataSource = dt2;


                dgv_prod_add.Rows[count].Cells["Quantity"].Value = quantity;
                count++;
                
                conn.Close();

                sum = 0;
                for (int i = 0; i < dgv_prod_add.Rows.Count; ++i)
                {
                    sum += (Convert.ToInt32(dgv_prod_add.Rows[i].Cells[2].Value) * Convert.ToInt32(dgv_prod_add.Rows[i].Cells[10].Value));
                }
                txt_total.Text = sum.ToString();
                quantity = 0;
                txt_quantity.Text = "";
            }
        }

        private void dgv_prod_add_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }



    }
}
