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
using QuanLyChiTieu.App_Data;

namespace QuanLyChiTieu
{
    public partial class frmThongKe : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        CultureInfo culture = new CultureInfo("vi-VN");
        public frmThongKe()
        {
            InitializeComponent();
            loadData();
            lblThongKe.Text += " THÁNG " + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            txtTong.Enabled = false;
        }

        public void loadData()
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
                                    && ct.created_date.Value.Month == DateTime.Now.Month
                                    && ct.created_date.Value.Year == DateTime.Now.Year
                                    && ct.account_id == 1 // thay bằng user id hiện tại
                                    select dg).Sum(dg => dg.diengiai_price)

                       };

            grvThongKe.DataSource = data;
            grvThongKe.Columns[0].Visible = false;
            grvThongKe.Columns[1].HeaderText = "Tên danh mục";
            grvThongKe.Columns[2].HeaderText = "Đã chi";

            int sum = 0;
            for(int  i = 0; i < grvThongKe.Rows.Count; i++)
            {
                sum += Convert.ToInt32(grvThongKe.Rows[i].Cells[2].Value);
            }
            txtTong.Text = sum.ToString("c", culture);
      
        }

    }
}
