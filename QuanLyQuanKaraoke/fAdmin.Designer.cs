namespace QuanLyQuanKaraoke
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tPFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRepair = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbIdFood = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbNameFood = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearchFood = new System.Windows.Forms.MaskedTextBox();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnRepairCategory = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbNameCategory = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbIdCategory = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRetype = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txbAccountType = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txbAccountDisplay = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbAccountUser = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnRepairAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tcAdmin.SuspendLayout();
            this.tPFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.tpAccount.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel28.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tPFood);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(11, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(782, 523);
            this.tcAdmin.TabIndex = 0;
            // 
            // tPFood
            // 
            this.tPFood.Controls.Add(this.panel6);
            this.tPFood.Controls.Add(this.panel5);
            this.tPFood.Controls.Add(this.panel4);
            this.tPFood.Location = new System.Drawing.Point(4, 22);
            this.tPFood.Name = "tPFood";
            this.tPFood.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tPFood.Size = new System.Drawing.Size(774, 497);
            this.tPFood.TabIndex = 2;
            this.tPFood.Text = "Thức ăn";
            this.tPFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnViewFood);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.btnRepair);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Location = new System.Drawing.Point(383, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(372, 413);
            this.panel6.TabIndex = 3;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFood.Location = new System.Drawing.Point(268, 327);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(78, 53);
            this.btnViewFood.TabIndex = 4;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nudPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(7, 238);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(362, 67);
            this.panel10.TabIndex = 7;
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.Location = new System.Drawing.Point(103, 9);
            this.nudPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(236, 26);
            this.nudPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // btnRepair
            // 
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.Location = new System.Drawing.Point(189, 327);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(74, 53);
            this.btnRepair.TabIndex = 3;
            this.btnRepair.Text = "Sửa";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbIdFood);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(7, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(362, 67);
            this.panel7.TabIndex = 6;
            // 
            // txbIdFood
            // 
            this.txbIdFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdFood.Location = new System.Drawing.Point(103, 10);
            this.txbIdFood.Name = "txbIdFood";
            this.txbIdFood.ReadOnly = true;
            this.txbIdFood.Size = new System.Drawing.Size(236, 26);
            this.txbIdFood.TabIndex = 1;
            this.txbIdFood.TextChanged += new System.EventHandler(this.txbIdFood_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbNameFood);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(7, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(362, 67);
            this.panel8.TabIndex = 7;
            // 
            // txbNameFood
            // 
            this.txbNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameFood.Location = new System.Drawing.Point(103, 10);
            this.txbNameFood.Name = "txbNameFood";
            this.txbNameFood.Size = new System.Drawing.Size(236, 26);
            this.txbNameFood.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(7, 165);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(362, 67);
            this.panel9.TabIndex = 7;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(101, 10);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(235, 26);
            this.cbCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(108, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvFood);
            this.panel5.Location = new System.Drawing.Point(7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 475);
            this.panel5.TabIndex = 2;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(2, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(367, 477);
            this.dtgvFood.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txbSearchFood);
            this.panel4.Location = new System.Drawing.Point(383, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 56);
            this.panel4.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 42);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearchFood
            // 
            this.txbSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchFood.Location = new System.Drawing.Point(15, 10);
            this.txbSearchFood.Name = "txbSearchFood";
            this.txbSearchFood.Size = new System.Drawing.Size(248, 26);
            this.txbSearchFood.TabIndex = 0;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.panel11);
            this.tpCategory.Controls.Add(this.panel16);
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpCategory.Size = new System.Drawing.Size(774, 497);
            this.tpCategory.TabIndex = 5;
            this.tpCategory.Text = "Danh mục";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnViewCategory);
            this.panel11.Controls.Add(this.btnRepairCategory);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.btnDeleteCategory);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Controls.Add(this.btnAddCategory);
            this.panel11.Location = new System.Drawing.Point(9, 311);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(759, 186);
            this.panel11.TabIndex = 3;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategory.Location = new System.Drawing.Point(459, 105);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(102, 53);
            this.btnViewCategory.TabIndex = 4;
            this.btnViewCategory.Text = "Xem";
            this.btnViewCategory.UseVisualStyleBackColor = true;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnRepairCategory
            // 
            this.btnRepairCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairCategory.Location = new System.Drawing.Point(584, 105);
            this.btnRepairCategory.Name = "btnRepairCategory";
            this.btnRepairCategory.Size = new System.Drawing.Size(102, 53);
            this.btnRepairCategory.TabIndex = 3;
            this.btnRepairCategory.Text = "Sửa";
            this.btnRepairCategory.UseVisualStyleBackColor = true;
            this.btnRepairCategory.Click += new System.EventHandler(this.btnRepairCategory_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txbNameCategory);
            this.panel14.Controls.Add(this.label7);
            this.panel14.Location = new System.Drawing.Point(10, 114);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(362, 66);
            this.panel14.TabIndex = 7;
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameCategory.Location = new System.Drawing.Point(103, 10);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(236, 29);
            this.txbNameCategory.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(584, 29);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(102, 53);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbIdCategory);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Location = new System.Drawing.Point(10, 29);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(362, 70);
            this.panel15.TabIndex = 6;
            // 
            // txbIdCategory
            // 
            this.txbIdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdCategory.Location = new System.Drawing.Point(103, 14);
            this.txbIdCategory.Name = "txbIdCategory";
            this.txbIdCategory.ReadOnly = true;
            this.txbIdCategory.Size = new System.Drawing.Size(236, 29);
            this.txbIdCategory.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(459, 29);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(102, 53);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dtgvCategory);
            this.panel16.Location = new System.Drawing.Point(7, 6);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(761, 302);
            this.panel16.TabIndex = 2;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(2, 0);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(759, 299);
            this.dtgvCategory.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel23);
            this.tpAccount.Controls.Add(this.panel27);
            this.tpAccount.Controls.Add(this.panel28);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpAccount.Size = new System.Drawing.Size(774, 497);
            this.tpAccount.TabIndex = 8;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.button1);
            this.panel23.Controls.Add(this.btnRetype);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Location = new System.Drawing.Point(426, 139);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(342, 344);
            this.panel23.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sắp có";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRetype
            // 
            this.btnRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetype.Location = new System.Drawing.Point(215, 249);
            this.btnRetype.Name = "btnRetype";
            this.btnRetype.Size = new System.Drawing.Size(113, 52);
            this.btnRetype.TabIndex = 9;
            this.btnRetype.Text = "Đặt lại mật khẩu";
            this.btnRetype.UseVisualStyleBackColor = true;
            this.btnRetype.Click += new System.EventHandler(this.btnRetype_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txbAccountType);
            this.panel24.Controls.Add(this.label10);
            this.panel24.Location = new System.Drawing.Point(12, 157);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(323, 71);
            this.panel24.TabIndex = 8;
            // 
            // txbAccountType
            // 
            this.txbAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountType.Location = new System.Drawing.Point(51, 39);
            this.txbAccountType.Name = "txbAccountType";
            this.txbAccountType.Size = new System.Drawing.Size(230, 29);
            this.txbAccountType.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txbAccountDisplay);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(12, 80);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(323, 71);
            this.panel25.TabIndex = 7;
            // 
            // txbAccountDisplay
            // 
            this.txbAccountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountDisplay.Location = new System.Drawing.Point(53, 39);
            this.txbAccountDisplay.Name = "txbAccountDisplay";
            this.txbAccountDisplay.Size = new System.Drawing.Size(230, 29);
            this.txbAccountDisplay.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hiển thị";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbAccountUser);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(12, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(323, 71);
            this.panel26.TabIndex = 6;
            // 
            // txbAccountUser
            // 
            this.txbAccountUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountUser.Location = new System.Drawing.Point(53, 39);
            this.txbAccountUser.Name = "txbAccountUser";
            this.txbAccountUser.Size = new System.Drawing.Size(230, 29);
            this.txbAccountUser.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tài khoản";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.dtgvAccount);
            this.panel27.Location = new System.Drawing.Point(7, 6);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(413, 475);
            this.panel27.TabIndex = 2;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 0);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(408, 477);
            this.dtgvAccount.TabIndex = 0;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnViewAccount);
            this.panel28.Controls.Add(this.btnRepairAccount);
            this.panel28.Controls.Add(this.btnDeleteAccount);
            this.panel28.Controls.Add(this.btnAddAccount);
            this.panel28.Location = new System.Drawing.Point(444, 6);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(310, 127);
            this.panel28.TabIndex = 0;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccount.Location = new System.Drawing.Point(171, 63);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(75, 42);
            this.btnViewAccount.TabIndex = 4;
            this.btnViewAccount.Text = "Xem";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnRepairAccount
            // 
            this.btnRepairAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairAccount.Location = new System.Drawing.Point(171, 3);
            this.btnRepairAccount.Name = "btnRepairAccount";
            this.btnRepairAccount.Size = new System.Drawing.Size(75, 42);
            this.btnRepairAccount.TabIndex = 3;
            this.btnRepairAccount.Text = "Sửa";
            this.btnRepairAccount.UseVisualStyleBackColor = true;
            this.btnRepairAccount.Click += new System.EventHandler(this.btnRepairAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(53, 63);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(53, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 42);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 544);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.tcAdmin.ResumeLayout(false);
            this.tPFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpCategory.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.tpAccount.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel28.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tPFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MaskedTextBox txbSearchFood;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox txbIdFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox txbNameFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.MaskedTextBox txbNameCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.MaskedTextBox txbIdCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnRepairCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.MaskedTextBox txbAccountDisplay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.MaskedTextBox txbAccountUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnRepairAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnRetype;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.MaskedTextBox txbAccountType;
        private System.Windows.Forms.Button button1;
    }
}