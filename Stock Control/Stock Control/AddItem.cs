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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter datapt;

        public AddItem()
        {
            InitializeComponent();
        }

        
        

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            sqlcon.Open(); 
            cmd = new SqlCommand("INSERT INTO TBL_SC_ITEMS (CHR_item_name, FT_price, CHR_info, NUM_Price, NUM_manufacturer, NUM_Vat_category , NUM_Quantity_id, CHR_Product_saleflag, NUM_Product_category)" +
                " VALUES (@CHR_item_name, @FT_price, @CHR_info, @NUM_Price, @NUM_manufacturer, @NUM_Vat_category , @NUM_Quantity_id, @CHR_Product_saleflag, @NUM_Product_category)", sqlcon);

            cmd.Parameters.AddWithValue("@CHR_Product_Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@NUM_Quantity", txt_quantity.Text);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            txt_name.Text = "";
            txt_quantity.Text = "";
        }

    }
}
