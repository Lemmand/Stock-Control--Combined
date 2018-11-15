﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A9R1KT2\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int supplier_ID;

        public AddItem()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_VENDOR", con);
            adapt.Fill(dt1);
            dgv_suppliers.DataSource = dt1;
            con.Close();
        }




        //dgv_suppliers RowHeaderMouseClick Event  
        private void dgv_suppliers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplier_ID = Convert.ToInt32(dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbl_supplier.Text = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString();
           


        }



        private void btn_confirm_Click(object sender, EventArgs e)
        {

            con.Open(); 
            cmd = new SqlCommand("INSERT INTO TBL_SC_ITEMS (CHR_item_name, FT_price, CHR_info, NUM_Price, NUM_manufacturer, NUM_Vat_category , NUM_Quantity_id, CHR_Product_saleflag, NUM_Product_category) " +
                "VALUES (@CHR_item_name, @FT_price, @CHR_info, @NUM_Price, @NUM_manufacturer, @NUM_Vat_category , @NUM_Quantity_id, @CHR_Product_saleflag, @NUM_Product_category)", con);

            cmd.Parameters.AddWithValue("@CHR_item_name", txt_name.Text);
            cmd.Parameters.AddWithValue("@NUM_Quantity_id", txt_quantity.Text);
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
            } else
            {
                MessageBox.Show("Please Sale Flag");
            }
                
            


            cmd.ExecuteNonQuery();
            con.Close();
            txt_name.Text = "";
            txt_quantity.Text = "";
        }

    }
}
