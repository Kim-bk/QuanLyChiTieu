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
            load();
        }

        public void ResetData()
        {
            txtSearch.Text = "";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = from dm in db.tbDanhMucs
                         where dm.danhmuc_name.Contains(txtSearch.Text)
                         orderby dm.danhmuc_id descending
                         select new { 
                         dm.danhmuc_id,
                         dm.danhmuc_name
                         };
            grvListDanhMuc.DataSource = search;
            grvListDanhMuc.Columns[1].HeaderText = "Tên danh mục";
                          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var text = txtSearch.Text;
            bool found = false;
            foreach(var item in db.tbDanhMucs.ToList())
            {
                if(item.danhmuc_name == text)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }

            if(found)
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
