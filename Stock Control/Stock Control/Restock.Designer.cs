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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice_items)).BeginInit();
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
            this.dgv_invoices.Location = new System.Drawing.Point(12, 57);
            this.dgv_invoices.Name = "dgv_invoices";
            this.dgv_invoices.ReadOnly = true;
            this.dgv_invoices.Size = new System.Drawing.Size(504, 150);
            this.dgv_invoices.TabIndex = 73;
            this.dgv_invoices.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_invoices_RowHeaderMouseClick);
            // 
            // dgv_invoice_items
            // 
            this.dgv_invoice_items.AllowUserToAddRows = false;
            this.dgv_invoice_items.AllowUserToDeleteRows = false;
            this.dgv_invoice_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice_items.Location = new System.Drawing.Point(12, 213);
            this.dgv_invoice_items.Name = "dgv_invoice_items";
            this.dgv_invoice_items.ReadOnly = true;
            this.dgv_invoice_items.Size = new System.Drawing.Size(504, 150);
            this.dgv_invoice_items.TabIndex = 74;
            this.dgv_invoice_items.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_invoice_items_RowHeaderMouseClick);
            // 
            // btn_add_items
            // 
            this.btn_add_items.Location = new System.Drawing.Point(425, 369);
            this.btn_add_items.Name = "btn_add_items";
            this.btn_add_items.Size = new System.Drawing.Size(91, 42);
            this.btn_add_items.TabIndex = 75;
            this.btn_add_items.Text = "ADD ITEMS";
            this.btn_add_items.UseVisualStyleBackColor = true;
            this.btn_add_items.Click += new System.EventHandler(this.btn_add_items_Click);
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.btn_add_items);
            this.Controls.Add(this.dgv_invoice_items);
            this.Controls.Add(this.dgv_invoices);
            this.Controls.Add(this.label12);
            this.Name = "Restock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_invoices;
        private System.Windows.Forms.DataGridView dgv_invoice_items;
        private System.Windows.Forms.Button btn_add_items;
    }
}