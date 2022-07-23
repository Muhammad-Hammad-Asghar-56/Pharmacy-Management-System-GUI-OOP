
namespace Phamracy_Mangement_GUI.UsersOption
{
    partial class userBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userBilling));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.medicineListGVD = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.medicineDropComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLimitedStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.btnFinalBill = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineListGVD)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.medicineListGVD, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(410, 67);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 330);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // medicineListGVD
            // 
            this.medicineListGVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineListGVD.GridColor = System.Drawing.SystemColors.Control;
            this.medicineListGVD.Location = new System.Drawing.Point(3, 3);
            this.medicineListGVD.Name = "medicineListGVD";
            this.medicineListGVD.Size = new System.Drawing.Size(385, 316);
            this.medicineListGVD.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.78754F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.21246F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.medicineDropComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLimitedStock, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtQuantity, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ADD, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFinalBill, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDiscount, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDiscount, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 151);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.73949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.26051F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(480, 226);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medicine Name";
            // 
            // medicineDropComboBox
            // 
            this.medicineDropComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.medicineDropComboBox.DisplayMember = "medicineName";
            this.medicineDropComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicineDropComboBox.FormattingEnabled = true;
            this.medicineDropComboBox.Location = new System.Drawing.Point(124, 6);
            this.medicineDropComboBox.MinimumSize = new System.Drawing.Size(121, 0);
            this.medicineDropComboBox.Name = "medicineDropComboBox";
            this.medicineDropComboBox.Size = new System.Drawing.Size(137, 21);
            this.medicineDropComboBox.TabIndex = 0;
            this.medicineDropComboBox.SelectedIndexChanged += new System.EventHandler(this.medicineDropComboBox_SelectedIndexChanged);
            this.medicineDropComboBox.SelectedValueChanged += new System.EventHandler(this.medicineDropComboBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // txtLimitedStock
            // 
            this.txtLimitedStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLimitedStock.Location = new System.Drawing.Point(328, 40);
            this.txtLimitedStock.Name = "txtLimitedStock";
            this.txtLimitedStock.Size = new System.Drawing.Size(57, 20);
            this.txtLimitedStock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(280, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuantity.Location = new System.Drawing.Point(124, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(57, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // ADD
            // 
            this.ADD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ADD.Location = new System.Drawing.Point(186, 162);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // btnFinalBill
            // 
            this.btnFinalBill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFinalBill.Location = new System.Drawing.Point(267, 162);
            this.btnFinalBill.Name = "btnFinalBill";
            this.btnFinalBill.Size = new System.Drawing.Size(47, 23);
            this.btnFinalBill.TabIndex = 4;
            this.btnFinalBill.Text = "Finalize";
            this.btnFinalBill.UseVisualStyleBackColor = true;
            this.btnFinalBill.Click += new System.EventHandler(this.btnFinalBill_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(75, 86);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(43, 16);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Disc.";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDiscount.Location = new System.Drawing.Point(124, 84);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(57, 20);
            this.txtDiscount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inovice";
            // 
            // txtUserAccount
            // 
            this.txtUserAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserAccount.Location = new System.Drawing.Point(177, 14);
            this.txtUserAccount.Name = "txtUserAccount";
            this.txtUserAccount.Size = new System.Drawing.Size(60, 20);
            this.txtUserAccount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill ID";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(51, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "N/A";
            // 
            // txtBillID
            // 
            this.txtBillID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBillID.Location = new System.Drawing.Point(51, 14);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(51, 20);
            this.txtBillID.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.39007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.60993F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 625F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUserAccount, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBillID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 98);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // userBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(816, 489);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "userBilling";
            this.Text = "userBilling";
            this.Load += new System.EventHandler(this.userBilling_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineListGVD)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView medicineListGVD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox medicineDropComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLimitedStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button btnFinalBill;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}