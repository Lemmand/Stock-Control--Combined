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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
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
            lbl_supplier.Text = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }

        private void dgv_vat_cat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vat_category_ID = Convert.ToInt32(dgv_vat_cat.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbl_vat_cat.Text = dgv_vat_cat.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void dgv_prod_cat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            prod_category_ID = Convert.ToInt32(dgv_prod_cat.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbl_prod_cat.Text = dgv_prod_cat.Rows[e.RowIndex].Cells[1].Value.ToString();

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
            cmd = new SqlCommand("INSERT INTO TBL_SC_ITEMS (CHR_item_name, FT_price, NUM_manufacturer, NUM_Vat_category , NUM_Quantity, CHR_Product_saleflag, NUM_Product_category) " +
                "VALUES (@CHR_item_name, @FT_price, @NUM_manufacturer, @NUM_Vat_category , @NUM_Quantity, @CHR_Product_saleflag, @NUM_Product_category)", con);

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
            }
            con.Close();                      
        }

        private void ClearData()
        {
            txt_name.Text = "";
            txt_quantity.Text = "";
            txt_price.Text = "";
            supplier_ID = -1;
            prod_category_ID = -1;
            vat_category_ID = -1;
            cb_saleflag.SelectedIndex = -1;
            lbl_prod_cat.Text = "";
            lbl_supplier.Text = "";
            lbl_vat_cat.Text = "";
            
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
    }
}
