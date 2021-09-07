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
        private static int _idDanhmuc = 0;
        private static int _idUser;
        public delegate void SendUser(tbAccount user);
        public SendUser Sender;
        public frmDanhMuc()
        {
            Sender = new SendUser(GetUser);
            InitializeComponent();
        }
        public void GetUser(tbAccount user)
        {
            _idUser = user.account_id;
            LoadData();
        }

        public void ResetData()
        {
            txtSearch.Text = "";
            _idDanhmuc = 0;
        }

        public void LoadData(bool isSearch = false)
        {
            if (!isSearch)
            {
                var load = from danhmuc in db.tbDanhMucs
                           where danhmuc.account_id == _idUser
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
            else
            {
                var search = from dm in db.tbDanhMucs
                             where dm.danhmuc_name.Contains(txtSearch.Text)
                             && dm.account_id == _idUser
                             orderby dm.danhmuc_id descending
                             select new
                             {
                                 dm.danhmuc_id,
                                 dm.danhmuc_name
                             };
                grvListDanhMuc.DataSource = search;
                grvListDanhMuc.Columns[0].Visible = false;
                grvListDanhMuc.Columns[1].HeaderText = "Tên danh mục";
            }
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
                foreach (var item in db.tbDanhMucs.Where(dm => dm.account_id == _idUser).ToList())
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
                    add.account_id = _idUser;
                    db.tbDanhMucs.InsertOnSubmit(add);
                    db.SubmitChanges();

                    var load = from danhmuc in db.tbDanhMucs
                               where danhmuc.account_id == _idUser
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
            if (_idDanhmuc != 0)
            {
                string message = "Bạn có muốn xóa danh mục này";
                string title = "Xóa";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    var delete = (from dm in db.tbDanhMucs 
                                  where dm.danhmuc_id == _idDanhmuc 
                                  && dm.account_id == _idUser 
                                  select dm).FirstOrDefault();
                    db.tbDanhMucs.DeleteOnSubmit(delete);
                    db.SubmitChanges();

                    LoadData();
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
            _idDanhmuc = Convert.ToInt32(grvListDanhMuc.CurrentRow.Cells[0].Value);
           // txtSearch.Text = (grvListDanhMuc.CurrentRow.Cells[1].Value).ToString();
        }
     
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
                LoadData();
        }
    }
}
