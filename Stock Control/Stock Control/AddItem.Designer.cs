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
            this.btn_show_suppliers = new System.Windows.Forms.Button();
            this.btn_show_vat = new System.Windows.Forms.Button();
            this.btn_shw_prod_cat = new System.Windows.Forms.Button();
            this.lbl_vat_cat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_prod_cat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_vat_cat = new System.Windows.Forms.DataGridView();
            this.dgv_prod_cat = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_saleflag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vat_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Supplier ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "ADD NEW ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.btn_confirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(315, 195);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(199, 66);
            this.btn_confirm.TabIndex = 25;
            this.btn_confirm.Text = "Submit";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click_1);
            // 
            // dgv_suppliers
            // 
            this.dgv_suppliers.AllowUserToAddRows = false;
            this.dgv_suppliers.AllowUserToDeleteRows = false;
            this.dgv_suppliers.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suppliers.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_suppliers.Location = new System.Drawing.Point(12, 425);
            this.dgv_suppliers.Name = "dgv_suppliers";
            this.dgv_suppliers.ReadOnly = true;
            this.dgv_suppliers.Size = new System.Drawing.Size(776, 146);
            this.dgv_suppliers.TabIndex = 44;
            this.dgv_suppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_suppliers_RowHeaderMouseClick);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.ForeColor = System.Drawing.Color.White;
            this.lbl_supplier.Location = new System.Drawing.Point(137, 345);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(0, 13);
            this.lbl_supplier.TabIndex = 45;
            // 
            // btn_show_suppliers
            // 
            this.btn_show_suppliers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_show_suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_suppliers.Location = new System.Drawing.Point(65, 368);
            this.btn_show_suppliers.Name = "btn_show_suppliers";
            this.btn_show_suppliers.Size = new System.Drawing.Size(82, 41);
            this.btn_show_suppliers.TabIndex = 46;
            this.btn_show_suppliers.Text = "Show Suppliers";
            this.btn_show_suppliers.UseVisualStyleBackColor = false;
            this.btn_show_suppliers.Click += new System.EventHandler(this.btn_show_suppliers_Click);
            // 
            // btn_show_vat
            // 
            this.btn_show_vat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_show_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_vat.Location = new System.Drawing.Point(229, 370);
            this.btn_show_vat.Name = "btn_show_vat";
            this.btn_show_vat.Size = new System.Drawing.Size(83, 39);
            this.btn_show_vat.TabIndex = 47;
            this.btn_show_vat.Text = "Show Vat Categories";
            this.btn_show_vat.UseVisualStyleBackColor = false;
            this.btn_show_vat.Click += new System.EventHandler(this.btn_show_vat_Click);
            // 
            // btn_shw_prod_cat
            // 
            this.btn_shw_prod_cat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_shw_prod_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shw_prod_cat.Location = new System.Drawing.Point(368, 372);
            this.btn_shw_prod_cat.Name = "btn_shw_prod_cat";
            this.btn_shw_prod_cat.Size = new System.Drawing.Size(95, 37);
            this.btn_shw_prod_cat.TabIndex = 48;
            this.btn_shw_prod_cat.Text = "Show Product Categories";
            this.btn_shw_prod_cat.UseVisualStyleBackColor = false;
            this.btn_shw_prod_cat.Click += new System.EventHandler(this.btn_shw_prod_cat_Click);
            // 
            // lbl_vat_cat
            // 
            this.lbl_vat_cat.AutoSize = true;
            this.lbl_vat_cat.ForeColor = System.Drawing.Color.White;
            this.lbl_vat_cat.Location = new System.Drawing.Point(312, 345);
            this.lbl_vat_cat.Name = "lbl_vat_cat";
            this.lbl_vat_cat.Size = new System.Drawing.Size(0, 13);
            this.lbl_vat_cat.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(235, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Vat Category:";
            // 
            // lbl_prod_cat
            // 
            this.lbl_prod_cat.AutoSize = true;
            this.lbl_prod_cat.ForeColor = System.Drawing.Color.White;
            this.lbl_prod_cat.Location = new System.Drawing.Point(469, 345);
            this.lbl_prod_cat.Name = "lbl_prod_cat";
            this.lbl_prod_cat.Size = new System.Drawing.Size(0, 13);
            this.lbl_prod_cat.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(371, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Product Category:";
            // 
            // dgv_vat_cat
            // 
            this.dgv_vat_cat.AllowUserToAddRows = false;
            this.dgv_vat_cat.AllowUserToDeleteRows = false;
            this.dgv_vat_cat.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_vat_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vat_cat.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_vat_cat.Location = new System.Drawing.Point(12, 425);
            this.dgv_vat_cat.Name = "dgv_vat_cat";
            this.dgv_vat_cat.ReadOnly = true;
            this.dgv_vat_cat.Size = new System.Drawing.Size(776, 146);
            this.dgv_vat_cat.TabIndex = 53;
            this.dgv_vat_cat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_vat_cat_RowHeaderMouseClick);
            // 
            // dgv_prod_cat
            // 
            this.dgv_prod_cat.AllowUserToAddRows = false;
            this.dgv_prod_cat.AllowUserToDeleteRows = false;
            this.dgv_prod_cat.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_prod_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod_cat.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_prod_cat.Location = new System.Drawing.Point(12, 425);
            this.dgv_prod_cat.Name = "dgv_prod_cat";
            this.dgv_prod_cat.ReadOnly = true;
            this.dgv_prod_cat.Size = new System.Drawing.Size(776, 146);
            this.dgv_prod_cat.TabIndex = 54;
            this.dgv_prod_cat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_prod_cat_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(312, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Sale Flag";
            // 
            // cb_saleflag
            // 
            this.cb_saleflag.FormattingEnabled = true;
            this.cb_saleflag.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Buy&Sell"});
            this.cb_saleflag.Location = new System.Drawing.Point(310, 99);
            this.cb_saleflag.Name = "cb_saleflag";
            this.cb_saleflag.Size = new System.Drawing.Size(121, 21);
            this.cb_saleflag.TabIndex = 56;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(937, 615);
            this.Controls.Add(this.cb_saleflag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_prod_cat);
            this.Controls.Add(this.dgv_vat_cat);
            this.Controls.Add(this.lbl_prod_cat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_vat_cat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_shw_prod_cat);
            this.Controls.Add(this.btn_show_vat);
            this.Controls.Add(this.btn_show_suppliers);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.dgv_suppliers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_confirm);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vat_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btn_show_suppliers;
        private System.Windows.Forms.Button btn_show_vat;
        private System.Windows.Forms.Button btn_shw_prod_cat;
        private System.Windows.Forms.Label lbl_vat_cat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_prod_cat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_vat_cat;
        private System.Windows.Forms.DataGridView dgv_prod_cat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_saleflag;
    }
}