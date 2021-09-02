using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChiTieu.GUI;

namespace QuanLyChiTieu
{
    public partial class frmTrangChu : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        private static tbAccount _user;
        public delegate void SendUser(tbAccount user);
        public SendUser Sender;
        public frmTrangChu()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Sender = new SendUser(GetUser);
        }


        private void GetUser(tbAccount user)
        {
            lblName.Text = "Chào " + user.account_fullname + "!";
            _user = user;
        }


        public void nhung(Form f)
        {
            pnlMain.Controls.Clear(); // xóa control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(f); // thêm form mới vào panel
        }

        private void nhậpDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMuc dm = new frmDanhMuc();
            dm.Sender(_user);
            nhung(dm);
        }

        private void nhậpChiTiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapChiTieu chitieu = new frmNhapChiTieu();
            chitieu.Sender(_user);
            nhung(chitieu);
        }
        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string message = "Bạn có muốn đăng xuất?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                frmDangNhap dn = new frmDangNhap();
                dn.ShowDialog();
            }
            else
            {; }
        }

        private void trongThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe();
            thongke.Sender(_user);
            nhung(thongke);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doimatkhau = new frmDoiMatKhau();
            doimatkhau.Sender(_user);
            nhung(doimatkhau);
        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTheoNgay tketheongay = new frmThongKeTheoNgay();
            tketheongay.Sender(_user);
            nhung(tketheongay);
        }
    }
}
