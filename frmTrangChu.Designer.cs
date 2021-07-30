
namespace QuanLyChiTieu
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpChiTiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịHệThốngToolStripMenuItem,
            this.nhậpChiTiêuToolStripMenuItem,
            this.nhậpDanhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1924, 58);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // quảnTrịHệThốngToolStripMenuItem
            // 
            this.quảnTrịHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.quảnTrịHệThốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.quảnTrịHệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnTrịHệThốngToolStripMenuItem.Image")));
            this.quảnTrịHệThốngToolStripMenuItem.Name = "quảnTrịHệThốngToolStripMenuItem";
            this.quảnTrịHệThốngToolStripMenuItem.Size = new System.Drawing.Size(261, 54);
            this.quảnTrịHệThốngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // nhậpChiTiêuToolStripMenuItem
            // 
            this.nhậpChiTiêuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.nhậpChiTiêuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhậpChiTiêuToolStripMenuItem.Image")));
            this.nhậpChiTiêuToolStripMenuItem.Name = "nhậpChiTiêuToolStripMenuItem";
            this.nhậpChiTiêuToolStripMenuItem.Size = new System.Drawing.Size(215, 54);
            this.nhậpChiTiêuToolStripMenuItem.Text = "Nhập chi tiêu";
            // 
            // nhậpDanhMụcToolStripMenuItem
            // 
            this.nhậpDanhMụcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.nhậpDanhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhậpDanhMụcToolStripMenuItem.Image")));
            this.nhậpDanhMụcToolStripMenuItem.Name = "nhậpDanhMụcToolStripMenuItem";
            this.nhậpDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(182, 54);
            this.nhậpDanhMụcToolStripMenuItem.Text = "Danh mục";
            this.nhậpDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.nhậpDanhMụcToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(179, 54);
            this.thốngKêToolStripMenuItem.Text = "Thống kê ";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Location = new System.Drawing.Point(16, 91);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(75, 77, 75, 77);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(2018, 711);
            this.pnlMain.TabIndex = 7;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1924, 809);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmTrangChu";
            this.Text = "Trang chủ";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpChiTiêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}