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
    public partial class Restock : Form
    {
        public Restock()
        {
            InitializeComponent();
            disp_Restock_View();
        }

        SqlDataReader myReaderReceived = null;
        SqlDataReader myReaderOrdered = null;
        SqlDataReader myReaderGetProductName = null;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-ITRM35PP\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");

        private void btn_checkOrder_Click(object sender, EventArgs e)
        {
            if (txt_productID.Text == "")
            {
                MessageBox.Show("Please enter a value in product ID");
            }
            
            SqlCommand cmdSelectOrdered = new SqlCommand("SELECT NUM_quantity FROM TBL_PO_ITEMS WHERE NUM_itemID = '" + txt_productID.Text + "'", conn);

            conn.Open();
            myReaderOrdered = cmdSelectOrdered.ExecuteReader();
            while (myReaderOrdered.Read())
            {
                lbl_amountOrdered.Text = (myReaderOrdered["NUM_quantity"].ToString());
            }
            conn.Close();

            conn.Open();
            SqlCommand cmdSelectReceived = new SqlCommand("SELECT NUM_received FROM TBL_RECEIVED_ITEMS WHERE NUM_itemID = '" + txt_productID.Text + "'", conn);
            myReaderReceived = cmdSelectReceived.ExecuteReader();
            while (myReaderReceived.Read())
            {
                lbl_amountReceived.Text = (myReaderReceived["NUM_received"].ToString());
            }
            conn.Close();

            conn.Open();
            SqlCommand cmdSelectProductName = new SqlCommand("SELECT CHR_item_name FROM TBL_SC_ITEMS WHERE NUM_itemID = '" + txt_productID.Text + "'", conn);
            myReaderGetProductName = cmdSelectProductName.ExecuteReader();
            while (myReaderGetProductName.Read())
            {
                lbl_productName.Text = (myReaderGetProductName["CHR_item_name"].ToString());
            }
            conn.Close();

            if (lbl_amountOrdered.Text == lbl_amountReceived.Text)
            {
                SqlCommand cmdUpdateStock = new SqlCommand("UPDATE TBL_SC_ITEMS SET NUM_Quantity = NUM_Quantity + '" + lbl_amountReceived.Text + "'", conn);
                conn.Open();
                cmdUpdateStock.ExecuteNonQuery();
                lbl_orderStatus.Text = "Complete";
                conn.Close();
            }
            else
            {
                lbl_orderStatus.Text = "Incomplete";
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            disp_Restock_View();
        }

        public void disp_Restock_View()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_PO_ITEMS", conn);
            adapt.Fill(dt1);
            gridviewRestock.DataSource = dt1;

            this.gridviewRestock.DataSource = dt1;

            gridviewRestock.Columns[0].HeaderCell.Value = "Product Order ID";
            gridviewRestock.Columns[1].HeaderCell.Value = "Item ID";
            gridviewRestock.Columns[2].HeaderCell.Value = "Quantity";
            


            conn.Close();
        }

        private void btn_checkOrder_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmdSelectOrdered = new SqlCommand("SELECT NUM_quantity FROM TBL_PO_ITEMS WHERE NUM_itemID = '" + txt_productID.Text + "'", conn);

            conn.Open();
            myReaderOrdered = cmdSelectOrdered.ExecuteReader();
            while (myReaderOrdered.Read())
            {
                lbl_amountOrdered.Text = (myReaderOrdered["NUM_quantity"].ToString());
            }
            conn.Close();

            conn.Open();
            SqlCommand cmdSelectReceived = new SqlCommand("SELECT NUM_received FROM TBL_RECEIVED_ITEMS WHERE NUM_itemID = '" + txt_productID.Text + "'", conn);
            myReaderReceived = cmdSelectReceived.ExecuteReader();
            while (myReaderReceived.Read())
            {
                lbl_amountReceived.Text = (myReaderReceived["NUM_received"].ToString());
            }
            conn.Close();

            conn.Open();
            SqlCommand cmdSelectProductName = new SqlCommand("SELECT CHR_item_name FROM TBL_SC_ITEMS WHERE NUM_itemID = '" + txt_productID.Text + "'", conn);
            myReaderGetProductName = cmdSelectProductName.ExecuteReader();
            while (myReaderGetProductName.Read())
            {
                lbl_productName.Text = (myReaderGetProductName["CHR_item_name"].ToString());
            }
            conn.Close();

            if (lbl_amountOrdered.Text == lbl_amountReceived.Text)
            {
                SqlCommand cmdUpdateStock = new SqlCommand("UPDATE TBL_SC_ITEMS SET NUM_Quantity = NUM_Quantity + '" + lbl_amountReceived.Text + "'", conn);
                conn.Open();
                cmdUpdateStock.ExecuteNonQuery();
                lbl_orderStatus.Text = "Complete";
                conn.Close();
            }
            else
            {
                lbl_orderStatus.Text = "Incomplete";
            }
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            disp_Restock_View();
        }
    }
}
