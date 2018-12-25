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
    public partial class VatCategories : Form
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataReader myReader = null;
        SqlCommand cmd;

        public VatCategories()
        {
            InitializeComponent();
        }

        public void disp_dataVatCategories()
        {

            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TBL_VAT_CATEGORIES ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewVatCategories.DataSource = dt;
            sqlCon.Close();

        }

        private void btnAddVatCategory_Click(object sender, EventArgs e)
        {

            try
            {
                sqlCon.Open();

                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                /*cmd.CommandText = "insert into TBL_VAT_CATEGORIES values('" + txtVatId.Text + "', '" + txtVatName.Text +
                    "', '" + txtVatDescription.Text + "' )";*/

                cmd = new SqlCommand("INSERT INTO TBL_VAT_CATEGORIES (NUM_Vat_rate, CHR_Description) " +
                "VALUES (@NUM_Vat_rate, @CHR_Description)", sqlCon);

                cmd.Parameters.AddWithValue("@NUM_Vat_rate", txtVatName.Text);
                cmd.Parameters.AddWithValue("@CHR_Description", txtVatDescription.Text);


                cmd.ExecuteNonQuery();

                sqlCon.Close();

                disp_dataVatCategories();

                MessageBox.Show("Vat Category Added Successfully!");
            }
            catch (Exception)
            {
                sqlCon.Close();
                MessageBox.Show("Error Found. Please ensure that the ID you inserted is unique. If this problem ensist, " +
                    "please contact your administrator");
            }

        }

        private void btnSearchVatCategory_Click(object sender, EventArgs e)
        {
            if (txtSearchVatCategory.Text == "")
            {
                MessageBox.Show("Please Enter A Vat Category ID above the Search button");
            }
            else
            {
                //Displays the searched id attributes to datagridview
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from TBL_VAT_CATEGORIES WHERE NUM_Vat_id = '" + txtSearchVatCategory.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewVatCategories.DataSource = dt;
                sqlCon.Close();

                //Displays the searched id attributes to textboxes
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM TBL_VAT_CATEGORIES WHERE NUM_Vat_id = '" + txtSearchVatCategory.Text + "'", sqlCon);

                sqlCon.Open();

                myReader = cmdSelect.ExecuteReader();
                
                while (myReader.Read())
                {

                    txtVatId.Text = (myReader["NUM_Vat_id"].ToString());
                    txtVatName.Text = (myReader["NUM_Vat_rate"].ToString());
                    txtVatDescription.Text = (myReader["CHR_Description"].ToString());

                }

                sqlCon.Close();
            }
        }


        public void ClearData()
        {
            txtVatId.Text = "";
            txtVatName.Text = "";
            txtVatDescription.Text = "";
            txtSearchVatCategory.Text = "";
        }

        private void btnEditVatCategory_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSearchVatCategory.Text == "")
                {
                    MessageBox.Show("Insert the Vat ID in search to Update");
                }
                else
                {
                    cmd = new SqlCommand("UPDATE TBL_VAT_CATEGORIES set " +
                       "NUM_Vat_rate = '" + txtVatName.Text + "', " +
                       "CHR_Description = '" + txtVatDescription.Text + "' WHERE NUM_Vat_id = " + txtSearchVatCategory.Text + "", sqlCon);

                    sqlCon.Open();

                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    disp_dataVatCategories();
                    MessageBox.Show("Vat Category entry updated Successfully");
                    ClearData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error found. Please restart the application and try again.");
            }


        }

        private void btnDeleteVatCategory_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TBL_Vat_CATEGORIES where NUM_Vat_id ='" + txtVatId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlCon.Close();

            disp_dataVatCategories();
        }

        private void btnRefreshVatCategory_Click(object sender, EventArgs e)
        {
            disp_dataVatCategories();
        }

        private void VatCategories_Load(object sender, EventArgs e)
        {
            disp_dataVatCategories();
        }
    }
}
