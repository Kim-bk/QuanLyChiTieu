﻿
namespace QuanLyChiTieu
{
    partial class frmNhapChiTieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapChiTieu));
            this.pnlNhapChiTieu = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtepickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbOptions = new System.Windows.Forms.ComboBox();
            this.grvLichSu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlNhapChiTieu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhapChiTieu
            // 
            this.pnlNhapChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlNhapChiTieu.Controls.Add(this.btnRefresh);
            this.pnlNhapChiTieu.Controls.Add(this.label8);
            this.pnlNhapChiTieu.Controls.Add(this.txtNote);
            this.pnlNhapChiTieu.Controls.Add(this.btnXoa);
            this.pnlNhapChiTieu.Controls.Add(this.btnSua);
            this.pnlNhapChiTieu.Controls.Add(this.cbbDanhMuc);
            this.pnlNhapChiTieu.Controls.Add(this.label5);
            this.pnlNhapChiTieu.Controls.Add(this.btnThem);
            this.pnlNhapChiTieu.Controls.Add(this.txtChi);
            this.pnlNhapChiTieu.Controls.Add(this.label4);
            this.pnlNhapChiTieu.Controls.Add(this.txtDienGiai);
            this.pnlNhapChiTieu.Controls.Add(this.label3);
            this.pnlNhapChiTieu.Controls.Add(this.label2);
            this.pnlNhapChiTieu.Controls.Add(this.dtepickerNgayNhap);
            this.pnlNhapChiTieu.Controls.Add(this.label1);
            this.pnlNhapChiTieu.Location = new System.Drawing.Point(21, 39);
            this.pnlNhapChiTieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNhapChiTieu.Name = "pnlNhapChiTieu";
            this.pnlNhapChiTieu.Size = new System.Drawing.Size(796, 860);
            this.pnlNhapChiTieu.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(35, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNote.Location = new System.Drawing.Point(227, 505);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(420, 39);
            this.txtNote.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(467, 660);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 50);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(251, 660);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 50);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.ItemHeight = 33;
            this.cbbDanhMuc.Location = new System.Drawing.Point(227, 269);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(420, 41);
            this.cbbDanhMuc.TabIndex = 12;
            this.cbbDanhMuc.Text = "Chọn danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh mục:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(39, 660);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtChi.Location = new System.Drawing.Point(227, 426);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(420, 39);
            this.txtChi.TabIndex = 6;
            this.txtChi.TextChanged += new System.EventHandler(this.txtChi_TextChanged);
            this.txtChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi:";
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDienGiai.Location = new System.Drawing.Point(227, 343);
            this.txtDienGiai.Multiline = true;
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(420, 36);
            this.txtDienGiai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diễn giải: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập:";
            // 
            // dtepickerNgayNhap
            // 
            this.dtepickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtepickerNgayNhap.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtepickerNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtepickerNgayNhap.Location = new System.Drawing.Point(227, 195);
            this.dtepickerNgayNhap.Name = "dtepickerNgayNhap";
            this.dtepickerNgayNhap.Size = new System.Drawing.Size(420, 40);
            this.dtepickerNgayNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(178, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP CHI TIÊU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblPaid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbOptions);
            this.panel1.Controls.Add(this.grvLichSu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(882, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 860);
            this.panel1.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtSearch.Location = new System.Drawing.Point(246, 133);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(727, 41);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(573, 761);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(43, 32);
            this.lblPaid.TabIndex = 14;
            this.lblPaid.Text = "$$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 761);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đã chi:";
            // 
            // cbbOptions
            // 
            this.cbbOptions.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbOptions.FormattingEnabled = true;
            this.cbbOptions.Items.AddRange(new object[] {
            "Tất cả",
            "Trong ngày",
            "Trong tuần",
            "Trong tháng"});
            this.cbbOptions.Location = new System.Drawing.Point(27, 133);
            this.cbbOptions.Name = "cbbOptions";
            this.cbbOptions.Size = new System.Drawing.Size(179, 41);
            this.cbbOptions.TabIndex = 12;
            this.cbbOptions.Text = "Tất cả";
            this.cbbOptions.SelectedIndexChanged += new System.EventHandler(this.cbbOptions_SelectedIndexChanged);
            // 
            // grvLichSu
            // 
            this.grvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvLichSu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvLichSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvLichSu.Location = new System.Drawing.Point(27, 195);
            this.grvLichSu.Name = "grvLichSu";
            this.grvLichSu.RowHeadersWidth = 62;
            this.grvLichSu.RowTemplate.Height = 28;
            this.grvLichSu.Size = new System.Drawing.Size(946, 535);
            this.grvLichSu.TabIndex = 11;
            this.grvLichSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLichSu_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(393, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 63);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lịch sử";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(672, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 58);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmNhapChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 809);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNhapChiTieu);
            this.DoubleBuffered = true;
            this.Name = "frmNhapChiTieu";
            this.Text = "frmNhapChiTieu";
            this.Load += new System.EventHandler(this.frmNhapChiTieu_Load);
            this.pnlNhapChiTieu.ResumeLayout(false);
            this.pnlNhapChiTieu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhapChiTieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtepickerNgayNhap;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvLichSu;
        private System.Windows.Forms.ComboBox cbbOptions;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPaid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnRefresh;
    }
}