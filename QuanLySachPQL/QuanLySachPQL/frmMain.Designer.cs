namespace QuanLySachPQL
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnNCC = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.btnNV = new FontAwesome.Sharp.IconButton();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMaxWin = new FontAwesome.Sharp.IconButton();
            this.btnMinWin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.menuSP = new QuanLySachPQL.LongDropdownMenu(this.components);
            this.menuLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSPChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.menuSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.btnHoaDon);
            this.pnlMenu.Controls.Add(this.btnNCC);
            this.pnlMenu.Controls.Add(this.btnSanPham);
            this.pnlMenu.Controls.Add(this.btnNV);
            this.pnlMenu.Controls.Add(this.pnlAvatar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 744);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("UTM American Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnThongKe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 452);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(220, 60);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("UTM American Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnHoaDon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 392);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(220, 60);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("UTM American Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.IconChar = FontAwesome.Sharp.IconChar.CarBattery;
            this.btnNCC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(0, 332);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNCC.Size = new System.Drawing.Size(220, 60);
            this.btnNCC.TabIndex = 3;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("UTM American Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnSanPham.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 272);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSanPham.Size = new System.Drawing.Size(220, 60);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNV
            // 
            this.btnNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNV.FlatAppearance.BorderSize = 0;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.Font = new System.Drawing.Font("UTM American Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.ForeColor = System.Drawing.Color.White;
            this.btnNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNV.Location = new System.Drawing.Point(0, 212);
            this.btnNV.Name = "btnNV";
            this.btnNV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNV.Size = new System.Drawing.Size(220, 60);
            this.btnNV.TabIndex = 1;
            this.btnNV.Text = "Nhân Viên";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Controls.Add(this.btnHome);
            this.pnlAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvatar.Location = new System.Drawing.Point(0, 0);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(220, 212);
            this.pnlAvatar.TabIndex = 0;
            this.pnlAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlAvatar_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(26, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 135);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.pnlTitleBar.Controls.Add(this.btnMaxWin);
            this.pnlTitleBar.Controls.Add(this.btnMinWin);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitleChildForm);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1571, 124);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMaxWin
            // 
            this.btnMaxWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxWin.FlatAppearance.BorderSize = 0;
            this.btnMaxWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxWin.ForeColor = System.Drawing.Color.White;
            this.btnMaxWin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxWin.IconColor = System.Drawing.Color.Green;
            this.btnMaxWin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxWin.IconSize = 24;
            this.btnMaxWin.Location = new System.Drawing.Point(1514, 0);
            this.btnMaxWin.Name = "btnMaxWin";
            this.btnMaxWin.Size = new System.Drawing.Size(24, 24);
            this.btnMaxWin.TabIndex = 4;
            this.btnMaxWin.UseVisualStyleBackColor = true;
            this.btnMaxWin.Click += new System.EventHandler(this.btnMaxWin_Click);
            // 
            // btnMinWin
            // 
            this.btnMinWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinWin.FlatAppearance.BorderSize = 0;
            this.btnMinWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinWin.ForeColor = System.Drawing.Color.White;
            this.btnMinWin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinWin.IconColor = System.Drawing.Color.Yellow;
            this.btnMinWin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinWin.IconSize = 24;
            this.btnMinWin.Location = new System.Drawing.Point(1484, -2);
            this.btnMinWin.Name = "btnMinWin";
            this.btnMinWin.Size = new System.Drawing.Size(24, 24);
            this.btnMinWin.TabIndex = 3;
            this.btnMinWin.UseVisualStyleBackColor = true;
            this.btnMinWin.Click += new System.EventHandler(this.btnMinWin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 24;
            this.btnClose.Location = new System.Drawing.Point(1544, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Font = new System.Drawing.Font("UTM American Sans", 12F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(96, 39);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(195, 45);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 53;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(37, 39);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(53, 59);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(220, 124);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1571, 620);
            this.pnlForm.TabIndex = 2;
            // 
            // menuSP
            // 
            this.menuSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.menuSP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSP.IsMainMenu = false;
            this.menuSP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoaiSach,
            this.menuSach,
            this.toolStripMenuItem1,
            this.menuSPChiTiet});
            this.menuSP.MenuItemHeight = 25;
            this.menuSP.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuSP.Name = "longDropdownMenu1";
            this.menuSP.PrimaryColor = System.Drawing.Color.Empty;
            this.menuSP.Size = new System.Drawing.Size(218, 164);
            // 
            // menuLoaiSach
            // 
            this.menuLoaiSach.AutoSize = false;
            this.menuLoaiSach.Font = new System.Drawing.Font("UTM American Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLoaiSach.ForeColor = System.Drawing.Color.White;
            this.menuLoaiSach.Name = "menuLoaiSach";
            this.menuLoaiSach.Padding = new System.Windows.Forms.Padding(20, 1, 0, 1);
            this.menuLoaiSach.Size = new System.Drawing.Size(220, 40);
            this.menuLoaiSach.Text = "Loại Sách";
            this.menuLoaiSach.Click += new System.EventHandler(this.menuLoaiSach_Click);
            // 
            // menuSach
            // 
            this.menuSach.AutoSize = false;
            this.menuSach.Font = new System.Drawing.Font("UTM American Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSach.ForeColor = System.Drawing.Color.White;
            this.menuSach.Name = "menuSach";
            this.menuSach.Padding = new System.Windows.Forms.Padding(20, 1, 0, 1);
            this.menuSach.Size = new System.Drawing.Size(220, 40);
            this.menuSach.Text = "Sách";
            this.menuSach.Click += new System.EventHandler(this.menuSach_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("UTM American Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(20, 1, 0, 1);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 40);
            this.toolStripMenuItem1.Text = "Chi Tiết Sách";
            // 
            // menuSPChiTiet
            // 
            this.menuSPChiTiet.AutoSize = false;
            this.menuSPChiTiet.Font = new System.Drawing.Font("UTM American Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSPChiTiet.ForeColor = System.Drawing.Color.White;
            this.menuSPChiTiet.Name = "menuSPChiTiet";
            this.menuSPChiTiet.Padding = new System.Windows.Forms.Padding(20, 1, 0, 1);
            this.menuSPChiTiet.Size = new System.Drawing.Size(220, 40);
            this.menuSPChiTiet.Text = "Lịch Sử Xóa Sách";
            this.menuSPChiTiet.Click += new System.EventHandler(this.menuSPChiTiet_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 744);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.menuSP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnNCC;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnNV;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaxWin;
        private FontAwesome.Sharp.IconButton btnMinWin;
        private System.Windows.Forms.Panel pnlForm;
        private LongDropdownMenu menuSP;
        private System.Windows.Forms.ToolStripMenuItem menuSach;
        private System.Windows.Forms.ToolStripMenuItem menuLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem menuSPChiTiet;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

