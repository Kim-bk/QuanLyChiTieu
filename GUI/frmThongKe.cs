using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChiTieu.GUI;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace QuanLyChiTieu
{
    public partial class frmThongKe : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        CultureInfo culture = new CultureInfo("vi-VN");
        private static int month;
        private static int _idDanhmuc = 0;
        private static int _idUser;
        public delegate void SendUser(tbAccount user);
        public SendUser Sender;
        int current_month = DateTime.Now.Month;

        public frmThongKe()
        {
            Sender = new SendUser(GetUser);
            _idDanhmuc = 0;
            month = current_month;
            InitializeComponent();
            LoadCombobox();
         
        }
        public void GetUser(tbAccount user)
        {
            _idUser = user.account_id;
            loadData(month);
        }

        public void LoadCombobox()
        {
            //cbbMonth.Items.Insert(0, "Tất cả");
            cbbMonth.Text = "Tháng " + current_month.ToString();
            for (int i = 0; i < current_month; i++)
            {
                int j = i + 1;
                string text = "Tháng " + j.ToString();
                cbbMonth.Items.Insert(i, text);
            }
        }


        public void loadData(int month, bool isSearch =  false)
        {
            lblThongKe.Text = "";
            int sum = 0;

            if(!isSearch)
            {
                var data = from dm in db.tbDanhMucs
                           group dm by dm.danhmuc_id into item
                           select new
                           {
                               item.Key,
                               tendanhmuc = (from dm in db.tbDanhMucs where dm.danhmuc_id == item.Key select dm).FirstOrDefault().danhmuc_name,
                               chiphi = (from dm in db.tbDanhMucs
                                         join dg in db.tbDienGiais on dm.danhmuc_id equals dg.danhmuc_id
                                         join ctct in db.tbChiTieuChiTiets on dg.diengiai_id equals ctct.diengiai_id
                                         join ct in db.tbChiTieus on ctct.chitieu_id equals ct.chitieu_id
                                         where dg.danhmuc_id == item.Key
                                         && ct.created_date.Value.Month == month
                                         && ct.created_date.Value.Year == DateTime.Now.Year
                                         && ct.account_id == _idUser // thay bằng user id hiện tại
                                         select dg).Sum(dg => dg.diengiai_price)

                           };
                grvThongKe.DataSource = data;
                grvThongKe.Columns[0].Visible = false;
                grvThongKe.Columns[1].HeaderText = "Tên danh mục";
                grvThongKe.Columns[2].HeaderText = "Đã chi";

                cThongKe.DataSource = data;
                cThongKe.Series["Chi Tiêu"].YValueMembers = "chiphi";
                cThongKe.Series["Chi Tiêu"].XValueMember = "tendanhmuc";
                cThongKe.DataBind();
            }
            else
            {
                var search = from dm in db.tbDanhMucs
                             where dm.danhmuc_name.Contains(txtSearch.Text)
                             group dm by dm.danhmuc_id into item
                             select new
                             {
                                 item.Key,
                                 tendanhmuc = (from dm in db.tbDanhMucs where dm.danhmuc_id == item.Key select dm).FirstOrDefault().danhmuc_name,
                                 chiphi = (from dm in db.tbDanhMucs
                                           join dg in db.tbDienGiais on dm.danhmuc_id equals dg.danhmuc_id
                                           join ctct in db.tbChiTieuChiTiets on dg.diengiai_id equals ctct.diengiai_id
                                           join ct in db.tbChiTieus on ctct.chitieu_id equals ct.chitieu_id
                                           where dg.danhmuc_id == item.Key
                                           && ct.created_date.Value.Month == month
                                           && ct.created_date.Value.Year == DateTime.Now.Year
                                           && ct.account_id == _idUser // thay bằng user id hiện tại
                                           select dg).Sum(dg => dg.diengiai_price)
                             };

                grvThongKe.DataSource = search;
                grvThongKe.Columns[0].Visible = false;
                grvThongKe.Columns[1].HeaderText = "Tên danh mục";
                grvThongKe.Columns[2].HeaderText = "Đã chi";
            }
        

            for (int i = 0; i < grvThongKe.Rows.Count; i++)
            {
                sum += Convert.ToInt32(grvThongKe.Rows[i].Cells[2].Value);
            }
            label3.Text = sum.ToString("c", culture);
            lblThongKe.Text += "THỐNG KÊ THÁNG " + month.ToString() + "/" + DateTime.Now.Year.ToString();
        }


        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //fillChart();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData(month, true);
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idDanhmuc = 0;
            month = (cbbMonth.SelectedIndex + 1);
            loadData(month);
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (_idDanhmuc == 0)
            {
                MessageBox.Show("Chưa chọn danh mục để xem!");
            }
            else
            {
                frmThongKe_ChiTiet chitiet = new frmThongKe_ChiTiet();
                chitiet.Sender(_idDanhmuc, month, null, null);
                chitiet.ShowDialog();
            }
        }
        private void grvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idDanhmuc = Convert.ToInt32(grvThongKe.CurrentRow.Cells[0].Value);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)    
        {
            try
            {
                string saveExcelFile = @"D:\QuanLyChiTieu\BÁO CÁO CHI TIÊU.xlsx";

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];
                ws.Name = "Tháng " + month.ToString();

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "B1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = lblThongKe.Text;

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "Tên danh mục";
                row23_STT.ColumnWidth = 20;

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaSP = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_MaSP.Merge();
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "Đã chi";
                row23_MaSP.ColumnWidth = 20;


                Range row23_CotTieuDe = ws.get_Range("A2", "B3");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)

                var getdata = from dm in db.tbDanhMucs
                              group dm by dm.danhmuc_id into item
                              select new
                              {
                                  item.Key,
                                  tendanhmuc = (from dm in db.tbDanhMucs where dm.danhmuc_id == item.Key select dm).FirstOrDefault().danhmuc_name,
                                  chiphi = (from dm in db.tbDanhMucs
                                            join dg in db.tbDienGiais on dm.danhmuc_id equals dg.danhmuc_id
                                            join ctct in db.tbChiTieuChiTiets on dg.diengiai_id equals ctct.diengiai_id
                                            join ct in db.tbChiTieus on ctct.chitieu_id equals ct.chitieu_id
                                            where dg.danhmuc_id == item.Key
                                            && ct.created_date.Value.Month == month
                                            && ct.created_date.Value.Year == DateTime.Now.Year
                                            && ct.account_id == _idUser // thay bằng user id hiện tại
                                            select dg).Sum(dg => dg.diengiai_price)
                              };
                foreach (var item in getdata)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { item.tendanhmuc, item.chiphi };
                    Range rowData = ws.get_Range("A" + row, "B" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "B" + row));

                //Tính tổng chi tiêu
                row++;
                Range sumChiTieu = ws.get_Range("A" + row, "B" + row);
                sumChiTieu.Font.Size = fontSizeNoiDung;
                sumChiTieu.Font.Name = fontName;
                sumChiTieu.Font.Bold = true;
                sumChiTieu.Font.Italic = true;
                dynamic[] sum = { "Tổng", label3.Text };
                sumChiTieu.Value2 = sum;

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
    }
}
