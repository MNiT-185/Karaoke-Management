namespace QuanLyQuanKaraoke
{
    partial class fStatitis
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
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvStatitis = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.txbNumberPage = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatitis)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(435, 16);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(235, 20);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(14, 16);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(237, 20);
            this.dtpFromDate.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(291, 16);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 28);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 490);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbNumberPage);
            this.panel3.Controls.Add(this.btnAfter);
            this.panel3.Controls.Add(this.btnBefore);
            this.panel3.Controls.Add(this.btnLastPage);
            this.panel3.Controls.Add(this.btnFirstPage);
            this.panel3.Controls.Add(this.dtgvStatitis);
            this.panel3.Location = new System.Drawing.Point(4, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 425);
            this.panel3.TabIndex = 4;
            // 
            // dtgvStatitis
            // 
            this.dtgvStatitis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStatitis.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvStatitis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatitis.Location = new System.Drawing.Point(0, 0);
            this.dtgvStatitis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvStatitis.Name = "dtgvStatitis";
            this.dtgvStatitis.RowTemplate.Height = 24;
            this.dtgvStatitis.Size = new System.Drawing.Size(681, 385);
            this.dtgvStatitis.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.dtpToDate);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 54);
            this.panel2.TabIndex = 3;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(3, 390);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(86, 32);
            this.btnFirstPage.TabIndex = 1;
            this.btnFirstPage.Text = "Đầu";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(95, 390);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(86, 32);
            this.btnLastPage.TabIndex = 2;
            this.btnLastPage.Text = "Cuối";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(492, 390);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(86, 32);
            this.btnBefore.TabIndex = 3;
            this.btnBefore.Text = "Trước";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.Location = new System.Drawing.Point(584, 390);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(86, 32);
            this.btnAfter.TabIndex = 4;
            this.btnAfter.Text = "Sau";
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // txbNumberPage
            // 
            this.txbNumberPage.Enabled = false;
            this.txbNumberPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberPage.Location = new System.Drawing.Point(302, 392);
            this.txbNumberPage.Name = "txbNumberPage";
            this.txbNumberPage.Size = new System.Drawing.Size(80, 26);
            this.txbNumberPage.TabIndex = 5;
            this.txbNumberPage.Text = "1";
            this.txbNumberPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNumberPage.TextChanged += new System.EventHandler(this.txbNumberPage_TextChanged);
            // 
            // fStatitis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 507);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fStatitis";
            this.Text = "Thống kê";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatitis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvStatitis;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.MaskedTextBox txbNumberPage;
    }
}