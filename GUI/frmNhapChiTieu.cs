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
        private static int _idUser;
        public delegate void SendUser(tbAccount user);
        public SendUser Sender;
        private static int id_ChiTieu;
        private static string options;

        //t2 trong tuần hiện tại
        DateTime monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        //t7 trong tuần hiện tại
        DateTime saturday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Saturday);
        CultureInfo culture = new CultureInfo("vi-VN");
        public frmNhapChiTieu()
        {
            InitializeComponent();
            Sender = new SendUser(GetUser);
        }

        public void GetUser(tbAccount user)
        {
            _idUser = user.account_id;
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

        protected void Reset()
        {
            txtDienGiai.Text = "";
            txtChi.Text = "";
            loaddata();
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
                    chitieu.account_id = _idUser;
                    db.tbChiTieus.InsertOnSubmit(chitieu);

                    //tạo mới diễn giải
                    tbDienGiai diengiai = new tbDienGiai();
                    diengiai.diengiai_name = txtDienGiai.Text;
                    diengiai.danhmuc_id = getIdCbb;
                    diengiai.diengiai_price = Convert.ToInt32(txtChi.Text);
                    db.tbDienGiais.InsertOnSubmit(diengiai);
                    db.SubmitChanges();

                    //tạo mới chi tiêu chi tiết
                    tbChiTieuChiTiet chitieuct = new tbChiTieuChiTiet();
                    chitieuct.diengiai_id = diengiai.diengiai_id;
                    chitieuct.chitieu_id = chitieu.chitieu_id;
                    db.tbChiTieuChiTiets.InsertOnSubmit(chitieuct);
                    db.SubmitChanges();
                 
                    Reset();
                    loadLichSu();
                    MessageBox.Show("Thêm chi tiêu thành công!");
                }
                catch(Exception)
                {
                    Reset();
                }
            }    

        }

        private void frmNhapChiTieu_Load(object sender, EventArgs e)
        {
            loaddata();
            loadLichSu();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Bạn có muốn xóa chi tiêu này?";
                string title = "Xóa";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                int id_DienGiai = 0;
                if (result == DialogResult.Yes)
                {
                    //delete chitieuchitiet first
                    var chitieuchitiet = (from ctct in db.tbChiTieuChiTiets
                                          where ctct.chitieu_id == id_ChiTieu
                                          select ctct).FirstOrDefault();
                    id_DienGiai = Convert.ToInt32(chitieuchitiet.diengiai_id);
                    db.tbChiTieuChiTiets.DeleteOnSubmit(chitieuchitiet);
                    db.SubmitChanges();

                    //then delete chitieu
                    var chitieu = (from ct in db.tbChiTieus where ct.chitieu_id == id_ChiTieu select ct).FirstOrDefault();
                    db.tbChiTieus.DeleteOnSubmit(chitieu);
                    db.SubmitChanges();

                    //finally delete diengiai
                    var diengiai = (from dg in db.tbDienGiais where dg.diengiai_id == id_DienGiai select dg).FirstOrDefault();
                    db.tbDienGiais.DeleteOnSubmit(diengiai);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!");
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnThem.Enabled = true;
                    Reset();
                    loadLichSu(options);

                }
                else {; }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi!");
            }
             

        }

        private void grvLichSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_ChiTieu = Convert.ToInt32(grvLichSu.CurrentRow.Cells[0].Value);

                var getData = (from dg in db.tbDienGiais
                               join dm in db.tbDanhMucs on dg.danhmuc_id equals dm.danhmuc_id
                               join ctct in db.tbChiTieuChiTiets on dg.diengiai_id equals ctct.diengiai_id
                               join ct in db.tbChiTieus on ctct.chitieu_id equals ct.chitieu_id
                               where ct.chitieu_id == id_ChiTieu
                               select new
                               {
                                   dg.diengiai_name,
                                   dg.diengiai_price,
                                   ct.created_date,
                                   dm.danhmuc_name,
                               }).FirstOrDefault();

                //load dữ liệu lên
                txtDienGiai.Text = getData.diengiai_name;
                txtChi.Text = getData.diengiai_price.ToString();
                cbbDanhMuc.Text = getData.danhmuc_name;
                dtepickerNgayNhap.Value = Convert.ToDateTime(getData.created_date);

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn cập nhật chi tiêu này?";
            string title = "Cạp nhật";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                tbChiTieu new_ct = new tbChiTieu();



                //find chitieuchitiet 
                var chitieuchitiet = (from ctct in db.tbChiTieuChiTiets
                                      where ctct.chitieu_id == id_ChiTieu
                                      select ctct).FirstOrDefault();
                //find chitieu
                var chitieu = (from ct in db.tbChiTieus where ct.chitieu_id == id_ChiTieu select ct).FirstOrDefault();

                //find diengiai
                var diengiai = (from dg in db.tbDienGiais where dg.diengiai_id == chitieuchitiet.diengiai_id select dg).FirstOrDefault();

                // lấy đc id danh mục
                var getIdCbb = db.tbDanhMucs.Where(x => x.danhmuc_name == cbbDanhMuc.Text).First().danhmuc_id;

                //update all
                diengiai.danhmuc_id = getIdCbb;
                chitieu.created_date = Convert.ToDateTime(dtepickerNgayNhap.Value);
                diengiai.diengiai_name = txtDienGiai.Text;
                diengiai.diengiai_price = Convert.ToInt32(txtChi.Text);
                db.SubmitChanges();

                MessageBox.Show("Cập nhật thành công!");
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = true;
                Reset();
                loadLichSu(options);

            }
            else {; }
        }

        private void cbbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            options = cbbOptions.SelectedItem.ToString();
            loadLichSu(options);
        }
        protected void loadLichSu(string options ="")
        {
            int money_paid = 0;
            if (options == "Trong ngày")
            {
                var data = from ls in db.tbChiTieus
                           join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                           join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                           where ls.account_id == _idUser
                           && ls.created_date.Value.Date == DateTime.Now
                           orderby ls.created_date descending
                           select new
                           {
                               ls.chitieu_id,
                               ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                               dg.diengiai_name,
                               dg.diengiai_price,

                           };
                grvLichSu.DataSource = data;
            }   
            else if(options == "Trong tháng")
            {
                var data = from ls in db.tbChiTieus
                           join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                           join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                           where ls.account_id == _idUser
                           && ls.created_date.Value.Month == DateTime.Now.Month
                           && ls.created_date.Value.Year == DateTime.Now.Year
                           orderby ls.created_date descending
                           select new
                           {
                               ls.chitieu_id,
                               ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                               dg.diengiai_name,
                               dg.diengiai_price,

                           };

                grvLichSu.DataSource = data;
            }
            else if(options == "Trong tuần")
            {
                var data = from ls in db.tbChiTieus
                           join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                           join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                           where ls.account_id == _idUser
                           && ls.created_date >= monday
                           && ls.created_date <= saturday
                           orderby ls.created_date descending
                           select new
                           {
                               ls.chitieu_id,
                               ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                               dg.diengiai_name,
                               dg.diengiai_price,

                           };

                grvLichSu.DataSource = data;
            }    
            else
            {
                var data = from ls in db.tbChiTieus
                           join ctct in db.tbChiTieuChiTiets on ls.chitieu_id equals ctct.chitieu_id
                           join dg in db.tbDienGiais on ctct.diengiai_id equals dg.diengiai_id
                           where ls.account_id == _idUser
                           orderby ls.created_date descending
                           select new
                           {
                               ls.chitieu_id,
                               ngaytao = Convert.ToDateTime(ls.created_date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                               dg.diengiai_name,
                               dg.diengiai_price,

                           };

                grvLichSu.DataSource = data;
            }
       
            grvLichSu.Columns[0].Visible = false;
            grvLichSu.Columns[1].HeaderText = "Ngày tạo";
            grvLichSu.Columns[2].HeaderText = "Diễn giải";
            grvLichSu.Columns[3].HeaderText = "Chi phí";

            try
            {
                for (int r = 0; r < grvLichSu.RowCount; r++)
                {
                    money_paid += Convert.ToInt32(grvLichSu[3, r].Value);
                }
            }
            catch
            {
                ;
            }
            lblPaid.Text = money_paid.ToString("c", culture);
        }

    }
}
