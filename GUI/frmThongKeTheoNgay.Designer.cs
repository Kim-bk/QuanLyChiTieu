
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvThongKe = new System.Windows.Forms.DataGridView();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.cThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).BeginInit();
            this.pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pnlBieuDo);
            this.panel1.Controls.Add(this.grvThongKe);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1872, 948);
            this.panel1.TabIndex = 0;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 40);
            this.dateTimePicker1.TabIndex = 1;
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
            this.textBox1.Location = new System.Drawing.Point(30, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 41);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(486, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 40);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXem.Location = new System.Drawing.Point(709, 26);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(158, 47);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(992, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 45);
            this.label5.TabIndex = 15;
            this.label5.Text = "NHẬP CHI TIÊU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1648, 861);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xuất File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).EndInit();
            this.pnlBieuDo.ResumeLayout(false);
            this.pnlBieuDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grvThongKe;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart cThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}