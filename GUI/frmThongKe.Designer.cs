
namespace QuanLyChiTieu
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.cThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.grvThongKe = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlThongKe.SuspendLayout();
            this.pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlThongKe.Controls.Add(this.btnXuatFile);
            this.pnlThongKe.Controls.Add(this.label3);
            this.pnlThongKe.Controls.Add(this.txtSearch);
            this.pnlThongKe.Controls.Add(this.label2);
            this.pnlThongKe.Controls.Add(this.pnlBieuDo);
            this.pnlThongKe.Controls.Add(this.cbbMonth);
            this.pnlThongKe.Controls.Add(this.grvThongKe);
            this.pnlThongKe.Controls.Add(this.lblThongKe);
            this.pnlThongKe.Location = new System.Drawing.Point(12, 49);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(1872, 948);
            this.pnlThongKe.TabIndex = 0;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1648, 846);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(187, 58);
            this.btnXuatFile.TabIndex = 17;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 872);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(33, 117);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(485, 40);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 872);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng chi:";
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.BackColor = System.Drawing.Color.White;
            this.pnlBieuDo.Controls.Add(this.cThongKe);
            this.pnlBieuDo.Controls.Add(this.label1);
            this.pnlBieuDo.Location = new System.Drawing.Point(1000, 192);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(838, 638);
            this.pnlBieuDo.TabIndex = 4;
            // 
            // cThongKe
            // 
            chartArea3.Name = "ChartArea1";
            this.cThongKe.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cThongKe.Legends.Add(legend3);
            this.cThongKe.Location = new System.Drawing.Point(16, 72);
            this.cThongKe.Name = "cThongKe";
            this.cThongKe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Chi Tiêu";
            this.cThongKe.Series.Add(series3);
            this.cThongKe.Size = new System.Drawing.Size(819, 519);
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
            // cbbMonth
            // 
            this.cbbMonth.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(679, 116);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(188, 41);
            this.cbbMonth.TabIndex = 3;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
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
            this.grvThongKe.TabIndex = 2;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.Location = new System.Drawing.Point(559, 25);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(0, 81);
            this.lblThongKe.TabIndex = 1;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1026);
            this.Controls.Add(this.pnlThongKe);
            this.DoubleBuffered = true;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.pnlThongKe.ResumeLayout(false);
            this.pnlThongKe.PerformLayout();
            this.pnlBieuDo.ResumeLayout(false);
            this.pnlBieuDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.DataGridView grvThongKe;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart cThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatFile;
    }
}