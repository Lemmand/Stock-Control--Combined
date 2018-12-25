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
            DisplayInvoices(-1);
        }

        SqlDataReader myReader = null;
        SqlCommand cmd,cmd2;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapt;
        int invoiceid = -1;
        string status;



        public void DisplayInvoices(int searchid)
        {
            conn.Open();
            DataTable dt1 = new DataTable();

            if (searchid == -1)
            {
                adapt = new SqlDataAdapter("Select * from TBL_INVOICE", conn);
            }
            else
            {
                adapt = new SqlDataAdapter("Select * from TBL_INVOICE WHERE NUM_invoiceID ="+searchid + "OR NUM_POID ="+searchid, conn);
            }

            
            adapt.Fill(dt1);
            dgv_invoices.DataSource = dt1;

            this.dgv_invoices.DataSource = dt1;

            dgv_invoices.Columns[0].HeaderCell.Value = "Invoice ID";
            dgv_invoices.Columns[1].HeaderCell.Value = "Purchase Order ID";
            dgv_invoices.Columns[2].HeaderCell.Value = "Created Date";
            dgv_invoices.Columns[3].HeaderCell.Value = "Delivery Date";
            dgv_invoices.Columns[4].HeaderCell.Value = "Info";
            dgv_invoices.Columns[5].HeaderCell.Value = "Vendor ID";
            dgv_invoices.Columns[6].HeaderCell.Value = "Total";
            dgv_invoices.Columns[7].HeaderCell.Value = "Discount";
            dgv_invoices.Columns[8].HeaderCell.Value = "Status";

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

            dgv_invoice_items.Columns[0].HeaderCell.Value = "Invoice ID";
            dgv_invoice_items.Columns[1].HeaderCell.Value = "Item ID";
            dgv_invoice_items.Columns[2].HeaderCell.Value = "Quantity";

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
            status = dgv_invoices.Rows[e.RowIndex].Cells[8].Value.ToString();
            DisplayInvoiceItems();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.All(Char.IsLetter) || txt_search.Text.Contains(" "))
            {
                MessageBox.Show("Please Insert Only Numbers In Search");
                txt_search.Text = "";
            }
            else
            {
                int searchid = Int32.Parse(txt_search.Text);
                DisplayInvoices(searchid);
            }
        }

        private void btn_add_items_Click(object sender, EventArgs e)
        {

            cmd2 = new SqlCommand("UPDATE TBL_SC_ITEMS SET NUM_Quantity = (SELECT SUM(NUM_Quantity + @quantity) AS TotalItemsOrdered FROM TBL_SC_ITEMS WHERE NUM_itemID = @item_id) WHERE NUM_itemID = @id", conn);
            
            cmd = new SqlCommand("UPDATE TBL_INVOICE SET CHR_Istatus = 'Completed' WHERE NUM_invoiceID="+invoiceid, conn);

            if (status != "Completed")
            {

                try
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgv_invoice_items.Rows)

                    {
                        cmd2.Parameters.Clear();
                        cmd2.Parameters.AddWithValue("@id", row.Cells["NUM_itemID"].Value);
                        cmd2.Parameters.AddWithValue("@item_id", row.Cells["NUM_itemID"].Value);
                        cmd2.Parameters.AddWithValue("@quantity", row.Cells["NUM_quantity"].Value);
                        cmd2.ExecuteNonQuery();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Quantity Updated Successfully");
                    conn.Close();
                    DisplayInvoices(-1);
                }
                catch
                {
                    MessageBox.Show("Error Occured");
                }
            } else
            {
                MessageBox.Show("Invoice Already Added");
            }
            }

    }
}
