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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dgv_suppliers = new System.Windows.Forms.DataGridView();
            this.btn_show_suppliers = new System.Windows.Forms.Button();
            this.btn_show_vat = new System.Windows.Forms.Button();
            this.btn_shw_prod_cat = new System.Windows.Forms.Button();
            this.lbl_prod_cat = new System.Windows.Forms.Label();
            this.dgv_vat_cat = new System.Windows.Forms.DataGridView();
            this.dgv_prod_cat = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_saleflag = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_product_description = new System.Windows.Forms.TextBox();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.txt_vat_category = new System.Windows.Forms.TextBox();
            this.txt_product_category = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.txt_prod_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_prod_idd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vat_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(161, 123);
            this.txt_price.MaxLength = 200;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(199, 26);
            this.txt_price.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(372, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Product Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Name";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(161, 93);
            this.txt_quantity.MaxLength = 200;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(199, 26);
            this.txt_quantity.TabIndex = 27;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(161, 59);
            this.txt_name.MaxLength = 200;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(199, 26);
            this.txt_name.TabIndex = 26;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(407, 418);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(122, 29);
            this.btn_confirm.TabIndex = 25;
            this.btn_confirm.Text = "ADD";
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
            this.dgv_suppliers.Location = new System.Drawing.Point(8, 54);
            this.dgv_suppliers.Name = "dgv_suppliers";
            this.dgv_suppliers.ReadOnly = true;
            this.dgv_suppliers.Size = new System.Drawing.Size(869, 145);
            this.dgv_suppliers.TabIndex = 44;
            this.dgv_suppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_suppliers_RowHeaderMouseClick);
            // 
            // btn_show_suppliers
            // 
            this.btn_show_suppliers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_show_suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_suppliers.Location = new System.Drawing.Point(6, 19);
            this.btn_show_suppliers.Name = "btn_show_suppliers";
            this.btn_show_suppliers.Size = new System.Drawing.Size(159, 29);
            this.btn_show_suppliers.TabIndex = 46;
            this.btn_show_suppliers.Text = "Show Suppliers";
            this.btn_show_suppliers.UseVisualStyleBackColor = false;
            this.btn_show_suppliers.Click += new System.EventHandler(this.btn_show_suppliers_Click);
            // 
            // btn_show_vat
            // 
            this.btn_show_vat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_show_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_vat.Location = new System.Drawing.Point(171, 19);
            this.btn_show_vat.Name = "btn_show_vat";
            this.btn_show_vat.Size = new System.Drawing.Size(159, 29);
            this.btn_show_vat.TabIndex = 47;
            this.btn_show_vat.Text = "Show Vat Categories";
            this.btn_show_vat.UseVisualStyleBackColor = false;
            this.btn_show_vat.Click += new System.EventHandler(this.btn_show_vat_Click);
            // 
            // btn_shw_prod_cat
            // 
            this.btn_shw_prod_cat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_shw_prod_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shw_prod_cat.Location = new System.Drawing.Point(335, 19);
            this.btn_shw_prod_cat.Name = "btn_shw_prod_cat";
            this.btn_shw_prod_cat.Size = new System.Drawing.Size(164, 29);
            this.btn_shw_prod_cat.TabIndex = 48;
            this.btn_shw_prod_cat.Text = "Show Product Categories";
            this.btn_shw_prod_cat.UseVisualStyleBackColor = false;
            this.btn_shw_prod_cat.Click += new System.EventHandler(this.btn_shw_prod_cat_Click);
            // 
            // lbl_prod_cat
            // 
            this.lbl_prod_cat.AutoSize = true;
            this.lbl_prod_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod_cat.ForeColor = System.Drawing.Color.White;
            this.lbl_prod_cat.Location = new System.Drawing.Point(394, 168);
            this.lbl_prod_cat.Name = "lbl_prod_cat";
            this.lbl_prod_cat.Size = new System.Drawing.Size(0, 20);
            this.lbl_prod_cat.TabIndex = 52;
            // 
            // dgv_vat_cat
            // 
            this.dgv_vat_cat.AllowUserToAddRows = false;
            this.dgv_vat_cat.AllowUserToDeleteRows = false;
            this.dgv_vat_cat.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_vat_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vat_cat.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_vat_cat.Location = new System.Drawing.Point(8, 54);
            this.dgv_vat_cat.Name = "dgv_vat_cat";
            this.dgv_vat_cat.ReadOnly = true;
            this.dgv_vat_cat.Size = new System.Drawing.Size(866, 146);
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
            this.dgv_prod_cat.Location = new System.Drawing.Point(8, 54);
            this.dgv_prod_cat.Name = "dgv_prod_cat";
            this.dgv_prod_cat.ReadOnly = true;
            this.dgv_prod_cat.Size = new System.Drawing.Size(873, 146);
            this.dgv_prod_cat.TabIndex = 54;
            this.dgv_prod_cat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_prod_cat_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Sale Flag";
            // 
            // cb_saleflag
            // 
            this.cb_saleflag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_saleflag.FormattingEnabled = true;
            this.cb_saleflag.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Buy&Sell"});
            this.cb_saleflag.Location = new System.Drawing.Point(161, 154);
            this.cb_saleflag.Name = "cb_saleflag";
            this.cb_saleflag.Size = new System.Drawing.Size(199, 28);
            this.cb_saleflag.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Barcode";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(161, 188);
            this.txt_barcode.MaxLength = 200;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(199, 26);
            this.txt_barcode.TabIndex = 57;
            // 
            // txt_product_description
            // 
            this.txt_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_description.Location = new System.Drawing.Point(161, 322);
            this.txt_product_description.MaxLength = 300;
            this.txt_product_description.Multiline = true;
            this.txt_product_description.Name = "txt_product_description";
            this.txt_product_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_product_description.Size = new System.Drawing.Size(199, 64);
            this.txt_product_description.TabIndex = 62;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Enabled = false;
            this.txt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier.Location = new System.Drawing.Point(161, 279);
            this.txt_supplier.MaxLength = 200;
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.ReadOnly = true;
            this.txt_supplier.Size = new System.Drawing.Size(199, 26);
            this.txt_supplier.TabIndex = 61;
            // 
            // txt_vat_category
            // 
            this.txt_vat_category.Enabled = false;
            this.txt_vat_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vat_category.Location = new System.Drawing.Point(161, 248);
            this.txt_vat_category.MaxLength = 200;
            this.txt_vat_category.Name = "txt_vat_category";
            this.txt_vat_category.ReadOnly = true;
            this.txt_vat_category.Size = new System.Drawing.Size(199, 26);
            this.txt_vat_category.TabIndex = 60;
            // 
            // txt_product_category
            // 
            this.txt_product_category.Enabled = false;
            this.txt_product_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_category.Location = new System.Drawing.Point(161, 218);
            this.txt_product_category.MaxLength = 200;
            this.txt_product_category.Name = "txt_product_category";
            this.txt_product_category.ReadOnly = true;
            this.txt_product_category.Size = new System.Drawing.Size(199, 26);
            this.txt_product_category.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Product Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Supplier ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = "Vat Category ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "Product Category ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(535, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 67;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(671, 418);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 29);
            this.btn_delete.TabIndex = 73;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(5, 51);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(497, 38);
            this.btn_search.TabIndex = 72;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AllowUserToResizeColumns = false;
            this.dgv_products.AllowUserToResizeRows = false;
            this.dgv_products.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(6, 95);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.Size = new System.Drawing.Size(496, 216);
            this.dgv_products.TabIndex = 71;
            this.dgv_products.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_products_RowHeaderMouseClick);
            // 
            // txt_prod_id
            // 
            this.txt_prod_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_id.Location = new System.Drawing.Point(6, 19);
            this.txt_prod_id.Name = "txt_prod_id";
            this.txt_prod_id.Size = new System.Drawing.Size(496, 26);
            this.txt_prod_id.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_prod_idd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_saleflag);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_product_description);
            this.groupBox1.Controls.Add(this.txt_product_category);
            this.groupBox1.Controls.Add(this.txt_supplier);
            this.groupBox1.Controls.Add(this.txt_vat_category);
            this.groupBox1.Location = new System.Drawing.Point(14, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 405);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // txt_prod_idd
            // 
            this.txt_prod_idd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_idd.Location = new System.Drawing.Point(161, 24);
            this.txt_prod_idd.MaxLength = 200;
            this.txt_prod_idd.Name = "txt_prod_idd";
            this.txt_prod_idd.ReadOnly = true;
            this.txt_prod_idd.Size = new System.Drawing.Size(199, 26);
            this.txt_prod_idd.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Product ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_show_suppliers);
            this.groupBox2.Controls.Add(this.dgv_suppliers);
            this.groupBox2.Controls.Add(this.btn_show_vat);
            this.groupBox2.Controls.Add(this.btn_shw_prod_cat);
            this.groupBox2.Controls.Add(this.dgv_vat_cat);
            this.groupBox2.Controls.Add(this.dgv_prod_cat);
            this.groupBox2.Location = new System.Drawing.Point(14, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 221);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Associatives";
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.txt_prod_id);
            this.groupbox3.Controls.Add(this.lbl_prod_cat);
            this.groupbox3.Controls.Add(this.dgv_products);
            this.groupbox3.Controls.Add(this.btn_search);
            this.groupbox3.Location = new System.Drawing.Point(402, 61);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Size = new System.Drawing.Size(515, 328);
            this.groupbox3.TabIndex = 76;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "Products";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(928, 703);
            this.Controls.Add(this.groupbox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_confirm);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Menu";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vat_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupbox3.ResumeLayout(false);
            this.groupbox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView dgv_suppliers;
        private System.Windows.Forms.Button btn_show_suppliers;
        private System.Windows.Forms.Button btn_show_vat;
        private System.Windows.Forms.Button btn_shw_prod_cat;
        private System.Windows.Forms.Label lbl_prod_cat;
        private System.Windows.Forms.DataGridView dgv_vat_cat;
        private System.Windows.Forms.DataGridView dgv_prod_cat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_saleflag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_product_description;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.TextBox txt_vat_category;
        private System.Windows.Forms.TextBox txt_product_category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.TextBox txt_prod_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_prod_idd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupbox3;
    }
}