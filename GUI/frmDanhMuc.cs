using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu.GUI
{
    public partial class frmDanhMuc : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        private static int _id = 0;
        public frmDanhMuc()
        {
            InitializeComponent();
            load();
        }

        public void ResetData()
        {
            txtSearch.Text = "";
            _id = 0;
        }

        public void load()
        {
            var load = from danhmuc in db.tbDanhMucs
                       orderby danhmuc.danhmuc_id descending
                       select new
                       {
                           danhmuc.danhmuc_id,
                           danhmuc.danhmuc_name
                       };
            grvListDanhMuc.DataSource = load;
            grvListDanhMuc.Columns[0].Visible = false;
            grvListDanhMuc.Columns[1].HeaderText = "Tên danh mục";
        }
    

        private void btnThem_Click(object sender, EventArgs e)
        {
            var text = txtSearch.Text;
            if (text == "")
            {
                ;
            }
            else
            {
                bool found = false;
                foreach (var item in db.tbDanhMucs.ToList())
                {
                    if (item.danhmuc_name == text)
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }

                if (found)
                {
                    MessageBox.Show("Danh mục này đã có sẵn!");
                }
                else
                {
                    tbDanhMuc add = new tbDanhMuc();
                    add.danhmuc_name = text;
                    db.tbDanhMucs.InsertOnSubmit(add);
                    db.SubmitChanges();

                    var load = from danhmuc in db.tbDanhMucs
                               orderby danhmuc.danhmuc_id descending
                               select new
                               {
                                   danhmuc.danhmuc_id,
                                   danhmuc.danhmuc_name
                               };
                    grvListDanhMuc.DataSource = load;
                    grvListDanhMuc.Columns[0].Visible = false;
                    grvListDanhMuc.Columns[1].HeaderText = "Tên danh mục";
                    ResetData();
                    MessageBox.Show("Thêm danh mục mới thành công!");
                }
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                string message = "Bạn có muốn xóa danh mục này";
                string title = "Xóa";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    var delete = (from dm in db.tbDanhMucs where dm.danhmuc_id == _id select dm).FirstOrDefault();
                    db.tbDanhMucs.DeleteOnSubmit(delete);
                    db.SubmitChanges();

                    var load = from danhmuc in db.tbDanhMucs
                               orderby danhmuc.danhmuc_id descending
                               select new
                               {
                                   danhmuc.danhmuc_id,
                                   danhmuc.danhmuc_name
                               };

                    grvListDanhMuc.DataSource = load;
                    grvListDanhMuc.Columns[0].Visible = false;
                    grvListDanhMuc.Columns[1].HeaderText = "Tên danh mục";
                    ResetData();
                }
                else
                {
                    // Do something  
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh mục để xóa!");
            }
        }

        private void grvListDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(grvListDanhMuc.CurrentRow.Cells[0].Value);
           // txtSearch.Text = (grvListDanhMuc.CurrentRow.Cells[1].Value).ToString();
        }



        private void btnSua_Click(object sender, EventArgs e)
        {

        }

 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = from dm in db.tbDanhMucs
                         where dm.danhmuc_name.Contains(txtSearch.Text)
                         orderby dm.danhmuc_id descending
                         select new
                         {
                             dm.danhmuc_id,
                             dm.danhmuc_name
                         };
            grvListDanhMuc.DataSource = search;
            grvListDanhMuc.Columns[1].HeaderText = "Tên danh mục";
        }

    }
}
