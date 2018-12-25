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
            DisplayInvoices();
        }

        SqlDataReader myReader = null;
        SqlCommand cmd,cmd2;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JOBDLMB\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapt;
        int invoiceid = -1;



        public void DisplayInvoices()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_INVOICE", conn);
            adapt.Fill(dt1);
            dgv_invoices.DataSource = dt1;

            this.dgv_invoices.DataSource = dt1;

            //dgv_invoices.Columns[0].HeaderCell.Value = "Order ID";
            //dgv_invoices.Columns[1].HeaderCell.Value = "Notes";
            //gridvie.Columns[2].HeaderCell.Value = "Delivery Date";
            //gridviewOrders.Columns[3].HeaderCell.Value = "Created Date";
            //gridviewOrders.Columns[4].HeaderCell.Value = "Delivery Address";
            //gridviewOrders.Columns[5].HeaderCell.Value = "Vendor ID";
            //gridviewOrders.Columns[6].HeaderCell.Value = "Total";
            //gridviewOrders.Columns[7].HeaderCell.Value = "Status";

            conn.Close();
        }


        public void DisplayInvoiceItems()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_INVOICE_ITEMS WHERE NUM_invoiceID =" + invoiceid, conn);
            adapt.Fill(dt1);
            dgv_invoice_items.DataSource = dt1;

            this.dgv_invoice_items.DataSource = dt1;

            //dgv_invoices.Columns[0].HeaderCell.Value = "Order ID";
            //dgv_invoices.Columns[1].HeaderCell.Value = "Notes";
            //gridvie.Columns[2].HeaderCell.Value = "Delivery Date";
            //gridviewOrders.Columns[3].HeaderCell.Value = "Created Date";
            //gridviewOrders.Columns[4].HeaderCell.Value = "Delivery Address";
            //gridviewOrders.Columns[5].HeaderCell.Value = "Vendor ID";
            //gridviewOrders.Columns[6].HeaderCell.Value = "Total";
            //gridviewOrders.Columns[7].HeaderCell.Value = "Status";

            conn.Close();
        }

        private void dgv_invoice_items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //txt_order_id.Text = .Rows[e.RowIndex].Cells[0].Value.ToString();
            //orderid = Int32.Parse(txt_order_id.Text);
        }

        private void dgv_invoices_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            invoiceid = Int32.Parse(dgv_invoices.Rows[e.RowIndex].Cells[0].Value.ToString());
            DisplayInvoiceItems();
        }

        private void btn_add_items_Click(object sender, EventArgs e)
        {

            cmd2 = new SqlCommand("UPDATE TBL_SC_ITEMS SET NUM_Quantity=@quantity WHERE NUM_itemID=@id", conn);
            cmd = new SqlCommand("UPDATE TBL_INVOICE SET CHR_Istatus = 'Completed' WHERE NUM_invoiceID="+invoiceid, conn);

            //try
            //{
                conn.Open();
                foreach (DataGridViewRow row in dgv_invoice_items.SelectedRows)

                {
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@id", row.Cells["NUM_itemID"].Value);
                    cmd2.Parameters.AddWithValue("@quantity", row.Cells["NUM_quantity"].Value);
                    cmd2.ExecuteNonQuery();
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Quantity Updated Successfully");
            conn.Close();
            //}catch
            //{
            //    MessageBox.Show("Error Occured");
            //}
        }

    }
}
