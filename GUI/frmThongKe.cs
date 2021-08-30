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

namespace QuanLyChiTieu
{
    public partial class frmThongKe : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        CultureInfo culture = new CultureInfo("vi-VN");
        private static int month;
        int current_month = DateTime.Now.Month;

        public frmThongKe()
        {
            InitializeComponent();
            loadData(current_month);
            LoadCombobox();
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


        public void loadData(int month)
        {
            lblThongKe.Text = "";
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
                                    && ct.created_date.Value.Month == month
                                    && ct.created_date.Value.Year == DateTime.Now.Year
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

            for (int  i = 0; i < grvThongKe.Rows.Count; i++)
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
                                       && ct.account_id == 1 // thay bằng user id hiện tại
                                       select dg).Sum(dg => dg.diengiai_price)

                         };

            grvThongKe.DataSource = search;
            grvThongKe.Columns[0].Visible = false;
            grvThongKe.Columns[1].HeaderText = "Tên danh mục";
            grvThongKe.Columns[2].HeaderText = "Đã chi";
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = (cbbMonth.SelectedIndex + 1);
            loadData(month);
        }
    }
}
