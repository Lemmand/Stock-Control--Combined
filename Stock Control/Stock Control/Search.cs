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
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Search()
        {
            InitializeComponent();
            DisplayData();
        }


        public void DisplayData()
        {

            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select NUM_itemID,CHR_item_name,FT_price,CHR_info, NUM_manufacturer,NUM_Quantity, CHR_Product_saleflag,TBL_VAT_CATEGORIES.NUM_Vat_rate, NUM_Product_category, NUM_Barcode from TBL_SC_ITEMS INNER JOIN TBL_VAT_CATEGORIES ON TBL_SC_ITEMS.NUM_Vat_category=TBL_VAT_CATEGORIES.NUM_Vat_id", con);
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
                MessageBox.Show("Please Enter A Value In Product ID");
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

        private void ClearData()
        {
            txt_prod_id.Text = "";
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_prod_id.Text = dgv_products.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_prod_id.Text == "")
            {
                MessageBox.Show("Please Enter A Value In Product ID");
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

        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            disp_Restock_View();
        }

        public void disp_Restock_View()
        {
            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_SC_ITEMS", con);
            adapt.Fill(dt1);
            dgv_products.DataSource = dt1;

            this.dgv_products.DataSource = dt1;

            dgv_products.Columns[0].HeaderCell.Value = "ID";
            dgv_products.Columns[1].HeaderCell.Value = "Name";
            dgv_products.Columns[2].HeaderCell.Value = "Price";
            dgv_products.Columns[3].HeaderCell.Value = "Info";
            dgv_products.Columns[4].HeaderCell.Value = "Manufacturer";
            dgv_products.Columns[5].HeaderCell.Value = "Quantity";
            dgv_products.Columns[6].HeaderCell.Value = "Saleflag";
            dgv_products.Columns[7].HeaderCell.Value = "Vat Category";
            dgv_products.Columns[8].HeaderCell.Value = "Product Category";
            dgv_products.Columns[9].HeaderCell.Value = "Barcode";

            con.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            disp_Restock_View();
        }
    }
}
