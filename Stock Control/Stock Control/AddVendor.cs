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
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            InitializeComponent();
            DisplayData();
        }
     
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JOBDLMB\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_vendorID.Text == "")
            {
                MessageBox.Show("Please Enter A Vendor ID to Update");
            }
            else
            {
                conn.Open();
                String query = "UPDATE TBL_VENDOR SET NUM_phone = '" + txt_Phone.Text + "' ,CHR_address ='" + txt_Address.Text + "',CHR_companyName ='" + txt_compName.Text + "',CHR_companyType ='" + txt_comType.Text + "',CHR_country ='" + txt_Country.Text + "',CHR_city ='" + txt_City.Text + "',CHR_titl ='" +
                    txt_Title.Text + "',CHR_firstname ='" + txt_Lname.Text + "',CHR_surname ='" + txt_Name.Text + "',CHR_email ='" + txt_Email.Text + "' WHERE NUM_Vendor_ID = " + txt_vendorID.Text + "";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Successfully");
                DisplayData();
                ClearData();
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_vendorID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_Phone.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_Address.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_compName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_comType.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_Country.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_City.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txt_Title.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txt_Lname.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txt_Name.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txt_Email.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        public void DisplayData()
        {
            conn.Open();
            String query = "Select * FROM TBL_VENDOR ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_vendorID.Text == "" || txt_Title.Text == "" || txt_Phone.Text == "" || txt_Name.Text == "" || txt_Lname.Text == "" || txt_Email.Text == ""
                || txt_Country.Text == "" || txt_comType.Text == "" || txt_compName.Text == "" || txt_City.Text == "" || txt_Address.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                conn.Open();
                String query = "insert into TBL_VENDOR (NUM_Vendor_ID, NUM_phone,CHR_address,CHR_companyName,CHR_companyType,CHR_country,CHR_city,CHR_titl,CHR_firstname,CHR_surname,CHR_email)" +
                    " VALUES ('" + txt_vendorID.Text + "','" + txt_Phone.Text + "','" + txt_Address.Text + "','" + txt_compName.Text + "','" + txt_comType.Text + "','" + txt_Country.Text + "','" + txt_City.Text + "','" + txt_Title.Text + "','" + txt_Lname.Text + "','" + txt_Name.Text + "','" + txt_Email.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted Successfully");
                conn.Close();
                DisplayData();
                ClearData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_vendorID.Text == "")
            {
                MessageBox.Show("Please Enter A Vendor ID to Delete");
            }
            else
            {
                conn.Open();
                String query = "DELETE FROM TBL_VENDOR where NUM_Vendor_ID ='" + txt_vendorID.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted Successfully");
                ClearData();
                DisplayData();
            }

        }

        private void ClearData()
        {
            txt_vendorID.Text = "";
            txt_Title.Text = "";
            txt_Phone.Text = "";
            txt_Name.Text = "";
            txt_Lname.Text = "";
            txt_Email.Text = "";
            txt_Country.Text = "";
            txt_comType.Text = "";
            txt_compName.Text = "";
            txt_City.Text = "";
            txt_Address.Text = "";
        }
    }
}

