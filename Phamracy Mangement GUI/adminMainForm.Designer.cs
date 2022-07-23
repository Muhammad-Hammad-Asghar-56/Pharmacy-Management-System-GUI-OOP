
namespace Phamracy_Mangement_GUI
{
    partial class adminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.billManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumPriceBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximiumPriceBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seacrhByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterInovoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByOtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderOfStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.billManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.workerToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.stocksToolStripMenuItem,
            this.workersToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billsToolStripMenuItem.Text = "Bills";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stocksToolStripMenuItem.Text = "Stocks";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workersToolStripMenuItem.Text = "Workers";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            // 
            // billManagementToolStripMenuItem
            // 
            this.billManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billToolStripMenuItem,
            this.billHistoryToolStripMenuItem,
            this.minimumPriceBillToolStripMenuItem,
            this.maximiumPriceBillToolStripMenuItem,
            this.seacrhByToolStripMenuItem});
            this.billManagementToolStripMenuItem.Name = "billManagementToolStripMenuItem";
            this.billManagementToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.billManagementToolStripMenuItem.Text = "Bill Management";
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billToolStripMenuItem.Text = "Bill";
            this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click);
            // 
            // billHistoryToolStripMenuItem
            // 
            this.billHistoryToolStripMenuItem.Name = "billHistoryToolStripMenuItem";
            this.billHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billHistoryToolStripMenuItem.Text = "Bill History";
            this.billHistoryToolStripMenuItem.Click += new System.EventHandler(this.billHistoryToolStripMenuItem_Click_2);
            // 
            // minimumPriceBillToolStripMenuItem
            // 
            this.minimumPriceBillToolStripMenuItem.Name = "minimumPriceBillToolStripMenuItem";
            this.minimumPriceBillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimumPriceBillToolStripMenuItem.Text = "Minimum Price Bill";
            this.minimumPriceBillToolStripMenuItem.Click += new System.EventHandler(this.minimumPriceBillToolStripMenuItem_Click_2);
            // 
            // maximiumPriceBillToolStripMenuItem
            // 
            this.maximiumPriceBillToolStripMenuItem.Name = "maximiumPriceBillToolStripMenuItem";
            this.maximiumPriceBillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maximiumPriceBillToolStripMenuItem.Text = "Maximium Price Bill";
            this.maximiumPriceBillToolStripMenuItem.Click += new System.EventHandler(this.maximiumPriceBillToolStripMenuItem_Click_2);
            // 
            // seacrhByToolStripMenuItem
            // 
            this.seacrhByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterInovoiceToolStripMenuItem,
            this.searchByOtherToolStripMenuItem});
            this.seacrhByToolStripMenuItem.Name = "seacrhByToolStripMenuItem";
            this.seacrhByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seacrhByToolStripMenuItem.Text = "Seacrh By..";
            // 
            // enterInovoiceToolStripMenuItem
            // 
            this.enterInovoiceToolStripMenuItem.Name = "enterInovoiceToolStripMenuItem";
            this.enterInovoiceToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.enterInovoiceToolStripMenuItem.Text = "Enter Inovoice #";
            this.enterInovoiceToolStripMenuItem.Click += new System.EventHandler(this.enterInovoiceToolStripMenuItem_Click);
            // 
            // searchByOtherToolStripMenuItem
            // 
            this.searchByOtherToolStripMenuItem.Name = "searchByOtherToolStripMenuItem";
            this.searchByOtherToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.searchByOtherToolStripMenuItem.Text = "Search By other......";
            this.searchByOtherToolStripMenuItem.Click += new System.EventHandler(this.searchByOtherToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.viewUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addNewUserToolStripMenuItem.Text = "Add new User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewUserToolStripMenuItem.Text = "View User";
            this.viewUserToolStripMenuItem.Click += new System.EventHandler(this.viewUserToolStripMenuItem_Click);
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewWorkerToolStripMenuItem,
            this.viewStaffToolStripMenuItem,
            this.orderOfStaffToolStripMenuItem});
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.workerToolStripMenuItem.Text = "Staff";
            // 
            // addNewWorkerToolStripMenuItem
            // 
            this.addNewWorkerToolStripMenuItem.Name = "addNewWorkerToolStripMenuItem";
            this.addNewWorkerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewWorkerToolStripMenuItem.Text = "Hire Staff";
            this.addNewWorkerToolStripMenuItem.Click += new System.EventHandler(this.addNewWorkerToolStripMenuItem_Click);
            // 
            // viewStaffToolStripMenuItem
            // 
            this.viewStaffToolStripMenuItem.Name = "viewStaffToolStripMenuItem";
            this.viewStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStaffToolStripMenuItem.Text = "Edit staff";
            this.viewStaffToolStripMenuItem.Click += new System.EventHandler(this.viewStaffToolStripMenuItem_Click);
            // 
            // orderOfStaffToolStripMenuItem
            // 
            this.orderOfStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descendingToolStripMenuItem,
            this.asscendingToolStripMenuItem});
            this.orderOfStaffToolStripMenuItem.Name = "orderOfStaffToolStripMenuItem";
            this.orderOfStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderOfStaffToolStripMenuItem.Text = "Order of Staff";
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // asscendingToolStripMenuItem
            // 
            this.asscendingToolStripMenuItem.Name = "asscendingToolStripMenuItem";
            this.asscendingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asscendingToolStripMenuItem.Text = "Asscending";
            this.asscendingToolStripMenuItem.Click += new System.EventHandler(this.asscendingToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDStockToolStripMenuItem,
            this.thresholdStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.stockToolStripMenuItem.Text = "Stock ";
            // 
            // aDDStockToolStripMenuItem
            // 
            this.aDDStockToolStripMenuItem.Name = "aDDStockToolStripMenuItem";
            this.aDDStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDStockToolStripMenuItem.Text = "Add Invoice";
            this.aDDStockToolStripMenuItem.Click += new System.EventHandler(this.aDDStockToolStripMenuItem_Click);
            // 
            // thresholdStockToolStripMenuItem
            // 
            this.thresholdStockToolStripMenuItem.Name = "thresholdStockToolStripMenuItem";
            this.thresholdStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thresholdStockToolStripMenuItem.Text = "Threshold Stock";
            this.thresholdStockToolStripMenuItem.Click += new System.EventHandler(this.thresholdStockToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockSummaryToolStripMenuItem,
            this.saleSummaryToolStripMenuItem});
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // stockSummaryToolStripMenuItem
            // 
            this.stockSummaryToolStripMenuItem.Name = "stockSummaryToolStripMenuItem";
            this.stockSummaryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stockSummaryToolStripMenuItem.Text = "Stock Summary";
            this.stockSummaryToolStripMenuItem.Click += new System.EventHandler(this.stockSummaryToolStripMenuItem_Click);
            // 
            // saleSummaryToolStripMenuItem
            // 
            this.saleSummaryToolStripMenuItem.Name = "saleSummaryToolStripMenuItem";
            this.saleSummaryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saleSummaryToolStripMenuItem.Text = "Sale Summary";
            this.saleSummaryToolStripMenuItem.Click += new System.EventHandler(this.saleSummaryToolStripMenuItem_Click);
            // 
            // adminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminMainForm";
            this.Load += new System.EventHandler(this.adminMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem billManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumPriceBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximiumPriceBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seacrhByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderOfStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterInovoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByOtherToolStripMenuItem;
    }
}