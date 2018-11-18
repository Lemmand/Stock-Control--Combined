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
    public partial class InteractiveReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A9R1KT2\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        DataTable dt1, dt2;
        string original_quantity, price_difference_string, tostringresult, tostringmoneydiff;
        int quantity_difference;
        float price_difference;



        public InteractiveReport()
        {
            InitializeComponent();
            DisplayData();          
        }

        private void InteractiveReport_Load(object sender, EventArgs e)
        {
            dt2 = ((DataTable)dataGridView1.DataSource).Clone();
            dt2.Columns.Add(new DataColumn("Stock Found", typeof(int)));
            dt2.Columns.Add(new DataColumn("Difference of Stock", typeof(int)));
            dt2.Columns.Add(new DataColumn("Money Difference", typeof(float)));

            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Quantity";
            dataGridView1.Columns[3].HeaderCell.Value = "Price";
            dataGridView1.Columns[4].HeaderCell.Value = "Product Category";
            dataGridView2.Hide();
        } 
        private void DisplayData()
        {
            con.Open();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("Select NUM_itemID, CHR_item_name, NUM_Quantity, FT_price, NUM_Product_category from TBL_SC_ITEMS", con);
            adapt.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }
  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbl_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();     
            original_quantity = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            quantity_difference = Int32.Parse(original_quantity);
            price_difference_string = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            price_difference = Convert.ToSingle(price_difference_string);


        }
        
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs g)
        {
          
            label4.Text = "Difference in Stock is: " + dataGridView2.Rows[g.RowIndex].Cells[6].Value.ToString() + " And Difference in Money is: "
                + dataGridView2.Rows[g.RowIndex].Cells[7].Value.ToString() + " Euros";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_name.Text != "" && lbl_quantity.Text != "" && ID != -1)
            {
                if (txt_quant_found.Text != "")
                {
                    cmd = new SqlCommand("UPDATE TBL_SC_ITEMS SET NUM_Quantity=@quantity where NUM_itemID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@quantity", txt_quant_found.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Quantity Updated Successfully");


                    int quantity_found = Int32.Parse(txt_quant_found.Text);

                    if (txt_quant_found.Text != lbl_quantity.Text)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            dt2.ImportRow(((DataTable)dataGridView1.DataSource).Rows[row.Index]);

                            quantity_difference = quantity_found - quantity_difference;
                            price_difference = price_difference * quantity_difference;

                            tostringresult = quantity_difference.ToString();
                            tostringmoneydiff = price_difference.ToString();

                            DataRow lastrow = dt2.Rows[dt2.Rows.Count - 1];
                            lastrow["Difference of Stock"] = tostringresult;
                            lastrow["Stock Found"] = txt_quant_found.Text;
                            lastrow["Money Difference"] = tostringmoneydiff;
                        }
                        dt2.AcceptChanges();
                        dataGridView2.Show();
                        dataGridView2.DataSource = dt2;
                    }
                    con.Close();
                    dataGridView2.Columns[0].HeaderCell.Value = "ID";
                    dataGridView2.Columns[1].HeaderCell.Value = "Name";
                    dataGridView2.Columns[2].HeaderCell.Value = "Quantity";
                    dataGridView2.Columns[3].HeaderCell.Value = "Price";
                    dataGridView2.Columns[4].HeaderCell.Value = "Product Category";
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Item to Update");
                }
            } else
            {
                MessageBox.Show("Please Select an Item");
            }
        }

        private void ClearData()
        {
            lbl_name.Text = "";
            lbl_quantity.Text = "";
            txt_quant_found.Text = "";
            ID = -1;
        }

    }
}
