namespace QLCHGAGMIX
{
    partial class frm_HoaDonNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cboMANV = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtDaTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSHHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridViewHDNH = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.cb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDNH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.cb);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.Tan;
            this.cb.Controls.Add(this.label9);
            this.cb.Controls.Add(this.btnTroLai);
            this.cb.Controls.Add(this.btnXoa);
            this.cb.Controls.Add(this.btnSua);
            this.cb.Controls.Add(this.btnThem);
            this.cb.Controls.Add(this.progressBar1);
            this.cb.Controls.Add(this.cboMANV);
            this.cb.Controls.Add(this.cboNCC);
            this.cb.Controls.Add(this.txtConNo);
            this.cb.Controls.Add(this.txtDaTra);
            this.cb.Controls.Add(this.label7);
            this.cb.Controls.Add(this.label4);
            this.cb.Controls.Add(this.txtSoTien);
            this.cb.Controls.Add(this.label6);
            this.cb.Controls.Add(this.label3);
            this.cb.Controls.Add(this.label5);
            this.cb.Controls.Add(this.txtSHHD);
            this.cb.Controls.Add(this.label2);
            this.cb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(3, 2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(838, 218);
            this.cb.TabIndex = 0;
            this.cb.TabStop = false;
            this.cb.Enter += new System.EventHandler(this.cb_Enter);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.Peru;
            this.btnTroLai.Image = global::QLCHGAGMIX.Properties.Resources.refresh16;
            this.btnTroLai.Location = new System.Drawing.Point(723, 170);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(106, 32);
            this.btnTroLai.TabIndex = 8;
            this.btnTroLai.Text = "TRỞ LẠI";
            this.btnTroLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Chocolate;
            this.btnXoa.Image = global::QLCHGAGMIX.Properties.Resources.delete16;
            this.btnXoa.Location = new System.Drawing.Point(619, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Peru;
            this.btnSua.Image = global::QLCHGAGMIX.Properties.Resources.edit16;
            this.btnSua.Location = new System.Drawing.Point(505, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 32);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Peru;
            this.btnThem.Image = global::QLCHGAGMIX.Properties.Resources.add16;
            this.btnThem.Location = new System.Drawing.Point(374, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Tan;
            this.progressBar1.Location = new System.Drawing.Point(348, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(487, 53);
            this.progressBar1.TabIndex = 4;
            // 
            // cboMANV
            // 
            this.cboMANV.FormattingEnabled = true;
            this.cboMANV.Location = new System.Drawing.Point(196, 52);
            this.cboMANV.Name = "cboMANV";
            this.cboMANV.Size = new System.Drawing.Size(156, 26);
            this.cboMANV.TabIndex = 3;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(575, 18);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(177, 26);
            this.cboNCC.TabIndex = 2;
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(575, 90);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(177, 24);
            this.txtConNo.TabIndex = 1;
            // 
            // txtDaTra
            // 
            this.txtDaTra.Location = new System.Drawing.Point(196, 84);
            this.txtDaTra.Name = "txtDaTra";
            this.txtDaTra.Size = new System.Drawing.Size(156, 24);
            this.txtDaTra.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "CÒN NỢ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐÃ TRẢ :";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(575, 52);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(177, 24);
            this.txtSoTien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "SỐ TIỀN:(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "MÃ NHÂN VIÊN:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "MÃ NHÀ CUNG CẤP:";
            // 
            // txtSHHD
            // 
            this.txtSHHD.Location = new System.Drawing.Point(196, 24);
            this.txtSHHD.Name = "txtSHHD";
            this.txtSHHD.Size = new System.Drawing.Size(156, 24);
            this.txtSHHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SỐ HIỆU HÓA ĐƠN:(*)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tan;
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(856, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tim Kiếm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(283, 18);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(188, 24);
            this.txtTim.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên Nhân Viên:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Peru;
            this.btnTim.Image = global::QLCHGAGMIX.Properties.Resources.view16;
            this.btnTim.Location = new System.Drawing.Point(572, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 34);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridViewHDNH
            // 
            this.dataGridViewHDNH.AllowUserToAddRows = false;
            this.dataGridViewHDNH.AllowUserToDeleteRows = false;
            this.dataGridViewHDNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDNH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewHDNH.Location = new System.Drawing.Point(0, 314);
            this.dataGridViewHDNH.Name = "dataGridViewHDNH";
            this.dataGridViewHDNH.ReadOnly = true;
            this.dataGridViewHDNH.RowHeadersVisible = false;
            this.dataGridViewHDNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHDNH.Size = new System.Drawing.Size(856, 181);
            this.dataGridViewHDNH.TabIndex = 2;
            this.dataGridViewHDNH.Click += new System.EventHandler(this.dataGridViewHDNH_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 36);
            this.label9.TabIndex = 9;
            this.label9.Text = "(*) Dữ liệu không được bỏ trống\r\nĐơn vị tính (VND)\r\n";
            // 
            // frm_HoaDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewHDNH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HoaDonNhapHang";
            this.Text = "Hóa Đơn Nhập Hàng";
            this.Load += new System.EventHandler(this.frm_HoaDonNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.cb.ResumeLayout(false);
            this.cb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cb;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtDaTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSHHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboMANV;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.DataGridView dataGridViewHDNH;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label9;


    }
}