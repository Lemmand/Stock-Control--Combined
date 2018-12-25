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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            disp_Orders_View();
        }

        SqlDataReader myReader = null;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JOBDLMB\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapt;
        int orderid = -1;
        int vendorid = -1;




        private void ClearData()
        {
            txt_orderID.Text = "";
                     
        }


        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (orderid == -1)
            {
                MessageBox.Show("Please Select An Order ID to Delete");
            }
            else
                try
                {                  
                        String query = "DELETE from TBL_PO_ITEMS where NUM_POID = '" + orderid + "'" +
                            "DELETE from TBL_PURCHASE_ORDER where NUM_POID = '" + orderid + "'";
                        SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                        SDA.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show("Deleted Successfully");
                conn.Close();
                ClearData();
                        disp_Orders_View();
                    
                }catch
                {
                   MessageBox.Show("Error Occured");
                }
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void checkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restock check_order = new Restock();
            check_order.Show();
        }

        public void disp_Orders_View()
        {
            conn.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from TBL_PURCHASE_ORDER", conn);
            adapt.Fill(dt1);
            gridviewOrders.DataSource = dt1;

            this.gridviewOrders.DataSource = dt1;

            gridviewOrders.Columns[0].HeaderCell.Value = "Order ID";
            gridviewOrders.Columns[1].HeaderCell.Value = "Notes";
            gridviewOrders.Columns[2].HeaderCell.Value = "Delivery Date";
            gridviewOrders.Columns[3].HeaderCell.Value = "Created Date";
            gridviewOrders.Columns[4].HeaderCell.Value = "Delivery Address";
            gridviewOrders.Columns[5].HeaderCell.Value = "Vendor ID";
            gridviewOrders.Columns[6].HeaderCell.Value = "Total";
            gridviewOrders.Columns[7].HeaderCell.Value = "Status";

            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBox1.seletedI)
        }

        private void gridviewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_order_id.Text = gridviewOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
            orderid = Int32.Parse(txt_order_id.Text);
            txt_created_date.Text = gridviewOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_total.Text = gridviewOrders.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_vendor.Text = gridviewOrders.Rows[e.RowIndex].Cells[5].Value.ToString();
            vendorid = Int32.Parse(txt_vendor.Text);
            txt_order_status.Text = gridviewOrders.Rows[e.RowIndex].Cells[7].Value.ToString();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_orderID.Text == "")
            {
                MessageBox.Show("Please Enter A Value In Product ID");
                disp_Orders_View();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TBL_PURCHASE_ORDER where NUM_POID = '" + txt_orderID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridviewOrders.DataSource = dt;
                conn.Close();
                ClearData();
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*MainMenu MainMenuForm = new MainMenu();
            NewOrder newordermenu = new NewOrder();
            newordermenu.MdiParent = this.ParentForm;
            
            newordermenu.Show();*/

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (orderid == -1)
            {
                MessageBox.Show("Please Select An Order To Edit");
            }
            else
            {
                ProductOrder form2 = new ProductOrder(orderid,vendorid);
                form2.ShowDialog();
            }
        }


    }
}

