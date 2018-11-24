namespace Stock_Control
{
    partial class ProductOrder
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(314, 192);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 19);
            this.btn_refresh.TabIndex = 98;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(253, 227);
            this.dgvSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowTemplate.Height = 24;
            this.dgvSuppliers.Size = new System.Drawing.Size(247, 226);
            this.dgvSuppliers.TabIndex = 97;
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(392, 155);
            this.btn_deleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(108, 19);
            this.btn_deleteProduct.TabIndex = 96;
            this.btn_deleteProduct.Text = "Delete Product";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(253, 155);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(108, 19);
            this.btn_addProduct.TabIndex = 95;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(297, 26);
            this.label12.TabIndex = 94;
            this.label12.Text = "Please enter item and Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(314, 109);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(76, 20);
            this.txt_quantity.TabIndex = 93;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(314, 84);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(76, 20);
            this.txt_itemID.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Item ID:";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Location = new System.Drawing.Point(314, 54);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(76, 20);
            this.txt_orderID.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Order ID:";
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 463);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.label1);
            this.Name = "ProductOrder";
            this.Text = "ProductOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Label label1;
    }
}