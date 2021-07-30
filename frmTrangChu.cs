using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class frmTrangChu : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmTrangChu()
        {
            InitializeComponent();
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
    }
}
