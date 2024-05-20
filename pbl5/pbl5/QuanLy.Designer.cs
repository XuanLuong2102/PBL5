namespace pbl5
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.lbLogOut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbDoiMK = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.lkAddTK = new System.Windows.Forms.LinkLabel();
            this.lkCheck = new System.Windows.Forms.LinkLabel();
            this.lkInfor = new System.Windows.Forms.LinkLabel();
            this.LkDSUser = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llbCheckk = new System.Windows.Forms.LinkLabel();
            this.lbErr = new System.Windows.Forms.Label();
            this.llbXoaTK = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.llbDsViPham = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống quản lý ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(472, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người dùng : ";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAdmin.Location = new System.Drawing.Point(570, 14);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(54, 19);
            this.lbAdmin.TabIndex = 2;
            this.lbAdmin.Text = "Admin";
            // 
            // lbLogOut
            // 
            this.lbLogOut.AutoSize = true;
            this.lbLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLogOut.ForeColor = System.Drawing.Color.Navy;
            this.lbLogOut.Location = new System.Drawing.Point(674, 14);
            this.lbLogOut.Name = "lbLogOut";
            this.lbLogOut.Size = new System.Drawing.Size(78, 19);
            this.lbLogOut.TabIndex = 3;
            this.lbLogOut.Text = "Đăng xuất";
            this.lbLogOut.Click += new System.EventHandler(this.lbLogOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.llbDsViPham);
            this.groupBox1.Controls.Add(this.llbDoiMK);
            this.groupBox1.Controls.Add(this.llbDelete);
            this.groupBox1.Controls.Add(this.lkAddTK);
            this.groupBox1.Controls.Add(this.lkCheck);
            this.groupBox1.Controls.Add(this.lkInfor);
            this.groupBox1.Controls.Add(this.LkDSUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 340);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // llbDoiMK
            // 
            this.llbDoiMK.AutoSize = true;
            this.llbDoiMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbDoiMK.Location = new System.Drawing.Point(6, 282);
            this.llbDoiMK.Name = "llbDoiMK";
            this.llbDoiMK.Size = new System.Drawing.Size(94, 19);
            this.llbDoiMK.TabIndex = 5;
            this.llbDoiMK.TabStop = true;
            this.llbDoiMK.Text = "Đổi mật khẩu ";
            this.llbDoiMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDoiMK_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbDelete.Location = new System.Drawing.Point(6, 236);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(94, 19);
            this.llbDelete.TabIndex = 4;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "Xóa tài khoản";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // lkAddTK
            // 
            this.lkAddTK.AutoSize = true;
            this.lkAddTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkAddTK.Location = new System.Drawing.Point(7, 193);
            this.lkAddTK.Name = "lkAddTK";
            this.lkAddTK.Size = new System.Drawing.Size(102, 19);
            this.lkAddTK.TabIndex = 3;
            this.lkAddTK.TabStop = true;
            this.lkAddTK.Text = "Thêm tài khoản";
            this.lkAddTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkAddTK_LinkClicked);
            // 
            // lkCheck
            // 
            this.lkCheck.AutoSize = true;
            this.lkCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkCheck.Location = new System.Drawing.Point(6, 151);
            this.lkCheck.Name = "lkCheck";
            this.lkCheck.Size = new System.Drawing.Size(131, 19);
            this.lkCheck.TabIndex = 2;
            this.lkCheck.TabStop = true;
            this.lkCheck.Text = "Kiểm tra lỗi vi phạm";
            this.lkCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkCheck_LinkClicked);
            // 
            // lkInfor
            // 
            this.lkInfor.AutoSize = true;
            this.lkInfor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkInfor.Location = new System.Drawing.Point(6, 62);
            this.lkInfor.Name = "lkInfor";
            this.lkInfor.Size = new System.Drawing.Size(125, 19);
            this.lkInfor.TabIndex = 1;
            this.lkInfor.TabStop = true;
            this.lkInfor.Text = "Thông tin nhân viên";
            this.lkInfor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkInfor_LinkClicked);
            // 
            // LkDSUser
            // 
            this.LkDSUser.AutoSize = true;
            this.LkDSUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LkDSUser.Location = new System.Drawing.Point(6, 16);
            this.LkDSUser.Name = "LkDSUser";
            this.LkDSUser.Size = new System.Drawing.Size(132, 19);
            this.LkDSUser.TabIndex = 0;
            this.LkDSUser.TabStop = true;
            this.LkDSUser.Text = "Danh sách nhân viên";
            this.LkDSUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkDSUser_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 345);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.llbCheckk);
            this.groupBox2.Controls.Add(this.lbErr);
            this.groupBox2.Controls.Add(this.llbXoaTK);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbSDT);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lbCCCD);
            this.groupBox2.Controls.Add(this.lbID);
            this.groupBox2.Controls.Add(this.lbGioiTinh);
            this.groupBox2.Controls.Add(this.lbDiaChi);
            this.groupBox2.Controls.Add(this.lbDate);
            this.groupBox2.Controls.Add(this.lbTen);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(179, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 345);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // llbCheckk
            // 
            this.llbCheckk.AutoSize = true;
            this.llbCheckk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbCheckk.Location = new System.Drawing.Point(259, 310);
            this.llbCheckk.Name = "llbCheckk";
            this.llbCheckk.Size = new System.Drawing.Size(177, 19);
            this.llbCheckk.TabIndex = 6;
            this.llbCheckk.TabStop = true;
            this.llbCheckk.Text = "Kiểm vi phạm tài khoản này";
            this.llbCheckk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCheckk_LinkClicked);
            // 
            // lbErr
            // 
            this.lbErr.AutoSize = true;
            this.lbErr.BackColor = System.Drawing.SystemColors.Control;
            this.lbErr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbErr.Location = new System.Drawing.Point(186, 104);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(155, 19);
            this.lbErr.TabIndex = 72;
            this.lbErr.Text = "Không tìm thấy kết quả!";
            // 
            // llbXoaTK
            // 
            this.llbXoaTK.AutoSize = true;
            this.llbXoaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbXoaTK.Location = new System.Drawing.Point(88, 310);
            this.llbXoaTK.Name = "llbXoaTK";
            this.llbXoaTK.Size = new System.Drawing.Size(119, 19);
            this.llbXoaTK.TabIndex = 52;
            this.llbXoaTK.TabStop = true;
            this.llbXoaTK.Text = "Xóa tài khoản này";
            this.llbXoaTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbXoaTK_LinkClicked_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(325, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 30);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(207, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 26);
            this.txtSearch.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(165, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "ID : ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.BackColor = System.Drawing.SystemColors.Control;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDT.Location = new System.Drawing.Point(387, 257);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(16, 19);
            this.lbSDT.TabIndex = 68;
            this.lbSDT.Text = "a";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmail.Location = new System.Drawing.Point(387, 182);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(16, 19);
            this.lbEmail.TabIndex = 67;
            this.lbEmail.Text = "a";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.BackColor = System.Drawing.SystemColors.Control;
            this.lbCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCCCD.Location = new System.Drawing.Point(387, 113);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(16, 19);
            this.lbCCCD.TabIndex = 66;
            this.lbCCCD.Text = "a";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.SystemColors.Control;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.Location = new System.Drawing.Point(387, 46);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(16, 19);
            this.lbID.TabIndex = 65;
            this.lbID.Text = "a";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.BackColor = System.Drawing.SystemColors.Control;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.Location = new System.Drawing.Point(170, 257);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(16, 19);
            this.lbGioiTinh.TabIndex = 64;
            this.lbGioiTinh.Text = "a";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.BackColor = System.Drawing.SystemColors.Control;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(170, 182);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(16, 19);
            this.lbDiaChi.TabIndex = 63;
            this.lbDiaChi.Text = "a";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDate.Location = new System.Drawing.Point(170, 113);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(16, 19);
            this.lbDate.TabIndex = 62;
            this.lbDate.Text = "a";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.SystemColors.Control;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.Location = new System.Drawing.Point(170, 46);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(16, 19);
            this.lbTen.TabIndex = 61;
            this.lbTen.Text = "a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(325, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 60;
            this.label10.Text = "SĐT : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(88, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(321, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "Email : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(88, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(321, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "CCCD : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(88, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ngày sinh :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(321, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(88, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Họ tên : ";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(772, 179);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // llbDsViPham
            // 
            this.llbDsViPham.AutoSize = true;
            this.llbDsViPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbDsViPham.Location = new System.Drawing.Point(6, 108);
            this.llbDsViPham.Name = "llbDsViPham";
            this.llbDsViPham.Size = new System.Drawing.Size(145, 19);
            this.llbDsViPham.TabIndex = 6;
            this.llbDsViPham.TabStop = true;
            this.llbDsViPham.Text = " Danh sách lỗi vi phạm";
            this.llbDsViPham.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbLogOut);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLy";
            this.Text = "Hệ thống quản lý ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLy_FormClosing);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.Label lbLogOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lkAddTK;
        private System.Windows.Forms.LinkLabel lkCheck;
        private System.Windows.Forms.LinkLabel lkInfor;
        private System.Windows.Forms.LinkLabel LkDSUser;
        private System.Windows.Forms.LinkLabel llbDoiMK;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbErr;
        private System.Windows.Forms.LinkLabel llbXoaTK;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbCheckk;
        private System.Windows.Forms.LinkLabel llbDsViPham;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}