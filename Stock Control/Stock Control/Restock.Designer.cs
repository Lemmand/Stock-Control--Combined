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
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_invoices = new System.Windows.Forms.DataGridView();
            this.dgv_invoice_items = new System.Windows.Forms.DataGridView();
            this.btn_add_items = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice_items)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(230, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 72;
            this.label12.Text = "Restock";
            // 
            // dgv_invoices
            // 
            this.dgv_invoices.AllowUserToAddRows = false;
            this.dgv_invoices.AllowUserToDeleteRows = false;
            this.dgv_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoices.Location = new System.Drawing.Point(12, 84);
            this.dgv_invoices.Name = "dgv_invoices";
            this.dgv_invoices.ReadOnly = true;
            this.dgv_invoices.Size = new System.Drawing.Size(592, 150);
            this.dgv_invoices.TabIndex = 73;
            this.dgv_invoices.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_invoices_RowHeaderMouseClick);
            // 
            // dgv_invoice_items
            // 
            this.dgv_invoice_items.AllowUserToAddRows = false;
            this.dgv_invoice_items.AllowUserToDeleteRows = false;
            this.dgv_invoice_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice_items.Location = new System.Drawing.Point(12, 240);
            this.dgv_invoice_items.Name = "dgv_invoice_items";
            this.dgv_invoice_items.ReadOnly = true;
            this.dgv_invoice_items.Size = new System.Drawing.Size(332, 150);
            this.dgv_invoice_items.TabIndex = 74;
            this.dgv_invoice_items.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_invoice_items_RowHeaderMouseClick);
            // 
            // btn_add_items
            // 
            this.btn_add_items.Location = new System.Drawing.Point(350, 348);
            this.btn_add_items.Name = "btn_add_items";
            this.btn_add_items.Size = new System.Drawing.Size(91, 42);
            this.btn_add_items.TabIndex = 75;
            this.btn_add_items.Text = "ADD ITEMS";
            this.btn_add_items.UseVisualStyleBackColor = true;
            this.btn_add_items.Click += new System.EventHandler(this.btn_add_items_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(350, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 57);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Invoice OR Order ID";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(18, 22);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(134, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(616, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add_items);
            this.Controls.Add(this.dgv_invoice_items);
            this.Controls.Add(this.dgv_invoices);
            this.Controls.Add(this.label12);
            this.Name = "Restock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice_items)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_invoices;
        private System.Windows.Forms.DataGridView dgv_invoice_items;
        private System.Windows.Forms.Button btn_add_items;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}