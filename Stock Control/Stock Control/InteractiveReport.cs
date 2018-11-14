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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        DataTable dt1;
        string original_quantity;
        int quantity_difference;



        public InteractiveReport()
        {
            InitializeComponent();
            DisplayData();
            
        }

        private void InteractiveReport_Load(object sender, EventArgs e)
        {
            //Clone one time
            dt1 = ((DataTable)dataGridView1.DataSource).Clone();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("select NUM_itemID, CHR_item_name, NUM_Quantity, NUM_Product_category from TBL_SC_ITEMS", con);
            adapt.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dt1.Columns.Add(new DataColumn("Stock Found", typeof(int)));
            dt1.Columns.Add(new DataColumn("Difference of Stock", typeof(int)));
            con.Close();
        }


        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbl_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        //dataGridView2 RowHeaderMouseClick Event  
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            original_quantity = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            //lbl_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
            
        }

        //Update Record  
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_quant_found.Text != "")
            {
                cmd = new SqlCommand("UPDATE TBL_SC_ITEMS SET NUM_Quantity=@quantity where NUM_itemID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@quantity", txt_quant_found.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");



                quantity_difference = Int32.Parse(original_quantity);


                int quantity_found = Int32.Parse(txt_quant_found.Text);

                if (txt_quant_found.Text != lbl_quantity.Text)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dt1.ImportRow(((DataTable)dataGridView1.DataSource).Rows[row.Index]);
                        dt1.Columns["Stock Found"].Expression = txt_quant_found.Text;

                        quantity_difference = quantity_difference - quantity_found;
                        String tostringresult = quantity_difference.ToString();
                        dt1.Columns["Difference of Stock"].Expression = tostringresult;
                    }
                    dt1.AcceptChanges();

                    dataGridView2.DataSource = dt1;
                }
                con.Close();
                DisplayData();
                // ClearData();
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

       
    }
}
