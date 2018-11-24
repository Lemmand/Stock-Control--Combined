namespace Stock_Control
{
    partial class Orders
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
            this.gridviewOrders = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gridviewVendors = new System.Windows.Forms.DataGridView();
            this.btn_viewOrder = new System.Windows.Forms.Button();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.btn_editOrder = new System.Windows.Forms.Button();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.txt_orderStatus = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_createdDate = new System.Windows.Forms.TextBox();
            this.txt_deliveryDate = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_vendorID = new System.Windows.Forms.TextBox();
            this.txt_deliveryAddress = new System.Windows.Forms.TextBox();
            this.txt_terms = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_orderNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewVendors)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewOrders
            // 
            this.gridviewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewOrders.Location = new System.Drawing.Point(21, 234);
            this.gridviewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.gridviewOrders.Name = "gridviewOrders";
            this.gridviewOrders.RowTemplate.Height = 24;
            this.gridviewOrders.Size = new System.Drawing.Size(887, 122);
            this.gridviewOrders.TabIndex = 117;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(581, 209);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 19);
            this.btn_refresh.TabIndex = 116;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gridviewVendors
            // 
            this.gridviewVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewVendors.Location = new System.Drawing.Point(21, 365);
            this.gridviewVendors.Margin = new System.Windows.Forms.Padding(2);
            this.gridviewVendors.Name = "gridviewVendors";
            this.gridviewVendors.RowTemplate.Height = 24;
            this.gridviewVendors.Size = new System.Drawing.Size(890, 181);
            this.gridviewVendors.TabIndex = 115;
            // 
            // btn_viewOrder
            // 
            this.btn_viewOrder.Location = new System.Drawing.Point(581, 63);
            this.btn_viewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewOrder.Name = "btn_viewOrder";
            this.btn_viewOrder.Size = new System.Drawing.Size(108, 19);
            this.btn_viewOrder.TabIndex = 114;
            this.btn_viewOrder.Text = "View Order";
            this.btn_viewOrder.UseVisualStyleBackColor = true;
            this.btn_viewOrder.Click += new System.EventHandler(this.btn_viewOrder_Click);
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.Location = new System.Drawing.Point(694, 106);
            this.btn_deleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(108, 19);
            this.btn_deleteOrder.TabIndex = 113;
            this.btn_deleteOrder.Text = "Delete Order";
            this.btn_deleteOrder.UseVisualStyleBackColor = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // btn_editOrder
            // 
            this.btn_editOrder.Location = new System.Drawing.Point(694, 64);
            this.btn_editOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editOrder.Name = "btn_editOrder";
            this.btn_editOrder.Size = new System.Drawing.Size(108, 19);
            this.btn_editOrder.TabIndex = 112;
            this.btn_editOrder.Text = "Edit Order";
            this.btn_editOrder.UseVisualStyleBackColor = true;
            this.btn_editOrder.Click += new System.EventHandler(this.btn_editOrder_Click);
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(581, 106);
            this.btn_addOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(108, 19);
            this.btn_addOrder.TabIndex = 111;
            this.btn_addOrder.Text = "Add New Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // txt_orderStatus
            // 
            this.txt_orderStatus.Location = new System.Drawing.Point(655, 144);
            this.txt_orderStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txt_orderStatus.Name = "txt_orderStatus";
            this.txt_orderStatus.Size = new System.Drawing.Size(76, 20);
            this.txt_orderStatus.TabIndex = 110;
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(95, 137);
            this.txt_tax.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(76, 20);
            this.txt_tax.TabIndex = 109;
            // 
            // txt_createdDate
            // 
            this.txt_createdDate.Location = new System.Drawing.Point(96, 211);
            this.txt_createdDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_createdDate.Name = "txt_createdDate";
            this.txt_createdDate.Size = new System.Drawing.Size(140, 20);
            this.txt_createdDate.TabIndex = 108;
            // 
            // txt_deliveryDate
            // 
            this.txt_deliveryDate.Location = new System.Drawing.Point(96, 177);
            this.txt_deliveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_deliveryDate.Name = "txt_deliveryDate";
            this.txt_deliveryDate.Size = new System.Drawing.Size(140, 20);
            this.txt_deliveryDate.TabIndex = 107;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(402, 176);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(76, 20);
            this.txt_total.TabIndex = 106;
            // 
            // txt_vendorID
            // 
            this.txt_vendorID.Location = new System.Drawing.Point(402, 140);
            this.txt_vendorID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_vendorID.Name = "txt_vendorID";
            this.txt_vendorID.Size = new System.Drawing.Size(76, 20);
            this.txt_vendorID.TabIndex = 105;
            // 
            // txt_deliveryAddress
            // 
            this.txt_deliveryAddress.Location = new System.Drawing.Point(402, 103);
            this.txt_deliveryAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_deliveryAddress.Name = "txt_deliveryAddress";
            this.txt_deliveryAddress.Size = new System.Drawing.Size(76, 20);
            this.txt_deliveryAddress.TabIndex = 104;
            // 
            // txt_terms
            // 
            this.txt_terms.Location = new System.Drawing.Point(402, 64);
            this.txt_terms.Margin = new System.Windows.Forms.Padding(2);
            this.txt_terms.Name = "txt_terms";
            this.txt_terms.Size = new System.Drawing.Size(76, 20);
            this.txt_terms.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(581, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "Order Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Vendor ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Delivery Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Terms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Created Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Delivery Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Tax:";
            // 
            // txt_userID
            // 
            this.txt_userID.Location = new System.Drawing.Point(96, 102);
            this.txt_userID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(76, 20);
            this.txt_userID.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "User ID:";
            // 
            // txt_orderNotes
            // 
            this.txt_orderNotes.Location = new System.Drawing.Point(649, 176);
            this.txt_orderNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txt_orderNotes.Multiline = true;
            this.txt_orderNotes.Name = "txt_orderNotes";
            this.txt_orderNotes.Size = new System.Drawing.Size(98, 19);
            this.txt_orderNotes.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Order notes:";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Location = new System.Drawing.Point(96, 64);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(76, 20);
            this.txt_orderID.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Order ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(402, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 26);
            this.label12.TabIndex = 88;
            this.label12.Text = "Orders";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 118;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel1.Text = "Product Order";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Created",
            "Pending Approval",
            "Awaiting Items",
            "Completed"});
            this.comboBox1.Location = new System.Drawing.Point(736, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 119;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 619);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridviewOrders);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gridviewVendors);
            this.Controls.Add(this.btn_viewOrder);
            this.Controls.Add(this.btn_deleteOrder);
            this.Controls.Add(this.btn_editOrder);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.txt_orderStatus);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_createdDate);
            this.Controls.Add(this.txt_deliveryDate);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_vendorID);
            this.Controls.Add(this.txt_deliveryAddress);
            this.Controls.Add(this.txt_terms);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_orderNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewVendors)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewOrders;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView gridviewVendors;
        private System.Windows.Forms.Button btn_viewOrder;
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.Button btn_editOrder;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.TextBox txt_orderStatus;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_createdDate;
        private System.Windows.Forms.TextBox txt_deliveryDate;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_vendorID;
        private System.Windows.Forms.TextBox txt_deliveryAddress;
        private System.Windows.Forms.TextBox txt_terms;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_orderNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}