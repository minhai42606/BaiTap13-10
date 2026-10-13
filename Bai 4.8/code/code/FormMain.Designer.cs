namespace code
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mntDangXuat = new ToolStripMenuItem();
            mntThoat = new ToolStripMenuItem();
            mntQLSinhVien = new ToolStripMenuItem();
            quảnLýSinhViênToolStripMenuItem = new ToolStripMenuItem();
            mntQLSanPham = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            mntCascade = new ToolStripMenuItem();
            mntTileHorizontal = new ToolStripMenuItem();
            mntTileVertical = new ToolStripMenuItem();
            toolStripMain = new ToolStrip();
            btnToolStudent = new ToolStripButton();
            btnToolProduct = new ToolStripButton();
            statusStripMain = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timerSystem = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, mntQLSinhVien, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mntDangXuat, mntThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mntDangXuat
            // 
            mntDangXuat.Name = "mntDangXuat";
            mntDangXuat.Size = new Size(160, 26);
            mntDangXuat.Text = "Đăng xuất";
            // 
            // mntThoat
            // 
            mntThoat.Name = "mntThoat";
            mntThoat.Size = new Size(160, 26);
            mntThoat.Text = "Thoát";
            // 
            // mntQLSinhVien
            // 
            mntQLSinhVien.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSinhViênToolStripMenuItem, mntQLSanPham });
            mntQLSinhVien.Name = "mntQLSinhVien";
            mntQLSinhVien.Size = new Size(90, 24);
            mntQLSinhVien.Text = "Danh mục";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            quảnLýSinhViênToolStripMenuItem.Size = new Size(210, 26);
            quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // mntQLSanPham
            // 
            mntQLSanPham.Name = "mntQLSanPham";
            mntQLSanPham.Size = new Size(210, 26);
            mntQLSanPham.Text = "Quản lý sản phẩm";
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mntCascade, mntTileHorizontal, mntTileVertical });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // mntCascade
            // 
            mntCascade.Name = "mntCascade";
            mntCascade.Size = new Size(190, 26);
            mntCascade.Text = "Cascade";
            // 
            // mntTileHorizontal
            // 
            mntTileHorizontal.Name = "mntTileHorizontal";
            mntTileHorizontal.Size = new Size(190, 26);
            mntTileHorizontal.Text = "Tile Horizontal";
            // 
            // mntTileVertical
            // 
            mntTileVertical.Name = "mntTileVertical";
            mntTileVertical.Size = new Size(190, 26);
            mntTileVertical.Text = "Tile Vertical";
            // 
            // toolStripMain
            // 
            toolStripMain.ImageScalingSize = new Size(20, 20);
            toolStripMain.Items.AddRange(new ToolStripItem[] { btnToolStudent, btnToolProduct });
            toolStripMain.Location = new Point(0, 28);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(800, 27);
            toolStripMain.TabIndex = 2;
            toolStripMain.Text = "toolStrip1";
            // 
            // btnToolStudent
            // 
            btnToolStudent.Image = (Image)resources.GetObject("btnToolStudent.Image");
            btnToolStudent.ImageTransparentColor = Color.Magenta;
            btnToolStudent.Name = "btnToolStudent";
            btnToolStudent.Size = new Size(94, 24);
            btnToolStudent.Text = "Sinh Viên";
            btnToolStudent.Click += btnToolStudent_Click;
            // 
            // btnToolProduct
            // 
            btnToolProduct.Image = (Image)resources.GetObject("btnToolProduct.Image");
            btnToolProduct.ImageTransparentColor = Color.Magenta;
            btnToolProduct.Name = "btnToolProduct";
            btnToolProduct.Size = new Size(99, 24);
            btnToolProduct.Text = "Sản phẩm";
            btnToolProduct.Click += btnToolProduct_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { lblUser, lblStatus, lblTime });
            statusStripMain.Location = new Point(0, 424);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(800, 26);
            statusStripMain.TabIndex = 3;
            statusStripMain.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(89, 20);
            lblUser.Text = "Người dùng";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(633, 20);
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 20);
            lblTime.Text = "00:00:00";
            // 
            // timerSystem
            // 
            timerSystem.Enabled = true;
            timerSystem.Interval = 1000;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mntDangXuat;
        private ToolStripMenuItem mntThoat;
        private ToolStripMenuItem mntQLSinhVien;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem mntQLSanPham;
        private ToolStripMenuItem mntCascade;
        private ToolStripMenuItem mntTileHorizontal;
        private ToolStripMenuItem mntTileVertical;
        private ToolStrip toolStripMain;
        private ToolStripButton btnToolStudent;
        private ToolStripButton btnToolProduct;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timerSystem;
    }
}
