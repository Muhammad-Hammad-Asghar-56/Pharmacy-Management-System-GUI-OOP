
namespace Phamracy_Mangement_GUI.bill_Management
{
    partial class billSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxIsMedineName = new System.Windows.Forms.CheckBox();
            this.checkBoxIsBiller = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 91);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Name";
            // 
            // checkBoxIsMedineName
            // 
            this.checkBoxIsMedineName.AutoSize = true;
            this.checkBoxIsMedineName.Location = new System.Drawing.Point(92, 193);
            this.checkBoxIsMedineName.Name = "checkBoxIsMedineName";
            this.checkBoxIsMedineName.Size = new System.Drawing.Size(69, 17);
            this.checkBoxIsMedineName.TabIndex = 4;
            this.checkBoxIsMedineName.Text = "Medicine";
            this.checkBoxIsMedineName.UseVisualStyleBackColor = true;
            this.checkBoxIsMedineName.CheckedChanged += new System.EventHandler(this.checkBoxIsMedineName_CheckedChanged);
            // 
            // checkBoxIsBiller
            // 
            this.checkBoxIsBiller.AutoSize = true;
            this.checkBoxIsBiller.Location = new System.Drawing.Point(171, 193);
            this.checkBoxIsBiller.Name = "checkBoxIsBiller";
            this.checkBoxIsBiller.Size = new System.Drawing.Size(48, 17);
            this.checkBoxIsBiller.TabIndex = 5;
            this.checkBoxIsBiller.Text = "Biller";
            this.checkBoxIsBiller.UseVisualStyleBackColor = true;
            this.checkBoxIsBiller.CheckedChanged += new System.EventHandler(this.checkBoxIsBiller_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 448);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(140, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(92, 151);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(127, 20);
            this.txtInput.TabIndex = 3;
            // 
            // billSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxIsBiller);
            this.Controls.Add(this.checkBoxIsMedineName);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(765, 489);
            this.MinimumSize = new System.Drawing.Size(765, 489);
            this.Name = "billSearchForm";
            this.Text = "Search Bill";
            this.Load += new System.EventHandler(this.billSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxIsMedineName;
        private System.Windows.Forms.CheckBox checkBoxIsBiller;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInput;
    }
}