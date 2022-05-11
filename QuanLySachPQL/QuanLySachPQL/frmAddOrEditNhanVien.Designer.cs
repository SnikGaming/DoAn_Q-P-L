namespace QuanLySachPQL
{
    partial class frmAddOrEditNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.picImageNV = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.txtTenDem = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtcmt = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.masNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoneNV = new FontAwesome.Sharp.IconButton();
            this.btnCloseNV = new FontAwesome.Sharp.IconButton();
            this.lblTenAddOrEditNV = new System.Windows.Forms.Label();
            this.iconPicAdOrEditNV = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicAdOrEditNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ NV:";
            // 
            // picImageNV
            // 
            this.picImageNV.BackColor = System.Drawing.Color.Transparent;
            this.picImageNV.Image = ((System.Drawing.Image)(resources.GetObject("picImageNV.Image")));
            this.picImageNV.Location = new System.Drawing.Point(41, 104);
            this.picImageNV.Name = "picImageNV";
            this.picImageNV.Size = new System.Drawing.Size(124, 140);
            this.picImageNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageNV.TabIndex = 1;
            this.picImageNV.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(187)))), ((int)(((byte)(242)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(190, 154);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(113, 35);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Chọn";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đệm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "CCCD_CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức Vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lương:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày Sinh:";
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(160, 42);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(194, 22);
            this.txtHoNV.TabIndex = 3;
            // 
            // txtTenDem
            // 
            this.txtTenDem.Location = new System.Drawing.Point(160, 76);
            this.txtTenDem.Name = "txtTenDem";
            this.txtTenDem.Size = new System.Drawing.Size(194, 22);
            this.txtTenDem.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(160, 112);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(194, 22);
            this.txtTenNV.TabIndex = 5;
            // 
            // txtcmt
            // 
            this.txtcmt.Location = new System.Drawing.Point(160, 181);
            this.txtcmt.Name = "txtcmt";
            this.txtcmt.Size = new System.Drawing.Size(194, 22);
            this.txtcmt.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(160, 220);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(194, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(160, 294);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(194, 22);
            this.txtLuong.TabIndex = 8;
            // 
            // masNgaySinh
            // 
            this.masNgaySinh.Location = new System.Drawing.Point(160, 331);
            this.masNgaySinh.Mask = "00/00/0000";
            this.masNgaySinh.Name = "masNgaySinh";
            this.masNgaySinh.Size = new System.Drawing.Size(98, 22);
            this.masNgaySinh.TabIndex = 9;
            this.masNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(160, 254);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(194, 24);
            this.cmbChucVu.TabIndex = 10;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(160, 146);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 11;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(232, 146);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 12;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbChucVu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.masNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtcmt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenDem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtHoNV);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 381);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết:";
            // 
            // btnDoneNV
            // 
            this.btnDoneNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnDoneNV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDoneNV.IconColor = System.Drawing.Color.Black;
            this.btnDoneNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoneNV.Location = new System.Drawing.Point(43, 659);
            this.btnDoneNV.Name = "btnDoneNV";
            this.btnDoneNV.Size = new System.Drawing.Size(113, 43);
            this.btnDoneNV.TabIndex = 14;
            this.btnDoneNV.Text = "Xong";
            this.btnDoneNV.UseVisualStyleBackColor = false;
            // 
            // btnCloseNV
            // 
            this.btnCloseNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.btnCloseNV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCloseNV.IconColor = System.Drawing.Color.Black;
            this.btnCloseNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNV.Location = new System.Drawing.Point(284, 659);
            this.btnCloseNV.Name = "btnCloseNV";
            this.btnCloseNV.Size = new System.Drawing.Size(113, 43);
            this.btnCloseNV.TabIndex = 15;
            this.btnCloseNV.Text = "Đóng";
            this.btnCloseNV.UseVisualStyleBackColor = false;
            this.btnCloseNV.Click += new System.EventHandler(this.btnCloseNV_Click);
            // 
            // lblTenAddOrEditNV
            // 
            this.lblTenAddOrEditNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTenAddOrEditNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenAddOrEditNV.ForeColor = System.Drawing.Color.White;
            this.lblTenAddOrEditNV.Location = new System.Drawing.Point(96, 31);
            this.lblTenAddOrEditNV.Name = "lblTenAddOrEditNV";
            this.lblTenAddOrEditNV.Size = new System.Drawing.Size(100, 37);
            this.lblTenAddOrEditNV.TabIndex = 16;
            this.lblTenAddOrEditNV.Text = "NAME";
            this.lblTenAddOrEditNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPicAdOrEditNV
            // 
            this.iconPicAdOrEditNV.BackColor = System.Drawing.Color.Transparent;
            this.iconPicAdOrEditNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPicAdOrEditNV.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.iconPicAdOrEditNV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPicAdOrEditNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicAdOrEditNV.IconSize = 48;
            this.iconPicAdOrEditNV.Location = new System.Drawing.Point(43, 32);
            this.iconPicAdOrEditNV.Name = "iconPicAdOrEditNV";
            this.iconPicAdOrEditNV.Size = new System.Drawing.Size(48, 48);
            this.iconPicAdOrEditNV.TabIndex = 17;
            this.iconPicAdOrEditNV.TabStop = false;
            // 
            // frmAddOrEditNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 721);
            this.Controls.Add(this.iconPicAdOrEditNV);
            this.Controls.Add(this.lblTenAddOrEditNV);
            this.Controls.Add(this.btnCloseNV);
            this.Controls.Add(this.btnDoneNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.picImageNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrEditNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrEditNhanVien";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddOrEditNhanVien_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picImageNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicAdOrEditNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImageNV;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.TextBox txtTenDem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtcmt;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.MaskedTextBox masNgaySinh;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnDoneNV;
        private FontAwesome.Sharp.IconButton btnCloseNV;
        private System.Windows.Forms.Label lblTenAddOrEditNV;
        private FontAwesome.Sharp.IconPictureBox iconPicAdOrEditNV;
    }
}