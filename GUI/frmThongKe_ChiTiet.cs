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
    public partial class frmThongKe_ChiTiet : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public delegate void SendInfo(int id, int month, DateTime? tungay, DateTime? denngay);
        public SendInfo Sender;
        CultureInfo culture1 = new CultureInfo("en-US");
        public frmThongKe_ChiTiet()
        {
            InitializeComponent();
            Sender = new SendInfo(GetInfo);
        }
        private void GetInfo(int id, int month, DateTime? tungay, DateTime? denngay)
        {
            lblName.Text = (from dm in db.tbDanhMucs where dm.danhmuc_id == id select dm).FirstOrDefault().danhmuc_name;
            LoadData(id, month, tungay, denngay);
        }

        private void frmThongKe_ChiTiet_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        public void LoadData(int idDanhmuc, int month = 0, DateTime? tungay = null, DateTime? denngay = null)
        {
            if(month != 0)
            {
                var data = from ls in db.tbChiTieus
                           join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                           join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                           where ls.created_date.Value.Month == month
                           && ls.created_date.Value.Year == DateTime.Now.Year
                           && dg.danhmuc_id == idDanhmuc
                           orderby ls.created_date descending
                           select new
                           {
                               ls.chitieu_id,
                               ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                               dg.diengiai_name,
                               tien = (string.Format(culture1, "{0:N0}", Convert.ToDecimal(dg.diengiai_price))).Replace(',', '.'),
                               dg.diengiai_note

                           };
                grvThongKeChiTiet.DataSource = data;
            }
            else
            {
                var data = from ls in db.tbChiTieus
                           join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                           join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                           where ls.created_date.Value.Date >= tungay
                           && ls.created_date.Value.Date <= denngay
                           && dg.danhmuc_id == idDanhmuc
                           orderby ls.created_date descending
                           select new
                           {
                               ls.chitieu_id,
                               ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                               dg.diengiai_name,
                               tien = (string.Format(culture1, "{0:N0}", Convert.ToDecimal(dg.diengiai_price))).Replace(',', '.'),
                               dg.diengiai_note

                           };
                grvThongKeChiTiet.DataSource = data;
            }
            grvThongKeChiTiet.Columns[0].Visible = false;
            grvThongKeChiTiet.Columns[1].HeaderText = "Ngày tạo";
            grvThongKeChiTiet.Columns[2].HeaderText = "Diễn giải";
            grvThongKeChiTiet.Columns[3].HeaderText = "Chi phí";
            grvThongKeChiTiet.Columns[4].HeaderText = "Ghi chú ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
