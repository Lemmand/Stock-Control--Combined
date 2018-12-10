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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.gridviewOrders = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gridviewVendors = new System.Windows.Forms.DataGridView();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vendorID = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_searchVendor = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewVendors)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewOrders
            // 
            this.gridviewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewOrders.Location = new System.Drawing.Point(16, 155);
            this.gridviewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridviewOrders.Name = "gridviewOrders";
            this.gridviewOrders.RowTemplate.Height = 24;
            this.gridviewOrders.Size = new System.Drawing.Size(1183, 201);
            this.gridviewOrders.TabIndex = 117;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(36, 115);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(144, 23);
            this.btn_refresh.TabIndex = 116;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gridviewVendors
            // 
            this.gridviewVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewVendors.Location = new System.Drawing.Point(12, 434);
            this.gridviewVendors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridviewVendors.Name = "gridviewVendors";
            this.gridviewVendors.RowTemplate.Height = 24;
            this.gridviewVendors.Size = new System.Drawing.Size(1187, 223);
            this.gridviewVendors.TabIndex = 115;
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.Location = new System.Drawing.Point(865, 115);
            this.btn_deleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(144, 23);
            this.btn_deleteOrder.TabIndex = 113;
            this.btn_deleteOrder.Text = "Delete Order";
            this.btn_deleteOrder.UseVisualStyleBackColor = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // txt_orderID
            // 
            this.txt_orderID.Location = new System.Drawing.Point(128, 79);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(100, 22);
            this.txt_orderID.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "Order ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(536, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 31);
            this.label12.TabIndex = 88;
            this.label12.Text = "Orders";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1245, 27);
            this.toolStrip1.TabIndex = 118;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 119;
            this.label2.Text = "Vendor ID:";
            // 
            // txt_vendorID
            // 
            this.txt_vendorID.Location = new System.Drawing.Point(114, 379);
            this.txt_vendorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vendorID.Name = "txt_vendorID";
            this.txt_vendorID.Size = new System.Drawing.Size(100, 22);
            this.txt_vendorID.TabIndex = 120;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(278, 78);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(144, 23);
            this.btn_search.TabIndex = 121;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_searchVendor
            // 
            this.btn_searchVendor.Location = new System.Drawing.Point(278, 378);
            this.btn_searchVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_searchVendor.Name = "btn_searchVendor";
            this.btn_searchVendor.Size = new System.Drawing.Size(144, 23);
            this.btn_searchVendor.TabIndex = 122;
            this.btn_searchVendor.Text = "Search";
            this.btn_searchVendor.UseVisualStyleBackColor = true;
            this.btn_searchVendor.Click += new System.EventHandler(this.btn_searchVendor_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 24);
            this.toolStripButton1.Text = "New Order";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(106, 24);
            this.toolStripButton2.Text = "Product Order";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 762);
            this.Controls.Add(this.btn_searchVendor);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_vendorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridviewOrders);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gridviewVendors);
            this.Controls.Add(this.btn_deleteOrder);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vendorID;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_searchVendor;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}