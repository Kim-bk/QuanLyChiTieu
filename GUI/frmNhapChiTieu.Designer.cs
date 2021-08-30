
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapChiTieu));
            this.pnlNhapChiTieu = new System.Windows.Forms.Panel();
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
            this.cbbOptions = new System.Windows.Forms.ComboBox();
            this.grvLichSu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.pnlNhapChiTieu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhapChiTieu
            // 
            this.pnlNhapChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(467, 606);
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
            this.btnSua.Location = new System.Drawing.Point(260, 606);
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
            this.btnThem.Location = new System.Drawing.Point(41, 606);
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
            this.txtChi.Location = new System.Drawing.Point(227, 422);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(420, 39);
            this.txtChi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 413);
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
            this.label1.Location = new System.Drawing.Point(146, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP CHI TIÊU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblPaid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbOptions);
            this.panel1.Controls.Add(this.grvLichSu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1043, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 860);
            this.panel1.TabIndex = 11;
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
            this.cbbOptions.Size = new System.Drawing.Size(149, 41);
            this.cbbOptions.TabIndex = 12;
            this.cbbOptions.Text = "Tất cả";
            this.cbbOptions.SelectedIndexChanged += new System.EventHandler(this.cbbOptions_SelectedIndexChanged);
            // 
            // grvLichSu
            // 
            this.grvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.grvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLichSu.Location = new System.Drawing.Point(27, 195);
            this.grvLichSu.Name = "grvLichSu";
            this.grvLichSu.RowHeadersWidth = 62;
            this.grvLichSu.RowTemplate.Height = 28;
            this.grvLichSu.Size = new System.Drawing.Size(731, 488);
            this.grvLichSu.TabIndex = 11;
            this.grvLichSu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLichSu_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(293, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 63);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lịch sử";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đã chi:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(505, 716);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(43, 32);
            this.lblPaid.TabIndex = 14;
            this.lblPaid.Text = "$$";
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
    }
}