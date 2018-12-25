namespace Stock_Control
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.interactiveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fillCreatedOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.productOrderToolStripMenuItem,
            this.vendorMenuToolStripMenuItem,
            this.customerMenuToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(85, 24);
            this.toolStripDropDownButton1.Text = "Functions";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.productSearchToolStripMenuItem,
            this.productCategoriesToolStripMenuItem1});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // productSearchToolStripMenuItem
            // 
            this.productSearchToolStripMenuItem.Name = "productSearchToolStripMenuItem";
            this.productSearchToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.productSearchToolStripMenuItem.Text = "Product Search";
            this.productSearchToolStripMenuItem.Click += new System.EventHandler(this.productSearchToolStripMenuItem_Click);
            // 
            // productCategoriesToolStripMenuItem1
            // 
            this.productCategoriesToolStripMenuItem1.Name = "productCategoriesToolStripMenuItem1";
            this.productCategoriesToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.productCategoriesToolStripMenuItem1.Text = "Product Categories";
            this.productCategoriesToolStripMenuItem1.Click += new System.EventHandler(this.productCategoriesToolStripMenuItem1_Click);
            // 
            // productOrderToolStripMenuItem
            // 
            this.productOrderToolStripMenuItem.Name = "productOrderToolStripMenuItem";
            this.productOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.productOrderToolStripMenuItem.Text = "Vat Categories";
            this.productOrderToolStripMenuItem.Click += new System.EventHandler(this.productOrderToolStripMenuItem_Click);
            // 
            // vendorMenuToolStripMenuItem
            // 
            this.vendorMenuToolStripMenuItem.Name = "vendorMenuToolStripMenuItem";
            this.vendorMenuToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.vendorMenuToolStripMenuItem.Text = "Supplier Menu";
            this.vendorMenuToolStripMenuItem.Click += new System.EventHandler(this.vendorMenuToolStripMenuItem_Click);
            // 
            // customerMenuToolStripMenuItem
            // 
            this.customerMenuToolStripMenuItem.Name = "customerMenuToolStripMenuItem";
            this.customerMenuToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.customerMenuToolStripMenuItem.Text = "Customer Menu";
            this.customerMenuToolStripMenuItem.Click += new System.EventHandler(this.customerMenuToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interactiveReportToolStripMenuItem,
            this.restockToolStripMenuItem,
            this.createOrderToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(88, 24);
            this.toolStripDropDownButton2.Text = "Use Cases";
            // 
            // interactiveReportToolStripMenuItem
            // 
            this.interactiveReportToolStripMenuItem.Name = "interactiveReportToolStripMenuItem";
            this.interactiveReportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.interactiveReportToolStripMenuItem.Text = "Interactive Report";
            this.interactiveReportToolStripMenuItem.Click += new System.EventHandler(this.interactiveReportToolStripMenuItem_Click);
            // 
            // restockToolStripMenuItem
            // 
            this.restockToolStripMenuItem.Name = "restockToolStripMenuItem";
            this.restockToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.restockToolStripMenuItem.Text = "Restock";
            this.restockToolStripMenuItem.Click += new System.EventHandler(this.restockToolStripMenuItem_Click);
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderViewToolStripMenuItem,
            this.createOrderToolStripMenuItem1,
            this.fillCreatedOrderToolStripMenuItem});
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createOrderToolStripMenuItem.Text = "Order";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // orderViewToolStripMenuItem
            // 
            this.orderViewToolStripMenuItem.Name = "orderViewToolStripMenuItem";
            this.orderViewToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.orderViewToolStripMenuItem.Text = "Order View";
            this.orderViewToolStripMenuItem.Click += new System.EventHandler(this.orderViewToolStripMenuItem_Click);
            // 
            // createOrderToolStripMenuItem1
            // 
            this.createOrderToolStripMenuItem1.Name = "createOrderToolStripMenuItem1";
            this.createOrderToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.createOrderToolStripMenuItem1.Text = "Create Order";
            this.createOrderToolStripMenuItem1.Click += new System.EventHandler(this.createOrderToolStripMenuItem1_Click);
            // 
            // fillCreatedOrderToolStripMenuItem
            // 
            this.fillCreatedOrderToolStripMenuItem.Name = "fillCreatedOrderToolStripMenuItem";
            this.fillCreatedOrderToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fillCreatedOrderToolStripMenuItem.Text = "Fill created Order";
            this.fillCreatedOrderToolStripMenuItem.Click += new System.EventHandler(this.fillCreatedOrderToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem interactiveReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCategoriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fillCreatedOrderToolStripMenuItem;
    }
}