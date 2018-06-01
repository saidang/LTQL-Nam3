namespace QLCHGAGMIX
{
    partial class frm_NhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Nu = new System.Windows.Forms.RadioButton();
            this.Nam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.SMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGioiTinh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Nu);
            this.groupBox1.Controls.Add(this.Nam);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "(*) trường dữ liệu không được bỏ trống";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Image = global::QLCHGAGMIX.Properties.Resources.refresh;
            this.button2.Location = new System.Drawing.Point(562, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "TRỞ LẠI";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Chocolate;
            this.btnsua.Image = global::QLCHGAGMIX.Properties.Resources.edit161;
            this.btnsua.Location = new System.Drawing.Point(562, 103);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(124, 34);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "SỬA";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Chocolate;
            this.btnXoa.Image = global::QLCHGAGMIX.Properties.Resources.delete16;
            this.btnXoa.Location = new System.Drawing.Point(562, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 36);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Chocolate;
            this.btnthem.Image = global::QLCHGAGMIX.Properties.Resources.addmanager32;
            this.btnthem.Location = new System.Drawing.Point(562, 24);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(124, 35);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "THÊM";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(379, 135);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(145, 24);
            this.txtChucVu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chức Vụ:(*)";
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Location = new System.Drawing.Point(196, 68);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(45, 22);
            this.Nu.TabIndex = 4;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(127, 66);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(58, 22);
            this.Nam.TabIndex = 3;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(127, 135);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(140, 24);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Sinh:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(379, 64);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(145, 24);
            this.txtDienThoai.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điện Thoại:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(379, 26);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(145, 24);
            this.txtTenNV.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(128, 100);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(396, 24);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ:(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(127, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(123, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:(*)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Thông Tin Nhân Vien";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Image = global::QLCHGAGMIX.Properties.Resources.view16;
            this.button1.Location = new System.Drawing.Point(485, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(259, 18);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(156, 22);
            this.txtTim.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = global::QLCHGAGMIX.Properties.Resources.user16;
            this.label10.Location = new System.Drawing.Point(146, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Nhân Vien:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AllowUserToAddRows = false;
            this.dataGridViewNV.AllowUserToDeleteRows = false;
            this.dataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SMaNV,
            this.STenNV,
            this.SChucVu,
            this.SGioiTinh1,
            this.SDiaChi,
            this.SDienThoai,
            this.SNgaySinh});
            this.dataGridViewNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewNV.Location = new System.Drawing.Point(0, 303);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.RowHeadersVisible = false;
            this.dataGridViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNV.Size = new System.Drawing.Size(716, 150);
            this.dataGridViewNV.TabIndex = 2;
            this.dataGridViewNV.Click += new System.EventHandler(this.dataGridViewNV_Click);
            // 
            // SMaNV
            // 
            this.SMaNV.DataPropertyName = "SMaNV";
            this.SMaNV.HeaderText = "Mã NV";
            this.SMaNV.Name = "SMaNV";
            this.SMaNV.ReadOnly = true;
            // 
            // STenNV
            // 
            this.STenNV.DataPropertyName = "STenNV";
            this.STenNV.HeaderText = "Tên NV";
            this.STenNV.Name = "STenNV";
            this.STenNV.ReadOnly = true;
            // 
            // SChucVu
            // 
            this.SChucVu.DataPropertyName = "SChucVu";
            this.SChucVu.HeaderText = "Chức Vụ";
            this.SChucVu.Name = "SChucVu";
            this.SChucVu.ReadOnly = true;
            // 
            // SGioiTinh1
            // 
            this.SGioiTinh1.DataPropertyName = "SGioiTinh1";
            this.SGioiTinh1.HeaderText = "Giới Tính";
            this.SGioiTinh1.Name = "SGioiTinh1";
            this.SGioiTinh1.ReadOnly = true;
            // 
            // SDiaChi
            // 
            this.SDiaChi.DataPropertyName = "SDiaChi";
            this.SDiaChi.HeaderText = "Địa Chỉ";
            this.SDiaChi.Name = "SDiaChi";
            this.SDiaChi.ReadOnly = true;
            // 
            // SDienThoai
            // 
            this.SDienThoai.DataPropertyName = "SDienThoai";
            this.SDienThoai.HeaderText = "Điện Thoại";
            this.SDienThoai.Name = "SDienThoai";
            this.SDienThoai.ReadOnly = true;
            // 
            // SNgaySinh
            // 
            this.SNgaySinh.DataPropertyName = "SNgaySinh";
            this.SNgaySinh.HeaderText = "Ngày Sinh";
            this.SNgaySinh.Name = "SNgaySinh";
            this.SNgaySinh.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sach NhanVien";
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(716, 453);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Vien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Nu;
        private System.Windows.Forms.RadioButton Nam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGioiTinh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNgaySinh;
    }
}

