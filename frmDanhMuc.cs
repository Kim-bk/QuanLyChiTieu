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
    public partial class frmDanhMuc : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            var load = from danhmuc in db.tbDanhMucs select new
            {
                danhmuc.danhmuc_name
            };
            grvDanhMuc.DataSource = load;
            grvDanhMuc.Columns[0].HeaderText = "Tên danh mục";
            grvDanhMuc.Columns[0].Width = 320;
        }
    }
}
