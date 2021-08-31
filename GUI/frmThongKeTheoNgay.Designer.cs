
namespace QuanLyChiTieu.GUI
{
    partial class frmThongKeTheoNgay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeTheoNgay));
            this.grvThongKe = new System.Windows.Forms.DataGridView();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.cThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dteTungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dteDenngay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).BeginInit();
            this.pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvThongKe
            // 
            this.grvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.grvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvThongKe.Location = new System.Drawing.Point(33, 192);
            this.grvThongKe.Name = "grvThongKe";
            this.grvThongKe.RowHeadersWidth = 62;
            this.grvThongKe.RowTemplate.Height = 28;
            this.grvThongKe.Size = new System.Drawing.Size(834, 644);
            this.grvThongKe.TabIndex = 3;
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.BackColor = System.Drawing.Color.White;
            this.pnlBieuDo.Controls.Add(this.cThongKe);
            this.pnlBieuDo.Controls.Add(this.label1);
            this.pnlBieuDo.Location = new System.Drawing.Point(1000, 192);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(838, 638);
            this.pnlBieuDo.TabIndex = 5;
            // 
            // cThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.cThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cThongKe.Legends.Add(legend1);
            this.cThongKe.Location = new System.Drawing.Point(16, 72);
            this.cThongKe.Name = "cThongKe";
            this.cThongKe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Chi Tiêu";
            this.cThongKe.Series.Add(series1);
            this.cThongKe.Size = new System.Drawing.Size(819, 535);
            this.cThongKe.TabIndex = 1;
            this.cThongKe.Text = "Chi tiêu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label1.Location = new System.Drawing.Point(239, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Biểu Đồ";
            // 
            // dteTungay
            // 
            this.dteTungay.CalendarFont = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTungay.CustomFormat = "dd/MM/yyyy";
            this.dteTungay.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dteTungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteTungay.Location = new System.Drawing.Point(144, 26);
            this.dteTungay.Name = "dteTungay";
            this.dteTungay.Size = new System.Drawing.Size(202, 40);
            this.dteTungay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 40);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dteDenngay
            // 
            this.dteDenngay.CalendarFont = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDenngay.CustomFormat = "dd/MM/yyyy";
            this.dteDenngay.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dteDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteDenngay.Location = new System.Drawing.Point(486, 26);
            this.dteDenngay.Name = "dteDenngay";
            this.dteDenngay.Size = new System.Drawing.Size(202, 40);
            this.dteDenngay.TabIndex = 11;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXem.Location = new System.Drawing.Point(709, 25);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(158, 47);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1648, 861);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(187, 58);
            this.btnXuatFile.TabIndex = 16;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 872);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tổng chi:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXuatFile);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.dteDenngay);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dteTungay);
            this.panel1.Controls.Add(this.pnlBieuDo);
            this.panel1.Controls.Add(this.grvThongKe);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1872, 948);
            this.panel1.TabIndex = 0;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(628, 872);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(85, 32);
            this.lblTong.TabIndex = 18;
            this.lblTong.Text = "label6";
            // 
            // frmThongKeTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1026);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeTheoNgay";
            this.Text = "frmThongKeTheoNgay";
            this.Load += new System.EventHandler(this.frmThongKeTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).EndInit();
            this.pnlBieuDo.ResumeLayout(false);
            this.pnlBieuDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvThongKe;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart cThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteTungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dteDenngay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTong;
    }
}