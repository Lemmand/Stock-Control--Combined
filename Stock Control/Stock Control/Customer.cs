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
    public partial class Customer : Form
    {
        

        public Customer()
            {
                InitializeComponent();
                disp_DataCustomers();
            }
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
            SqlDataReader myReader = null;
            

        public void disp_DataCustomers()
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_CUSTOMERS ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }


            private void btn_add_Click(object sender, EventArgs e)
            {
                conn.Open();
                String query = "Insert Into TBL_CUSTOMERS (NUM_Customer_ID,NUM_phone, CHR_firstname, CHR_surname, CHR_email, CHR_address_, CHR_country, CHR_city)" +
                    " VALUES (" + textBox_id.Text + "," + textBox_phone.Text + ",'" + textBox_name.Text + "','" + textBox_surname.Text + "','" + textBox_email.Text + "','" + textBox_address.Text + "','" + textBox_country.Text + "','" + textBox_city.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);

                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Data added Successfully");

                conn.Close();
                disp_DataCustomers();
                ClearData();
            }

            private void btn_delete_Click(object sender, EventArgs e)
            {
                conn.Open();
                String query = "DELETE FROM TBL_CUSTOMERS WHERE NUM_Customer_ID='" + textBox_id.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted Successfully");
                disp_DataCustomers();
                ClearData();
            }

            private void btn_update_Click(object sender, EventArgs e)
            {
            if (textBox_address.Text == "" || textBox_city.Text == "" || textBox_country.Text == "" || textBox_email.Text == "" || textBox_id.Text == "" || textBox_name.Text == "" || textBox_phone.Text == "" || textBox_surname.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                conn.Open();
                String query = "UPDATE TBL_CUSTOMERS SET NUM_phone = '" + textBox_phone.Text + "' ,CHR_address_ ='" + textBox_address.Text + "',CHR_firstname ='" + textBox_name.Text + "',CHR_surname ='" + textBox_surname.Text + "',CHR_country ='" + textBox_country.Text + "',CHR_city ='" + textBox_city.Text + "',CHR_email ='" + textBox_email.Text  + "' WHERE NUM_Customer_ID = " + textBox_id.Text + "";

                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);

                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Edited Successfully");
                disp_DataCustomers();
                ClearData();
            }
            }

            private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchIDCustomer.Text == "")
                {
                    MessageBox.Show("Please Enter A Value In Customer ID");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from TBL_CUSTOMERS where NUM_Customer_ID = '" + txtSearchIDCustomer.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    

                    //Displays the searched id attributes to textboxes
                    SqlCommand cmdSelect = new SqlCommand("SELECT * FROM TBL_CUSTOMERS WHERE NUM_Customer_ID = '" + txtSearchIDCustomer.Text + "'", conn);

                    conn.Open();

                    myReader = cmdSelect.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        textBox_id.Text = (myReader["NUM_Customer_ID"].ToString());
                        textBox_name.Text = (myReader["CHR_firstname"].ToString());
                        textBox_surname.Text = (myReader["CHR_surname"].ToString());
                        textBox_country.Text = (myReader["CHR_country"].ToString());
                        textBox_city.Text = (myReader["CHR_city"].ToString());
                        textBox_address.Text = (myReader["CHR_address_"].ToString());
                        textBox_email.Text = (myReader["CHR_email"].ToString());
                        textBox_phone.Text = (myReader["NUM_phone"].ToString());

                    }

                    conn.Close();

                }
                }
                catch (Exception)
                {
                MessageBox.Show("Error. Please insert an existing id to search.");
                }

            }

            private void ClearData()
            {
                textBox_address.Text = "";
                textBox_city.Text = "";
                textBox_country.Text = "";
                textBox_email.Text = "";
                textBox_id.Text = "";
                textBox_name.Text = "";
                textBox_phone.Text = "";
                textBox_surname.Text = "";
            }


            private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                textBox_address.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox_city.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox_country.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox_email.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox_name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox_phone.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox_surname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_DataCustomers();
        }
    }
    }

