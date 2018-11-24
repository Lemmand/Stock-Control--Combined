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
    public partial class ProductCategories : Form
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataReader myReader = null;
        SqlCommand cmd;

        public ProductCategories()
        {
            InitializeComponent();
        }

        public void disp_dataProductCategories()
        {
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TBL_PRODUCT_CATEGORIES ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewProductCategories.DataSource = dt;
            sqlCon.Close();

        }

        private void btnRefreshProductCategory_Click(object sender, EventArgs e)
        {
            disp_dataProductCategories();
        }

        private void btnAddProductCategory_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into TBL_PRODUCT_CATEGORIES values('" + txtCategoryId.Text + "', '" + txtCategoryName.Text + "', '" + txtCategoryDescription.Text + "' )";
            cmd.ExecuteNonQuery();

            sqlCon.Close();

            disp_dataProductCategories();

            MessageBox.Show("Product Category Added Successfully!", "Product Categories");


        }

        private void btnDeleteProductCategory_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TBL_PRODUCT_CATEGORIES where NUM_ID ='" + txtCategoryId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlCon.Close();

            disp_dataProductCategories();
        }

        private void btnSearchProductCategory_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM TBL_PRODUCT_CATEGORIES WHERE NUM_Category_id = '" + txtSearchProductCategory.Text + "'", sqlCon);

            sqlCon.Open();

            myReader = cmdSelect.ExecuteReader();



            while (myReader.Read())
            {

                txtCategoryId.Text = (myReader["NUM_Category_id"].ToString());
                txtCategoryName.Text = (myReader["CHR_Category_name"].ToString());
                txtCategoryDescription.Text = (myReader["CHR_Description"].ToString());

            }

            sqlCon.Close();


        }

        public void ClearData()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtCategoryDescription.Text = "";
            txtSearchProductCategory.Text = "";

        }

        private void btnEditProductCategory_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE TBL_PRODUCT_CATEGORIES set " +
                   "CHR_Category_name = '" + txtCategoryName.Text + "', " +
                   "CHR_Description = '" + txtCategoryDescription.Text + "'", sqlCon);

            sqlCon.Open();
            if (txtCategoryId.Text == "")
            {
                MessageBox.Show("Insert the Category ID to Update", "Product Categories");
            }
            else
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Category entry updated Successfully", "Product Categories");
                ClearData();
            }
            sqlCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_dataProductCategories();
        }
    }
}
