namespace KiemTraCSDL
{
    partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtKhung = new System.Windows.Forms.TextBox();
			this.txtMay = new System.Windows.Forms.TextBox();
			this.txtMau = new System.Windows.Forms.TextBox();
			this.txtHang = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnMoi = new System.Windows.Forms.Button();
			this.btnTIm = new System.Windows.Forms.Button();
			this.btnXuat = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnAnh = new System.Windows.Forms.Button();
			this.dtgXe = new System.Windows.Forms.DataGridView();
			this.cbDungTich = new System.Windows.Forms.ComboBox();
			this.pbAnh = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgXe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số khung";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số máy";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Màu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Dung tích xi lanh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Hãng xe";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 250);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tên xe";
			// 
			// txtKhung
			// 
			this.txtKhung.Location = new System.Drawing.Point(157, 18);
			this.txtKhung.Name = "txtKhung";
			this.txtKhung.Size = new System.Drawing.Size(241, 22);
			this.txtKhung.TabIndex = 3;
			// 
			// txtMay
			// 
			this.txtMay.Location = new System.Drawing.Point(157, 61);
			this.txtMay.Name = "txtMay";
			this.txtMay.Size = new System.Drawing.Size(241, 22);
			this.txtMay.TabIndex = 3;
			// 
			// txtMau
			// 
			this.txtMau.Location = new System.Drawing.Point(157, 98);
			this.txtMau.Name = "txtMau";
			this.txtMau.Size = new System.Drawing.Size(241, 22);
			this.txtMau.TabIndex = 3;
			// 
			// txtHang
			// 
			this.txtHang.Location = new System.Drawing.Point(157, 189);
			this.txtHang.Name = "txtHang";
			this.txtHang.Size = new System.Drawing.Size(241, 22);
			this.txtHang.TabIndex = 3;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(157, 244);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(241, 22);
			this.txtTen.TabIndex = 3;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(779, 21);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(119, 32);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm vào CSDL";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(779, 64);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(119, 29);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(779, 117);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(119, 28);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnMoi
			// 
			this.btnMoi.Location = new System.Drawing.Point(779, 168);
			this.btnMoi.Name = "btnMoi";
			this.btnMoi.Size = new System.Drawing.Size(119, 29);
			this.btnMoi.TabIndex = 4;
			this.btnMoi.Text = "Làm mới";
			this.btnMoi.UseVisualStyleBackColor = true;
			this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
			// 
			// btnTIm
			// 
			this.btnTIm.Location = new System.Drawing.Point(779, 262);
			this.btnTIm.Name = "btnTIm";
			this.btnTIm.Size = new System.Drawing.Size(119, 30);
			this.btnTIm.TabIndex = 4;
			this.btnTIm.Text = "Tìm";
			this.btnTIm.UseVisualStyleBackColor = true;
			// 
			// btnXuat
			// 
			this.btnXuat.Location = new System.Drawing.Point(779, 216);
			this.btnXuat.Name = "btnXuat";
			this.btnXuat.Size = new System.Drawing.Size(119, 31);
			this.btnXuat.TabIndex = 4;
			this.btnXuat.Text = "Xuất theo hãng";
			this.btnXuat.UseVisualStyleBackColor = true;
			this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(779, 319);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(119, 29);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnAnh
			// 
			this.btnAnh.Location = new System.Drawing.Point(493, 20);
			this.btnAnh.Name = "btnAnh";
			this.btnAnh.Size = new System.Drawing.Size(119, 25);
			this.btnAnh.TabIndex = 4;
			this.btnAnh.Text = "Chọn ảnh xe";
			this.btnAnh.UseVisualStyleBackColor = true;
			this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
			// 
			// dtgXe
			// 
			this.dtgXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgXe.Location = new System.Drawing.Point(27, 294);
			this.dtgXe.Name = "dtgXe";
			this.dtgXe.RowHeadersWidth = 51;
			this.dtgXe.RowTemplate.Height = 24;
			this.dtgXe.Size = new System.Drawing.Size(716, 134);
			this.dtgXe.TabIndex = 5;
			this.dtgXe.Click += new System.EventHandler(this.dtgXe_Click);
			// 
			// cbDungTich
			// 
			this.cbDungTich.FormattingEnabled = true;
			this.cbDungTich.Items.AddRange(new object[] {
            "50",
            "70",
            "100",
            "110",
            "150"});
			this.cbDungTich.Location = new System.Drawing.Point(157, 140);
			this.cbDungTich.Name = "cbDungTich";
			this.cbDungTich.Size = new System.Drawing.Size(189, 24);
			this.cbDungTich.TabIndex = 6;
			// 
			// pbAnh
			// 
			this.pbAnh.Location = new System.Drawing.Point(493, 69);
			this.pbAnh.Name = "pbAnh";
			this.pbAnh.Size = new System.Drawing.Size(153, 142);
			this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAnh.TabIndex = 7;
			this.pbAnh.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 450);
			this.Controls.Add(this.pbAnh);
			this.Controls.Add(this.cbDungTich);
			this.Controls.Add(this.dtgXe);
			this.Controls.Add(this.btnAnh);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXuat);
			this.Controls.Add(this.btnTIm);
			this.Controls.Add(this.btnMoi);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtHang);
			this.Controls.Add(this.txtMau);
			this.Controls.Add(this.txtMay);
			this.Controls.Add(this.txtKhung);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgXe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKhung;
        private System.Windows.Forms.TextBox txtMay;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnTIm;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.DataGridView dtgXe;
        private System.Windows.Forms.ComboBox cbDungTich;
        private System.Windows.Forms.PictureBox pbAnh;
    }
}

