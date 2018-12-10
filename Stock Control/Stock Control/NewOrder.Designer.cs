namespace Stock_Control
{
    partial class NewOrder
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
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_createdDate = new System.Windows.Forms.TextBox();
            this.txt_deliveryDate = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_vendorID = new System.Windows.Forms.TextBox();
            this.txt_deliveryAddress = new System.Windows.Forms.TextBox();
            this.txt_terms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orderNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_suppliers = new System.Windows.Forms.DataGridView();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.dgv_prod_add = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_add)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(23, 204);
            this.btn_addOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(108, 19);
            this.btn_addOrder.TabIndex = 112;
            this.btn_addOrder.Text = "Add New Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(78, 76);
            this.txt_tax.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(76, 20);
            this.txt_tax.TabIndex = 141;
            // 
            // txt_createdDate
            // 
            this.txt_createdDate.Location = new System.Drawing.Point(86, 149);
            this.txt_createdDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_createdDate.Name = "txt_createdDate";
            this.txt_createdDate.Size = new System.Drawing.Size(140, 20);
            this.txt_createdDate.TabIndex = 140;
            // 
            // txt_deliveryDate
            // 
            this.txt_deliveryDate.Location = new System.Drawing.Point(86, 115);
            this.txt_deliveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_deliveryDate.Name = "txt_deliveryDate";
            this.txt_deliveryDate.Size = new System.Drawing.Size(140, 20);
            this.txt_deliveryDate.TabIndex = 139;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(369, 181);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(76, 20);
            this.txt_total.TabIndex = 138;
            // 
            // txt_vendorID
            // 
            this.txt_vendorID.Location = new System.Drawing.Point(369, 144);
            this.txt_vendorID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_vendorID.Name = "txt_vendorID";
            this.txt_vendorID.Size = new System.Drawing.Size(76, 20);
            this.txt_vendorID.TabIndex = 137;
            // 
            // txt_deliveryAddress
            // 
            this.txt_deliveryAddress.Location = new System.Drawing.Point(369, 108);
            this.txt_deliveryAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_deliveryAddress.Name = "txt_deliveryAddress";
            this.txt_deliveryAddress.Size = new System.Drawing.Size(76, 20);
            this.txt_deliveryAddress.TabIndex = 136;
            // 
            // txt_terms
            // 
            this.txt_terms.Location = new System.Drawing.Point(369, 69);
            this.txt_terms.Margin = new System.Windows.Forms.Padding(2);
            this.txt_terms.Name = "txt_terms";
            this.txt_terms.Size = new System.Drawing.Size(76, 20);
            this.txt_terms.TabIndex = 135;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 133;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 132;
            this.label9.Text = "Vendor ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Delivery Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 130;
            this.label7.Text = "Terms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Created Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Delivery Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Tax:";
            // 
            // txt_orderNotes
            // 
            this.txt_orderNotes.Location = new System.Drawing.Point(539, 72);
            this.txt_orderNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txt_orderNotes.Multiline = true;
            this.txt_orderNotes.Name = "txt_orderNotes";
            this.txt_orderNotes.Size = new System.Drawing.Size(129, 77);
            this.txt_orderNotes.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "Order notes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 26);
            this.label12.TabIndex = 120;
            this.label12.Text = "Add new order";
            // 
            // dgv_suppliers
            // 
            this.dgv_suppliers.AllowUserToAddRows = false;
            this.dgv_suppliers.AllowUserToDeleteRows = false;
            this.dgv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suppliers.Location = new System.Drawing.Point(12, 228);
            this.dgv_suppliers.Name = "dgv_suppliers";
            this.dgv_suppliers.ReadOnly = true;
            this.dgv_suppliers.Size = new System.Drawing.Size(742, 150);
            this.dgv_suppliers.TabIndex = 142;
            this.dgv_suppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_suppliers_RowHeaderMouseClick);
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(12, 384);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.Size = new System.Drawing.Size(742, 115);
            this.dgv_products.TabIndex = 143;
            this.dgv_products.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_products_RowHeaderMouseClick);
            this.dgv_products.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_products_RowHeaderMouseDoubleClick);
            // 
            // dgv_prod_add
            // 
            this.dgv_prod_add.AllowUserToAddRows = false;
            this.dgv_prod_add.AllowUserToDeleteRows = false;
            this.dgv_prod_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod_add.Location = new System.Drawing.Point(12, 228);
            this.dgv_prod_add.Name = "dgv_prod_add";
            this.dgv_prod_add.ReadOnly = true;
            this.dgv_prod_add.Size = new System.Drawing.Size(720, 150);
            this.dgv_prod_add.TabIndex = 144;
            this.dgv_prod_add.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_prod_add_RowHeaderMouseDoubleClick);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 495);
            this.Controls.Add(this.dgv_prod_add);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.dgv_suppliers);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_createdDate);
            this.Controls.Add(this.txt_deliveryDate);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_vendorID);
            this.Controls.Add(this.txt_deliveryAddress);
            this.Controls.Add(this.txt_terms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_orderNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_addOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_createdDate;
        private System.Windows.Forms.TextBox txt_deliveryDate;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_vendorID;
        private System.Windows.Forms.TextBox txt_deliveryAddress;
        private System.Windows.Forms.TextBox txt_terms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orderNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_suppliers;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.DataGridView dgv_prod_add;
    }
}