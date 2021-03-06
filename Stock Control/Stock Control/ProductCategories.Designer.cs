﻿namespace Stock_Control
{
    partial class ProductCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchProductCategory = new System.Windows.Forms.TextBox();
            this.btnSearchProductCategory = new System.Windows.Forms.Button();
            this.dataGridViewProductCategories = new System.Windows.Forms.DataGridView();
            this.btnRefreshProductCategory = new System.Windows.Forms.Button();
            this.btnDeleteProductCategory = new System.Windows.Forms.Button();
            this.btnEditProductCategory = new System.Windows.Forms.Button();
            this.btnAddProductCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProductCategory
            // 
            this.txtSearchProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductCategory.Location = new System.Drawing.Point(218, 52);
            this.txtSearchProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProductCategory.Name = "txtSearchProductCategory";
            this.txtSearchProductCategory.Size = new System.Drawing.Size(311, 30);
            this.txtSearchProductCategory.TabIndex = 25;
            // 
            // btnSearchProductCategory
            // 
            this.btnSearchProductCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProductCategory.ForeColor = System.Drawing.Color.White;
            this.btnSearchProductCategory.Location = new System.Drawing.Point(218, 87);
            this.btnSearchProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProductCategory.Name = "btnSearchProductCategory";
            this.btnSearchProductCategory.Size = new System.Drawing.Size(311, 36);
            this.btnSearchProductCategory.TabIndex = 24;
            this.btnSearchProductCategory.Text = "Search by id";
            this.btnSearchProductCategory.UseVisualStyleBackColor = false;
            this.btnSearchProductCategory.Click += new System.EventHandler(this.btnSearchProductCategory_Click);
            // 
            // dataGridViewProductCategories
            // 
            this.dataGridViewProductCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductCategories.Location = new System.Drawing.Point(546, 52);
            this.dataGridViewProductCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductCategories.Name = "dataGridViewProductCategories";
            this.dataGridViewProductCategories.RowTemplate.Height = 24;
            this.dataGridViewProductCategories.Size = new System.Drawing.Size(701, 449);
            this.dataGridViewProductCategories.TabIndex = 23;
            // 
            // btnRefreshProductCategory
            // 
            this.btnRefreshProductCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProductCategory.ForeColor = System.Drawing.Color.White;
            this.btnRefreshProductCategory.Location = new System.Drawing.Point(380, 463);
            this.btnRefreshProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshProductCategory.Name = "btnRefreshProductCategory";
            this.btnRefreshProductCategory.Size = new System.Drawing.Size(149, 36);
            this.btnRefreshProductCategory.TabIndex = 22;
            this.btnRefreshProductCategory.Text = "Refresh";
            this.btnRefreshProductCategory.UseVisualStyleBackColor = false;
            this.btnRefreshProductCategory.Click += new System.EventHandler(this.btnRefreshProductCategory_Click);
            // 
            // btnDeleteProductCategory
            // 
            this.btnDeleteProductCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProductCategory.Location = new System.Drawing.Point(380, 423);
            this.btnDeleteProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProductCategory.Name = "btnDeleteProductCategory";
            this.btnDeleteProductCategory.Size = new System.Drawing.Size(149, 36);
            this.btnDeleteProductCategory.TabIndex = 21;
            this.btnDeleteProductCategory.Text = "Delete";
            this.btnDeleteProductCategory.UseVisualStyleBackColor = false;
            this.btnDeleteProductCategory.Click += new System.EventHandler(this.btnDeleteProductCategory_Click);
            // 
            // btnEditProductCategory
            // 
            this.btnEditProductCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProductCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditProductCategory.Location = new System.Drawing.Point(218, 463);
            this.btnEditProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditProductCategory.Name = "btnEditProductCategory";
            this.btnEditProductCategory.Size = new System.Drawing.Size(149, 36);
            this.btnEditProductCategory.TabIndex = 20;
            this.btnEditProductCategory.Text = "Update";
            this.btnEditProductCategory.UseVisualStyleBackColor = false;
            this.btnEditProductCategory.Click += new System.EventHandler(this.btnEditProductCategory_Click);
            // 
            // btnAddProductCategory
            // 
            this.btnAddProductCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddProductCategory.Location = new System.Drawing.Point(218, 423);
            this.btnAddProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProductCategory.Name = "btnAddProductCategory";
            this.btnAddProductCategory.Size = new System.Drawing.Size(149, 36);
            this.btnAddProductCategory.TabIndex = 19;
            this.btnAddProductCategory.Text = "Add";
            this.btnAddProductCategory.UseVisualStyleBackColor = false;
            this.btnAddProductCategory.Click += new System.EventHandler(this.btnAddProductCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Category name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category id";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(218, 230);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryDescription.MaxLength = 20000;
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCategoryDescription.Size = new System.Drawing.Size(311, 189);
            this.txtCategoryDescription.TabIndex = 15;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(218, 194);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryName.MaxLength = 50;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(311, 30);
            this.txtCategoryName.TabIndex = 14;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(218, 158);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(311, 30);
            this.txtCategoryId.TabIndex = 13;
            // 
            // ProductCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1273, 566);
            this.Controls.Add(this.txtSearchProductCategory);
            this.Controls.Add(this.btnSearchProductCategory);
            this.Controls.Add(this.dataGridViewProductCategories);
            this.Controls.Add(this.btnRefreshProductCategory);
            this.Controls.Add(this.btnDeleteProductCategory);
            this.Controls.Add(this.btnEditProductCategory);
            this.Controls.Add(this.btnAddProductCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductCategories";
            this.Load += new System.EventHandler(this.ProductCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchProductCategory;
        private System.Windows.Forms.Button btnSearchProductCategory;
        private System.Windows.Forms.DataGridView dataGridViewProductCategories;
        private System.Windows.Forms.Button btnRefreshProductCategory;
        private System.Windows.Forms.Button btnDeleteProductCategory;
        private System.Windows.Forms.Button btnEditProductCategory;
        private System.Windows.Forms.Button btnAddProductCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryId;
    }
}