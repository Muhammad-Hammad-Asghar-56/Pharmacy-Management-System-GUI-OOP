
namespace Phamracy_Mangement_GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSignUP = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pharmacyPicBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(115, 122);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(122, 144);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(53, 13);
            this.lblUserPassword.TabIndex = 10;
            this.lblUserPassword.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(181, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 5;
            // 
            // btnSignUP
            // 
            this.btnSignUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUP.Location = new System.Drawing.Point(345, 41);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(88, 31);
            this.btnSignUP.TabIndex = 9;
            this.btnSignUP.Text = "Sign UP";
            this.btnSignUP.UseVisualStyleBackColor = true;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(181, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(328, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(242, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 28);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.51435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.67108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.03532F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSignUP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pharmacyPicBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.28268F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.67491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 283);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sign IN ";
            // 
            // pharmacyPicBox
            // 
            this.pharmacyPicBox.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyPicBox.Image")));
            this.pharmacyPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pharmacyPicBox.InitialImage")));
            this.pharmacyPicBox.Location = new System.Drawing.Point(3, 3);
            this.pharmacyPicBox.Name = "pharmacyPicBox";
            this.pharmacyPicBox.Size = new System.Drawing.Size(172, 106);
            this.pharmacyPicBox.TabIndex = 13;
            this.pharmacyPicBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(469, 322);
            this.MinimumSize = new System.Drawing.Size(469, 322);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSignUP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pharmacyPicBox;
    }
}

