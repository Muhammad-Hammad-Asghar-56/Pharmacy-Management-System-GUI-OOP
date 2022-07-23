
namespace Phamracy_Mangement_GUI
{
    partial class SignUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUP));
            this.lblRole = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkboxAdmin = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(239, 178);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(158, 13);
            this.lblRole.TabIndex = 17;
            this.lblRole.Text = "Enter the User role                     ";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(403, 373);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 9;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign UP";
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(244, 104);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(153, 13);
            this.lblNewUserName.TabIndex = 10;
            this.lblNewUserName.Text = "Enter the New User name        ";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(242, 252);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(155, 13);
            this.lblNewPassword.TabIndex = 11;
            this.lblNewPassword.Text = "Enter the New User Password  ";
            // 
            // txtHint
            // 
            this.txtHint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHint.Location = new System.Drawing.Point(403, 323);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(139, 20);
            this.txtHint.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(403, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(237, 326);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(160, 13);
            this.lblHint.TabIndex = 14;
            this.lblHint.Text = "Enter the hint for reset Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserName.Location = new System.Drawing.Point(403, 101);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHint, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHint, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNewPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNewUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveUser, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkboxAdmin, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // checkboxAdmin
            // 
            this.checkboxAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkboxAdmin.AutoSize = true;
            this.checkboxAdmin.Location = new System.Drawing.Point(403, 176);
            this.checkboxAdmin.Name = "checkboxAdmin";
            this.checkboxAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkboxAdmin.TabIndex = 18;
            this.checkboxAdmin.Text = "Admin";
            this.checkboxAdmin.UseVisualStyleBackColor = true;
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUP";
            this.Text = "SignUP";
            this.Load += new System.EventHandler(this.SignUP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkboxAdmin;
    }
}