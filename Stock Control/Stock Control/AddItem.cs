using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Stock_Control
{
    public partial class AddItem : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataReader myReader = null;
        
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int supplier_ID, vat_category_ID, prod_category_ID;
        float price_of_product = 0;



        //naming of datagridviews
     


        public AddItem()
        {
            InitializeComponent();
            DisplayDataVendors();
            DisplayDataProductCat();
            DisplayDataVat();
            dgv_suppliers.Hide();
            dgv_prod_cat.Hide();
            dgv_vat_cat.Hide();
            DisplayData();
        }

        private void DisplayDataVendors()
        {
            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_VENDOR", con);
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

            con.Close();
        }


        private void DisplayDataVat()
        {
            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_VAT_CATEGORIES", con);
            adapt.Fill(dt2);
            dgv_vat_cat.DataSource = dt2;

            this.dgv_vat_cat.DefaultCellStyle.ForeColor = Color.Blue;

            dgv_vat_cat.Columns[0].HeaderCell.Value = "ID";
            dgv_vat_cat.Columns[1].HeaderCell.Value = "VAT Rate";
            dgv_vat_cat.Columns[2].HeaderCell.Value = "Description";

            con.Close();
        }


        private void DisplayDataProductCat()
        {
            con.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_PRODUCT_CATEGORIES", con);
            adapt.Fill(dt3);
            dgv_prod_cat.DataSource = dt3;

            this.dgv_prod_cat.DefaultCellStyle.ForeColor = Color.Blue;

            dgv_prod_cat.Columns[0].HeaderCell.Value = "ID";
            dgv_prod_cat.Columns[1].HeaderCell.Value = "Category Name";
            dgv_prod_cat.Columns[2].HeaderCell.Value = "Description";

            con.Close();
        }
 
        private void dgv_suppliers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplier_ID = Convert.ToInt32(dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_supplier.Text = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString();                  
        }

        private void dgv_vat_cat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vat_category_ID = Convert.ToInt32(dgv_vat_cat.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_vat_category.Text = dgv_vat_cat.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void dgv_prod_cat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            prod_category_ID = Convert.ToInt32(dgv_prod_cat.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_product_category.Text = dgv_prod_cat.Rows[e.RowIndex].Cells[1].Value.ToString();

        }


        private void btn_show_suppliers_Click(object sender, EventArgs e)
        {
            dgv_vat_cat.Hide();
            dgv_prod_cat.Hide();
            dgv_suppliers.Show();
            
        }

        private void btn_confirm_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO TBL_SC_ITEMS (CHR_item_name, FT_price, NUM_manufacturer, NUM_Vat_category , NUM_Quantity, CHR_Product_saleflag, NUM_Product_category, NUM_Barcode, CHR_info) " +
                "VALUES (@CHR_item_name, @FT_price, @NUM_manufacturer, @NUM_Vat_category , @NUM_Quantity, @CHR_Product_saleflag, @NUM_Product_category, @NUM_Barcode, @CHR_info)", con);

            if (txt_name.Text == "")
            {
                MessageBox.Show("Please Enter A Name");
            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else if (txt_price.Text == "")
            {
                MessageBox.Show("Please Enter a Price");
            }
            else if (supplier_ID == -1)
            {
                MessageBox.Show("Please Enter a Manufacturer");
            }
            else if (vat_category_ID == -1)
            {
                MessageBox.Show("Please Enter a VAT Category");
            }
            else if (prod_category_ID == -1)
            {
                MessageBox.Show("Please Enter a Product Category");
            }
            else if (cb_saleflag.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Sale Flag");

            }
            else
            {
                cmd.Parameters.AddWithValue("@CHR_item_name", txt_name.Text);
                cmd.Parameters.AddWithValue("@NUM_Quantity", txt_quantity.Text);
                cmd.Parameters.AddWithValue("@NUM_Vat_category", vat_category_ID);
                cmd.Parameters.AddWithValue("@NUM_Product_category", prod_category_ID);
                cmd.Parameters.AddWithValue("@FT_price", txt_price.Text);
                cmd.Parameters.AddWithValue("@NUM_manufacturer", supplier_ID);
                cmd.Parameters.AddWithValue("@NUM_Barcode", txt_barcode.Text);
                cmd.Parameters.AddWithValue("@CHR_info", txt_product_description.Text);

                if (cb_saleflag.SelectedIndex == 0)
                {
                    cmd.Parameters.AddWithValue("@CHR_Product_saleflag", "Buy");
                }
                else if (cb_saleflag.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@CHR_Product_saleflag", "Sell");
                }
                else if (cb_saleflag.SelectedIndex == 2)
                {
                    cmd.Parameters.AddWithValue("@CHR_Product_saleflag", "Buy&Sell");
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                ClearData();
                DisplayData();
            }
            con.Close();                      
        }

        private void ClearData()
        {
            txt_name.Text = "";
            txt_quantity.Text = "";
            txt_price.Text = "";
            txt_barcode.Text = "";
            txt_product_category.Text = "";
            txt_vat_category.Text = "";
            txt_supplier.Text = "";
            cb_saleflag.Text = "";

            supplier_ID = -1;
            prod_category_ID = -1;
            vat_category_ID = -1;
            //cb_saleflag.SelectedIndex = -1;
            txt_vat_category.Text = "";
            txt_supplier.Text = "";
            txt_product_category.Text = "";

            
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_prod_idd.Text == "")
            {
                MessageBox.Show("Please Enter A Product Category ID above the Search button");
            }

            else
            {
                
                //Displays the searched id attributes to textboxes
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM TBL_SC_ITEMS WHERE NUM_itemID = '" + txt_prod_idd.Text + "'", con);

                con.Open();

                myReader = cmdSelect.ExecuteReader();

                while (myReader.Read())
                {

                    txt_name.Text = (myReader["CHR_item_name"].ToString());
                    txt_quantity.Text = (myReader["NUM_Quantity"].ToString());
                    txt_price.Text = (myReader["FT_price"].ToString());
                    cb_saleflag.Text = (myReader["CHR_Product_saleflag"].ToString());
                    txt_barcode.Text = (myReader["NUM_Barcode"].ToString());
                    txt_product_category.Text = (myReader["NUM_Product_category"].ToString());
                    txt_vat_category.Text = (myReader["NUM_Vat_category"].ToString());
                    txt_supplier.Text = (myReader["NUM_manufacturer"].ToString());

                }

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_prod_idd.Text == "")
            {
                MessageBox.Show("Please Select A Product to Update");
            }
            else if (txt_name.Text == "")
            {
                MessageBox.Show("Please Enter A Name");
            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else if (txt_price.Text == "")
            {
                MessageBox.Show("Please Enter a Price");
            }
            else if (supplier_ID == -1)
            {
                MessageBox.Show("Please Enter a Manufacturer");
            }
            else if (vat_category_ID == -1)
            {
                MessageBox.Show("Please Enter a VAT Category");
            }
            else if (prod_category_ID == -1)
            {
                MessageBox.Show("Please Enter a Product Category");
            }
            else if (cb_saleflag.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Sale Flag");

            }
            else
            {
                //try
                //{


                    cmd = new SqlCommand("UPDATE TBL_SC_ITEMS set " +
                   "CHR_item_name = '" + txt_name.Text + "', " +
                   "FT_price = " + txt_price.Text + " , " +
                   "CHR_Product_saleflag = '" + cb_saleflag.Text + "' , " +
                   "NUM_Barcode = " + txt_barcode.Text + " , " +
                   "NUM_Product_category = " + prod_category_ID + " , " +
                   "NUM_Vat_category = " + vat_category_ID + " , " +
                   "NUM_manufacturer = " + supplier_ID + " WHERE NUM_itemID = " + txt_prod_idd.Text, con);


                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product Category Entry Updated Successfully");
                    ClearData();
                    DisplayData();
                //}

                //catch (Exception)
                //{
                //    MessageBox.Show("Error occured.");
                //}
            }
        }
            

        private void btn_show_vat_Click(object sender, EventArgs e)
        {          
            dgv_suppliers.Hide();
            dgv_prod_cat.Hide();
            dgv_vat_cat.Show();
        }

        private void btn_shw_prod_cat_Click(object sender, EventArgs e)
        {
            dgv_vat_cat.Hide();
            dgv_suppliers.Hide();
            dgv_prod_cat.Show();
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_prod_idd.Text = dgv_products.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_price.Text = dgv_products.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_product_description.Text = dgv_products.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_supplier.Text = dgv_products.Rows[e.RowIndex].Cells[4].Value.ToString();
            supplier_ID = Int32.Parse(txt_supplier.Text);
            txt_quantity.Text = dgv_products.Rows[e.RowIndex].Cells[5].Value.ToString();
            cb_saleflag.Text = dgv_products.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_vat_category.Text = dgv_products.Rows[e.RowIndex].Cells[7].Value.ToString();
            vat_category_ID = Int32.Parse(txt_vat_category.Text);
            txt_product_category.Text = dgv_products.Rows[e.RowIndex].Cells[8].Value.ToString();
            prod_category_ID = Int32.Parse(txt_product_category.Text);
            txt_barcode.Text = dgv_products.Rows[e.RowIndex].Cells[9].Value.ToString();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {        
                if (txt_prod_idd.Text == "")
                {
                    MessageBox.Show("Please Select A Product");
                    DisplayData();
                }
                else
                {
                    con.Open();
                    String query = "DELETE FROM TBL_SC_ITEMS WHERE NUM_itemID='" + txt_prod_id.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted Successfully");
                    DisplayData();
                    ClearData();
                }
            
        }

        public void DisplayData()
        {

            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select NUM_itemID,CHR_item_name,FT_price,CHR_info, NUM_manufacturer,NUM_Quantity, CHR_Product_saleflag, NUM_Vat_category , NUM_Product_category, NUM_Barcode from TBL_SC_ITEMS ", con);
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

            con.Close();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_prod_id.Text == "")
            {
                MessageBox.Show("Please Enter A Product Name or ID in the search bar");
                DisplayData();
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                int textisnum = 0;
                if (txt_prod_id.Text.All(Char.IsLetter) || txt_prod_id.Text.Contains(" "))
                {
                    textisnum = 0;
                }
                else
                {
                    textisnum = Int32.Parse(txt_prod_id.Text);
                }

                cmd.CommandText = "SELECT * FROM TBL_SC_ITEMS WHERE NUM_itemID = " + textisnum + " OR NUM_Barcode = " + textisnum + " OR CHR_item_name = '" + txt_prod_id.Text.ToString() + "'";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_products.DataSource = dt;
                con.Close();
                ClearData();
                if (dgv_products.Rows.Count == 0)
                {
                    MessageBox.Show("No Results Found");
                    DisplayData();
                }
            }

        }
    }


}
