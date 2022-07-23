
namespace Phamracy_Mangement_GUI
{
    partial class usersMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billIngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billHIstoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.billManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // billManagementToolStripMenuItem
            // 
            this.billManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billIngToolStripMenuItem,
            this.billHIstoryToolStripMenuItem});
            this.billManagementToolStripMenuItem.Name = "billManagementToolStripMenuItem";
            this.billManagementToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.billManagementToolStripMenuItem.Text = "Bill Management";
            // 
            // billIngToolStripMenuItem
            // 
            this.billIngToolStripMenuItem.Name = "billIngToolStripMenuItem";
            this.billIngToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.billIngToolStripMenuItem.Text = "BillIng";
            this.billIngToolStripMenuItem.Click += new System.EventHandler(this.billIngToolStripMenuItem_Click_1);
            // 
            // billHIstoryToolStripMenuItem
            // 
            this.billHIstoryToolStripMenuItem.Name = "billHIstoryToolStripMenuItem";
            this.billHIstoryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.billHIstoryToolStripMenuItem.Text = "Bill HIstory";
            this.billHIstoryToolStripMenuItem.Click += new System.EventHandler(this.billHIstoryToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // usersMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "usersMenuForm";
            this.Text = "usersMenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billIngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billHIstoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}