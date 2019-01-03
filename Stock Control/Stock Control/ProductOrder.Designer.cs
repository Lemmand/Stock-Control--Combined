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
            this.dgvProductOrder = new System.Windows.Forms.DataGridView();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txt_search_product_id = new System.Windows.Forms.TextBox();
            this.btn_search_product_id = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_prod_id = new System.Windows.Forms.TextBox();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(228, 365);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(374, 29);
            this.btn_refresh.TabIndex = 98;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dgvProductOrder
            // 
            this.dgvProductOrder.AllowUserToAddRows = false;
            this.dgvProductOrder.AllowUserToDeleteRows = false;
            this.dgvProductOrder.AllowUserToResizeColumns = false;
            this.dgvProductOrder.AllowUserToResizeRows = false;
            this.dgvProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOrder.Location = new System.Drawing.Point(11, 406);
            this.dgvProductOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductOrder.MultiSelect = false;
            this.dgvProductOrder.Name = "dgvProductOrder";
            this.dgvProductOrder.ReadOnly = true;
            this.dgvProductOrder.RowTemplate.Height = 24;
            this.dgvProductOrder.Size = new System.Drawing.Size(790, 122);
            this.dgvProductOrder.TabIndex = 97;
            this.dgvProductOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellContentClick);
            this.dgvProductOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductOrder_RowHeaderMouseClick);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProduct.ForeColor = System.Drawing.Color.White;
            this.btn_deleteProduct.Location = new System.Drawing.Point(228, 332);
            this.btn_deleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(374, 29);
            this.btn_deleteProduct.TabIndex = 96;
            this.btn_deleteProduct.Text = "Delete Product";
            this.btn_deleteProduct.UseVisualStyleBackColor = false;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.Location = new System.Drawing.Point(226, 300);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(376, 29);
            this.btn_addProduct.TabIndex = 95;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(302, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 26);
            this.label12.TabIndex = 94;
            this.label12.Text = "Order ID:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(90, 64);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(117, 26);
            this.txt_quantity.TabIndex = 93;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Enabled = false;
            this.txt_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemID.Location = new System.Drawing.Point(90, 25);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.ReadOnly = true;
            this.txt_itemID.Size = new System.Drawing.Size(117, 26);
            this.txt_itemID.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Item ID:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(11, 157);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(790, 122);
            this.dgvProducts.TabIndex = 99;
            // 
            // txt_search_product_id
            // 
            this.txt_search_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_product_id.Location = new System.Drawing.Point(47, 30);
            this.txt_search_product_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search_product_id.Name = "txt_search_product_id";
            this.txt_search_product_id.Size = new System.Drawing.Size(113, 26);
            this.txt_search_product_id.TabIndex = 105;
            // 
            // btn_search_product_id
            // 
            this.btn_search_product_id.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_search_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_product_id.ForeColor = System.Drawing.Color.White;
            this.btn_search_product_id.Location = new System.Drawing.Point(47, 60);
            this.btn_search_product_id.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_product_id.Name = "btn_search_product_id";
            this.btn_search_product_id.Size = new System.Drawing.Size(113, 26);
            this.btn_search_product_id.TabIndex = 104;
            this.btn_search_product_id.Text = "SEARCH";
            this.btn_search_product_id.UseVisualStyleBackColor = false;
            this.btn_search_product_id.Click += new System.EventHandler(this.btn_search_product_id_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_itemID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 100);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search_product_id);
            this.groupBox2.Controls.Add(this.btn_search_product_id);
            this.groupBox2.Location = new System.Drawing.Point(592, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Products";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_prod_id);
            this.groupBox3.Location = new System.Drawing.Point(21, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 67);
            this.groupBox3.TabIndex = 113;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Product ID";
            // 
            // txt_prod_id
            // 
            this.txt_prod_id.Enabled = false;
            this.txt_prod_id.Location = new System.Drawing.Point(10, 38);
            this.txt_prod_id.Name = "txt_prod_id";
            this.txt_prod_id.ReadOnly = true;
            this.txt_prod_id.Size = new System.Drawing.Size(100, 20);
            this.txt_prod_id.TabIndex = 0;
            // 
            // txt_order_id
            // 
            this.txt_order_id.Enabled = false;
            this.txt_order_id.Location = new System.Drawing.Point(405, 12);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.ReadOnly = true;
            this.txt_order_id.Size = new System.Drawing.Size(100, 20);
            this.txt_order_id.TabIndex = 114;
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(851, 579);
            this.Controls.Add(this.txt_order_id);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgvProductOrder);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label12);
            this.Name = "ProductOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Order";
            this.Load += new System.EventHandler(this.ProductOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgvProductOrder;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txt_search_product_id;
        private System.Windows.Forms.Button btn_search_product_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_prod_id;
        private System.Windows.Forms.TextBox txt_order_id;
    }
}