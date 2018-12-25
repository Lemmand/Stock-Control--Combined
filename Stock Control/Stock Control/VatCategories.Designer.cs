namespace Stock_Control
{
    partial class VatCategories
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
            this.txtSearchVatCategory = new System.Windows.Forms.TextBox();
            this.btnSearchVatCategory = new System.Windows.Forms.Button();
            this.dataGridViewVatCategories = new System.Windows.Forms.DataGridView();
            this.btnRefreshVatCategory = new System.Windows.Forms.Button();
            this.btnDeleteVatCategory = new System.Windows.Forms.Button();
            this.btnEditVatCategory = new System.Windows.Forms.Button();
            this.btnAddVatCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVatDescription = new System.Windows.Forms.TextBox();
            this.txtVatName = new System.Windows.Forms.TextBox();
            this.txtVatId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVatCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchVatCategory
            // 
            this.txtSearchVatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVatCategory.Location = new System.Drawing.Point(204, 11);
            this.txtSearchVatCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchVatCategory.Name = "txtSearchVatCategory";
            this.txtSearchVatCategory.Size = new System.Drawing.Size(311, 30);
            this.txtSearchVatCategory.TabIndex = 38;
            // 
            // btnSearchVatCategory
            // 
            this.btnSearchVatCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchVatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVatCategory.ForeColor = System.Drawing.Color.White;
            this.btnSearchVatCategory.Location = new System.Drawing.Point(204, 46);
            this.btnSearchVatCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchVatCategory.Name = "btnSearchVatCategory";
            this.btnSearchVatCategory.Size = new System.Drawing.Size(311, 36);
            this.btnSearchVatCategory.TabIndex = 37;
            this.btnSearchVatCategory.Text = "Search by id";
            this.btnSearchVatCategory.UseVisualStyleBackColor = false;
            this.btnSearchVatCategory.Click += new System.EventHandler(this.btnSearchVatCategory_Click);
            // 
            // dataGridViewVatCategories
            // 
            this.dataGridViewVatCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVatCategories.Location = new System.Drawing.Point(532, 11);
            this.dataGridViewVatCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVatCategories.Name = "dataGridViewVatCategories";
            this.dataGridViewVatCategories.RowTemplate.Height = 24;
            this.dataGridViewVatCategories.Size = new System.Drawing.Size(701, 449);
            this.dataGridViewVatCategories.TabIndex = 36;
            // 
            // btnRefreshVatCategory
            // 
            this.btnRefreshVatCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshVatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshVatCategory.ForeColor = System.Drawing.Color.White;
            this.btnRefreshVatCategory.Location = new System.Drawing.Point(366, 422);
            this.btnRefreshVatCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshVatCategory.Name = "btnRefreshVatCategory";
            this.btnRefreshVatCategory.Size = new System.Drawing.Size(149, 36);
            this.btnRefreshVatCategory.TabIndex = 35;
            this.btnRefreshVatCategory.Text = "Refresh";
            this.btnRefreshVatCategory.UseVisualStyleBackColor = false;
            this.btnRefreshVatCategory.Click += new System.EventHandler(this.btnRefreshVatCategory_Click);
            // 
            // btnDeleteVatCategory
            // 
            this.btnDeleteVatCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteVatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVatCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVatCategory.Location = new System.Drawing.Point(366, 382);
            this.btnDeleteVatCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteVatCategory.Name = "btnDeleteVatCategory";
            this.btnDeleteVatCategory.Size = new System.Drawing.Size(149, 36);
            this.btnDeleteVatCategory.TabIndex = 34;
            this.btnDeleteVatCategory.Text = "Delete";
            this.btnDeleteVatCategory.UseVisualStyleBackColor = false;
            this.btnDeleteVatCategory.Click += new System.EventHandler(this.btnDeleteVatCategory_Click);
            // 
            // btnEditVatCategory
            // 
            this.btnEditVatCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditVatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVatCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditVatCategory.Location = new System.Drawing.Point(204, 422);
            this.btnEditVatCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditVatCategory.Name = "btnEditVatCategory";
            this.btnEditVatCategory.Size = new System.Drawing.Size(149, 36);
            this.btnEditVatCategory.TabIndex = 33;
            this.btnEditVatCategory.Text = "Edit";
            this.btnEditVatCategory.UseVisualStyleBackColor = false;
            this.btnEditVatCategory.Click += new System.EventHandler(this.btnEditVatCategory_Click);
            // 
            // btnAddVatCategory
            // 
            this.btnAddVatCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddVatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVatCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddVatCategory.Location = new System.Drawing.Point(204, 382);
            this.btnAddVatCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddVatCategory.Name = "btnAddVatCategory";
            this.btnAddVatCategory.Size = new System.Drawing.Size(149, 36);
            this.btnAddVatCategory.TabIndex = 32;
            this.btnAddVatCategory.Text = "Add";
            this.btnAddVatCategory.UseVisualStyleBackColor = false;
            this.btnAddVatCategory.Click += new System.EventHandler(this.btnAddVatCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Vat description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vat rate (%)";
            // 
            // txtVatDescription
            // 
            this.txtVatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatDescription.Location = new System.Drawing.Point(204, 189);
            this.txtVatDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVatDescription.MaxLength = 50;
            this.txtVatDescription.Multiline = true;
            this.txtVatDescription.Name = "txtVatDescription";
            this.txtVatDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVatDescription.Size = new System.Drawing.Size(311, 189);
            this.txtVatDescription.TabIndex = 28;
            // 
            // txtVatName
            // 
            this.txtVatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatName.Location = new System.Drawing.Point(204, 153);
            this.txtVatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVatName.MaxLength = 50;
            this.txtVatName.Name = "txtVatName";
            this.txtVatName.Size = new System.Drawing.Size(311, 30);
            this.txtVatName.TabIndex = 27;
            // 
            // txtVatId
            // 
            this.txtVatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatId.Location = new System.Drawing.Point(204, 117);
            this.txtVatId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVatId.MaxLength = 50;
            this.txtVatId.Name = "txtVatId";
            this.txtVatId.Size = new System.Drawing.Size(311, 30);
            this.txtVatId.TabIndex = 26;
            this.txtVatId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Vat id";
            this.label1.Visible = false;
            // 
            // VatCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1269, 490);
            this.Controls.Add(this.txtSearchVatCategory);
            this.Controls.Add(this.btnSearchVatCategory);
            this.Controls.Add(this.dataGridViewVatCategories);
            this.Controls.Add(this.btnRefreshVatCategory);
            this.Controls.Add(this.btnDeleteVatCategory);
            this.Controls.Add(this.btnEditVatCategory);
            this.Controls.Add(this.btnAddVatCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVatDescription);
            this.Controls.Add(this.txtVatName);
            this.Controls.Add(this.txtVatId);
            this.Name = "VatCategories";
            this.Text = "VatCategories";
            this.Load += new System.EventHandler(this.VatCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVatCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchVatCategory;
        private System.Windows.Forms.Button btnSearchVatCategory;
        private System.Windows.Forms.DataGridView dataGridViewVatCategories;
        private System.Windows.Forms.Button btnRefreshVatCategory;
        private System.Windows.Forms.Button btnDeleteVatCategory;
        private System.Windows.Forms.Button btnEditVatCategory;
        private System.Windows.Forms.Button btnAddVatCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVatDescription;
        private System.Windows.Forms.TextBox txtVatName;
        private System.Windows.Forms.TextBox txtVatId;
        private System.Windows.Forms.Label label1;
    }
}