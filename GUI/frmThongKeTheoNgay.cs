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

namespace QuanLyChiTieu.GUI
{
    public partial class frmThongKeTheoNgay : Form
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        dbcsdlDataContext db = new dbcsdlDataContext();
        private static DateTime tungay;
        private static DateTime denngay;

        public frmThongKeTheoNgay()
        {
            InitializeComponent();
        }
        private void frmThongKeTheoNgay_Load(object sender, EventArgs e)
        {
            lblTong.Text = "";
            label4.Visible = false;
            btnXuatFile.Visible = false;
        }

   
        public void LoadData(DateTime tungay, DateTime denngay)
        {
            int sum = 0;
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
                                     && ct.created_date.Value.Date >= tungay
                                     && ct.created_date.Value.Date <= denngay
                                     && ct.account_id == 1 // thay bằng user id hiện tại
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

            //cThongKe.DataSource = null;

            for (int i = 0; i < grvThongKe.Rows.Count; i++)
            {
                sum += Convert.ToInt32(grvThongKe.Rows[i].Cells[2].Value);
            }
  

            btnXuatFile.Visible = true;
            label4.Visible = true;
            lblTong.Text = sum.ToString("c", culture);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            tungay = dteTungay.Value;
            denngay = dteDenngay.Value;
            if(tungay >= denngay)
            {
                MessageBox.Show("Nhập lại ngày!");
            }
            else
            {
                LoadData(tungay, denngay);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var search = from dm in db.tbDanhMucs
                         where dm.danhmuc_name.Contains(textBox1.Text)
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
                                       && ct.created_date.Value.Date >= tungay
                                       && ct.created_date.Value.Date <= denngay
                                       && ct.account_id == 1 // thay bằng user id hiện tại
                                       select dg).Sum(dg => dg.diengiai_price)

                         };


            grvThongKe.DataSource = search;
            grvThongKe.Columns[0].Visible = false;
            grvThongKe.Columns[1].HeaderText = "Tên danh mục";
            grvThongKe.Columns[2].HeaderText = "Đã chi";

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }
    }
}
