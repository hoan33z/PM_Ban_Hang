﻿namespace _3.PL.Views
{
    partial class FrmMain
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
            this.loadForm = new System.Windows.Forms.Panel();
            this.QLBanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongkeTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.qlNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.qlSanPhamCT = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKhacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_heThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DoiMk = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadForm
            // 
            this.loadForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadForm.Location = new System.Drawing.Point(0, 30);
            this.loadForm.Name = "loadForm";
            this.loadForm.Size = new System.Drawing.Size(1054, 516);
            this.loadForm.TabIndex = 1;
            // 
            // QLBanHangToolStripMenuItem
            // 
            this.QLBanHangToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QLBanHangToolStripMenuItem.Name = "QLBanHangToolStripMenuItem";
            this.QLBanHangToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.QLBanHangToolStripMenuItem.Text = "Quản lý Bán Hàng";
            this.QLBanHangToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // menu_thongKe
            // 
            this.menu_thongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_thongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongKeDoanhThu,
            this.menu_thongkeTonKho,
            this.thốngKêHóaĐơnToolStripMenuItem});
            this.menu_thongKe.Name = "menu_thongKe";
            this.menu_thongKe.Size = new System.Drawing.Size(84, 24);
            this.menu_thongKe.Text = "Thống kê";
            // 
            // ThongKeDoanhThu
            // 
            this.ThongKeDoanhThu.Name = "ThongKeDoanhThu";
            this.ThongKeDoanhThu.Size = new System.Drawing.Size(274, 26);
            this.ThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.ThongKeDoanhThu.Click += new System.EventHandler(this.ThongKeDoanhThu_Click);
            // 
            // menu_thongkeTonKho
            // 
            this.menu_thongkeTonKho.Name = "menu_thongkeTonKho";
            this.menu_thongkeTonKho.Size = new System.Drawing.Size(274, 26);
            this.menu_thongkeTonKho.Text = "Số lượng sản phẩm tồn kho";
            this.menu_thongkeTonKho.Click += new System.EventHandler(this.menu_thongkeTonKho_Click);
            // 
            // thốngKêHóaĐơnToolStripMenuItem
            // 
            this.thốngKêHóaĐơnToolStripMenuItem.Name = "thốngKêHóaĐơnToolStripMenuItem";
            this.thốngKêHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.thốngKêHóaĐơnToolStripMenuItem.Text = "Thống kê hóa đơn";
            this.thốngKêHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.thốngKêHóaĐơnToolStripMenuItem_Click);
            // 
            // menu_quanLy
            // 
            this.menu_quanLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_quanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlNhanVien,
            this.qlSanPhamCT,
            this.QLKhacToolStripMenuItem});
            this.menu_quanLy.Name = "menu_quanLy";
            this.menu_quanLy.Size = new System.Drawing.Size(73, 24);
            this.menu_quanLy.Text = "Quản lý";
            // 
            // qlNhanVien
            // 
            this.qlNhanVien.Name = "qlNhanVien";
            this.qlNhanVien.Size = new System.Drawing.Size(224, 26);
            this.qlNhanVien.Text = "Nhân Viên";
            this.qlNhanVien.Click += new System.EventHandler(this.qlNhanVien_Click);
            // 
            // qlSanPhamCT
            // 
            this.qlSanPhamCT.Name = "qlSanPhamCT";
            this.qlSanPhamCT.Size = new System.Drawing.Size(224, 26);
            this.qlSanPhamCT.Text = "Chi Tiết Sản Phẩm";
            this.qlSanPhamCT.Click += new System.EventHandler(this.qlSanPhamCT_Click);
            // 
            // QLKhacToolStripMenuItem
            // 
            this.QLKhacToolStripMenuItem.Name = "QLKhacToolStripMenuItem";
            this.QLKhacToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.QLKhacToolStripMenuItem.Text = "Quản Lý Khác";
            this.QLKhacToolStripMenuItem.Click += new System.EventHandler(this.QLKhacToolStripMenuItem_Click);
            // 
            // menu_heThong
            // 
            this.menu_heThong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_heThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DoiMk,
            this.DangXuat});
            this.menu_heThong.Name = "menu_heThong";
            this.menu_heThong.Size = new System.Drawing.Size(85, 24);
            this.menu_heThong.Text = "Hệ thống";
            // 
            // menu_DoiMk
            // 
            this.menu_DoiMk.Name = "menu_DoiMk";
            this.menu_DoiMk.Size = new System.Drawing.Size(224, 26);
            this.menu_DoiMk.Text = "Đổi mật khẩu";
            this.menu_DoiMk.Click += new System.EventHandler(this.menu_DoiMk_Click);
            // 
            // DangXuat
            // 
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(224, 26);
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLBanHangToolStripMenuItem,
            this.menu_thongKe,
            this.menu_quanLy,
            this.menu_heThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1054, 546);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loadForm);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel loadForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_heThong;
        private System.Windows.Forms.ToolStripMenuItem menu_DoiMk;
        private System.Windows.Forms.ToolStripMenuItem DangXuat;
        private System.Windows.Forms.ToolStripMenuItem menu_quanLy;
        private System.Windows.Forms.ToolStripMenuItem qlNhanVien;
        private System.Windows.Forms.ToolStripMenuItem qlSanPhamCT;
        private System.Windows.Forms.ToolStripMenuItem menu_thongKe;
        private System.Windows.Forms.ToolStripMenuItem ThongKeDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem menu_thongkeTonKho;
        private System.Windows.Forms.ToolStripMenuItem QLBanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLKhacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnToolStripMenuItem;
    }
}