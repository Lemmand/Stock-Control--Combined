﻿using System;
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

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-3S627FD\SQLEXPRESS;Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataReader myReader = null;
        SqlCommand cmd;
        
        public ProductCategories()
        {
            InitializeComponent();
            disp_dataProductCategories();
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
            try
            {
                sqlCon.Open();

                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into TBL_PRODUCT_CATEGORIES values( NUM_Category_id '" + txtCategoryId.Text + "', '" + txtCategoryName.Text + 
                    "', '" + txtCategoryDescription.Text + "' )";
                cmd.ExecuteNonQuery();

                sqlCon.Close();

                disp_dataProductCategories();

                MessageBox.Show("Product Category Added Successfully!");
            }
            catch (Exception)
            {
                sqlCon.Close();
                MessageBox.Show("Error Found. Please ensure that the ID you inserted is unique. If this problem ensist, " +
                    "please contact your administrator");
            }
            


        }

        private void btnDeleteProductCategory_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TBL_PRODUCT_CATEGORIES where NUM_Category_id ='" + txtCategoryId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlCon.Close();

            disp_dataProductCategories();
        }

        private void btnSearchProductCategory_Click(object sender, EventArgs e)
        {

            if (txtSearchProductCategory.Text == "")
            {
                MessageBox.Show("Please Enter A Product Category ID above the Search button");
            }
            else
            {
                //Displays the searched id attributes to datagridview
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from TBL_PRODUCT_CATEGORIES WHERE NUM_Category_id = '" + txtSearchProductCategory.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewProductCategories.DataSource = dt;
                sqlCon.Close();

                //Displays the searched id attributes to textboxes
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
            try
            {
                if (txtCategoryId.Text == "")
                {
                    MessageBox.Show("Insert the Category ID to Update");
                }
                else
                {
                    cmd = new SqlCommand("UPDATE TBL_PRODUCT_CATEGORIES set " +
                       "CHR_Category_name = '" + txtCategoryName.Text + "', " +
                       "CHR_Description = '" + txtCategoryDescription.Text + "' WHERE NUM_Category_id = " + txtCategoryId.Text + "", sqlCon);

                    sqlCon.Open();

                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    disp_dataProductCategories();
                    MessageBox.Show("Product Category entry updated Successfully");
                    ClearData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error found. Please restart the application and try again.");
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_dataProductCategories();
        }

        private void ProductCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
