using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class frmNhapChiTieu : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmNhapChiTieu()
        {
            InitializeComponent();
            loaddata();
            loadLichSu();
        }

        protected void loaddata()
        {
            var data = from dm in db.tbDanhMucs 
                select new 
                {
                    dm.danhmuc_name,
                };
            cbbDanhMuc.DataSource = data;
            cbbDanhMuc.DisplayMember = "danhmuc_name";
        }

        protected void loadLichSu()
        {
            var data = from ls in db.tbChiTieus
                       join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                       join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                       orderby ls.created_date descending
                       select new
                       {
                           //ngaytao = Convert.ToDateTime(ls.created_date).ToString('dd/MM/yyyy'),
                           ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                           dg.diengiai_name,
                           ls.total_cost,
                       };
            grvLichSu.DataSource = data;
            grvLichSu.Columns[0].HeaderText = "Ngày tạo";
            grvLichSu.Columns[1].HeaderText = "Diễn giải";
            grvLichSu.Columns[2].HeaderText = "Chi phí";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtChi.Text == "" || txtDienGiai.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    // lấy đc id danh mục
                    var getIdCbb = db.tbDanhMucs.Where(x => x.danhmuc_name == cbbDanhMuc.Text).First().danhmuc_id;

                    // tạo mới chi tiêu
                    tbChiTieu chitieu = new tbChiTieu();
                    chitieu.created_date = Convert.ToDateTime(dtepickerNgayNhap.Value);
                    chitieu.total_cost = Convert.ToInt32(txtChi.Text);
                    db.tbChiTieus.InsertOnSubmit(chitieu);

                    //tạo mới diễn giải
                    tbDienGiai diengiai = new tbDienGiai();
                    diengiai.diengiai_name = txtDienGiai.Text;
                    diengiai.danhmuc_id = getIdCbb;
                    diengiai.diengiai_price = 0;
                    db.tbDienGiais.InsertOnSubmit(diengiai);
                    db.SubmitChanges();

                    //tạo mới chi tiêu chi tiết
                    tbChiTieuChiTiet chitieuct = new tbChiTieuChiTiet();
                    chitieuct.diengiai_id = diengiai.diengiai_id;
                    chitieuct.chitieu_id = chitieu.chitieu_id;
                    db.tbChiTieuChiTiets.InsertOnSubmit(chitieuct);
                    db.SubmitChanges();
                
                    MessageBox.Show("Thêm chi tiêu thành công!");
                    loadLichSu();
                }
                catch(Exception)
                {
                    ;
                }
            }    

        }
    }
}
