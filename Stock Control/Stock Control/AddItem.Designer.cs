namespace Stock_Control
{
    partial class AddItem
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
            this.cb_saleflag = new System.Windows.Forms.ComboBox();
            this.cb_prodcat = new System.Windows.Forms.ComboBox();
            this.cb_vatcat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dgv_suppliers = new System.Windows.Forms.DataGridView();
            this.lbl_supplier = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_saleflag
            // 
            this.cb_saleflag.FormattingEnabled = true;
            this.cb_saleflag.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Buy&Sell"});
            this.cb_saleflag.Location = new System.Drawing.Point(342, 228);
            this.cb_saleflag.Name = "cb_saleflag";
            this.cb_saleflag.Size = new System.Drawing.Size(121, 21);
            this.cb_saleflag.TabIndex = 43;
            // 
            // cb_prodcat
            // 
            this.cb_prodcat.FormattingEnabled = true;
            this.cb_prodcat.Location = new System.Drawing.Point(342, 170);
            this.cb_prodcat.Name = "cb_prodcat";
            this.cb_prodcat.Size = new System.Drawing.Size(121, 21);
            this.cb_prodcat.TabIndex = 41;
            // 
            // cb_vatcat
            // 
            this.cb_vatcat.FormattingEnabled = true;
            this.cb_vatcat.Location = new System.Drawing.Point(342, 105);
            this.cb_vatcat.Name = "cb_vatcat";
            this.cb_vatcat.Size = new System.Drawing.Size(121, 21);
            this.cb_vatcat.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sale Flag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Product Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "VAT Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Supplier ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(75, 241);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(199, 20);
            this.txt_price.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "ADD NEW ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Name";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(75, 173);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(199, 20);
            this.txt_quantity.TabIndex = 27;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(75, 99);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(199, 20);
            this.txt_name.TabIndex = 26;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(342, 282);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(199, 66);
            this.btn_confirm.TabIndex = 25;
            this.btn_confirm.Text = "Submit";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // dgv_suppliers
            // 
            this.dgv_suppliers.AllowUserToAddRows = false;
            this.dgv_suppliers.AllowUserToDeleteRows = false;
            this.dgv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suppliers.Location = new System.Drawing.Point(75, 415);
            this.dgv_suppliers.Name = "dgv_suppliers";
            this.dgv_suppliers.ReadOnly = true;
            this.dgv_suppliers.Size = new System.Drawing.Size(776, 146);
            this.dgv_suppliers.TabIndex = 44;
            this.dgv_suppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_suppliers_RowHeaderMouseClick);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(137, 381);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(0, 13);
            this.lbl_supplier.TabIndex = 45;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 615);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.dgv_suppliers);
            this.Controls.Add(this.cb_saleflag);
            this.Controls.Add(this.cb_prodcat);
            this.Controls.Add(this.cb_vatcat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_confirm);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_saleflag;
        private System.Windows.Forms.ComboBox cb_prodcat;
        private System.Windows.Forms.ComboBox cb_vatcat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView dgv_suppliers;
        private System.Windows.Forms.Label lbl_supplier;
    }
}