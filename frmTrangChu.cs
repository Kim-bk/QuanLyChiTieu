using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChiTieu.App_Data;

namespace QuanLyChiTieu
{
    public partial class frmTrangChu : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();

        public delegate void SendName(string name);
        public SendName Sender;
        public frmTrangChu()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Sender = new SendName(GetName);
        }

        private void GetName(string name)
        {
            lblName.Text = "Chào " + name + "!";
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
            nhung(dm);
        }

        private void nhậpChiTiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapChiTieu chitieu = new frmNhapChiTieu();
            nhung(chitieu);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string message = "Bạn có muốn đăng xuất?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dn = new frmDangNhap();
                dn.ShowDialog();
            }
            else 
            {; }
               
        }
    }
}
