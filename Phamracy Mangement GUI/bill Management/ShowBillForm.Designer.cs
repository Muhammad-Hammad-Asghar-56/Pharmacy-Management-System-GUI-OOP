
namespace Phamracy_Mangement_GUI.bill_Management
{
    partial class ShowBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBillForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcutalBill = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblbiller = new System.Windows.Forms.Label();
            this.txtBiller = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowBIlGVD = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBIlGVD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.93498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Controls.Add(this.lblBillNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInvoiceNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAcutalBill, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPay, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblbiller, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBiller, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 361);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.Location = new System.Drawing.Point(18, 29);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(58, 13);
            this.lblBillNumber.TabIndex = 0;
            this.lblBillNumber.Text = "Inovoice #";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInvoiceNo.Location = new System.Drawing.Point(82, 26);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(58, 20);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Actual Bill";
            // 
            // txtAcutalBill
            // 
            this.txtAcutalBill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAcutalBill.Location = new System.Drawing.Point(82, 98);
            this.txtAcutalBill.Name = "txtAcutalBill";
            this.txtAcutalBill.ReadOnly = true;
            this.txtAcutalBill.Size = new System.Drawing.Size(58, 20);
            this.txtAcutalBill.TabIndex = 9;
            // 
            // txtPay
            // 
            this.txtPay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPay.Location = new System.Drawing.Point(82, 242);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(58, 20);
            this.txtPay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pay";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDiscount.Location = new System.Drawing.Point(82, 170);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(58, 20);
            this.txtDiscount.TabIndex = 7;
            // 
            // lblbiller
            // 
            this.lblbiller.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblbiller.AutoSize = true;
            this.lblbiller.Location = new System.Drawing.Point(195, 29);
            this.lblbiller.Name = "lblbiller";
            this.lblbiller.Size = new System.Drawing.Size(29, 13);
            this.lblbiller.TabIndex = 4;
            this.lblbiller.Text = "Biller";
            // 
            // txtBiller
            // 
            this.txtBiller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBiller.Location = new System.Drawing.Point(230, 26);
            this.txtBiller.Name = "txtBiller";
            this.txtBiller.ReadOnly = true;
            this.txtBiller.Size = new System.Drawing.Size(58, 20);
            this.txtBiller.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(169, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ShowBIlGVD, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(322, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 361);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ShowBIlGVD
            // 
            this.ShowBIlGVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowBIlGVD.Location = new System.Drawing.Point(3, 3);
            this.ShowBIlGVD.Name = "ShowBIlGVD";
            this.ShowBIlGVD.Size = new System.Drawing.Size(256, 148);
            this.ShowBIlGVD.TabIndex = 0;
            // 
            // ShowBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ShowBillForm";
            this.Text = "Show Bill";
            this.Load += new System.EventHandler(this.ShowBillForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowBIlGVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblbiller;
        private System.Windows.Forms.TextBox txtBiller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtAcutalBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView ShowBIlGVD;
    }
}