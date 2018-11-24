namespace Stock_Control
{
    partial class Restock
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
            this.gridviewRestock = new System.Windows.Forms.DataGridView();
            this.lbl_orderStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_checkOrder = new System.Windows.Forms.Button();
            this.lbl_amountOrdered = new System.Windows.Forms.Label();
            this.lbl_amountReceived = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewRestock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(146, 221);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(90, 19);
            this.btn_refresh.TabIndex = 85;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // gridviewRestock
            // 
            this.gridviewRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewRestock.Location = new System.Drawing.Point(146, 245);
            this.gridviewRestock.Margin = new System.Windows.Forms.Padding(2);
            this.gridviewRestock.Name = "gridviewRestock";
            this.gridviewRestock.RowTemplate.Height = 24;
            this.gridviewRestock.Size = new System.Drawing.Size(511, 192);
            this.gridviewRestock.TabIndex = 84;
            // 
            // lbl_orderStatus
            // 
            this.lbl_orderStatus.AutoSize = true;
            this.lbl_orderStatus.Location = new System.Drawing.Point(241, 198);
            this.lbl_orderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_orderStatus.Name = "lbl_orderStatus";
            this.lbl_orderStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_orderStatus.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Order Status:";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(434, 62);
            this.lbl_productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(0, 13);
            this.lbl_productName.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Product Name:";
            // 
            // btn_checkOrder
            // 
            this.btn_checkOrder.Location = new System.Drawing.Point(146, 165);
            this.btn_checkOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_checkOrder.Name = "btn_checkOrder";
            this.btn_checkOrder.Size = new System.Drawing.Size(90, 19);
            this.btn_checkOrder.TabIndex = 79;
            this.btn_checkOrder.Text = "Check Order";
            this.btn_checkOrder.UseVisualStyleBackColor = true;
            // 
            // lbl_amountOrdered
            // 
            this.lbl_amountOrdered.AutoSize = true;
            this.lbl_amountOrdered.Location = new System.Drawing.Point(241, 91);
            this.lbl_amountOrdered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amountOrdered.Name = "lbl_amountOrdered";
            this.lbl_amountOrdered.Size = new System.Drawing.Size(0, 13);
            this.lbl_amountOrdered.TabIndex = 78;
            // 
            // lbl_amountReceived
            // 
            this.lbl_amountReceived.AutoSize = true;
            this.lbl_amountReceived.Location = new System.Drawing.Point(241, 122);
            this.lbl_amountReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amountReceived.Name = "lbl_amountReceived";
            this.lbl_amountReceived.Size = new System.Drawing.Size(0, 13);
            this.lbl_amountReceived.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Amount Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Amount Ordered:";
            // 
            // txt_productID
            // 
            this.txt_productID.Location = new System.Drawing.Point(243, 60);
            this.txt_productID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(76, 20);
            this.txt_productID.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Product ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 72;
            this.label12.Text = "Restock";
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gridviewRestock);
            this.Controls.Add(this.lbl_orderStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_checkOrder);
            this.Controls.Add(this.lbl_amountOrdered);
            this.Controls.Add(this.lbl_amountReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Name = "Restock";
            this.Text = "Restock";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewRestock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView gridviewRestock;
        private System.Windows.Forms.Label lbl_orderStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_checkOrder;
        private System.Windows.Forms.Label lbl_amountOrdered;
        private System.Windows.Forms.Label lbl_amountReceived;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
    }
}