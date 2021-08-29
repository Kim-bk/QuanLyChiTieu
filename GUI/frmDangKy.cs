using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChiTieu.Common;

namespace QuanLyChiTieu
{
    public partial class frmDangKy : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        cls_Encrypt encrypt =  new cls_Encrypt();
        public frmDangKy()
        {
            InitializeComponent();
        }


        protected void Reset()
        {
            txtDangNhap.Text = "";
            txtFullname.Text = "";
            txtPass.Text = "";
            txtRePass.Text = "";
        }

        protected bool IsEmptyInput()
        {
            if(txtDangNhap.Text == "" ||
            txtPass.Text == "" ||
            txtRePass.Text == "" ||
            txtFullname.Text == "")
            {
                return true;
            }    
            else
                return false;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (IsEmptyInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng!");
                    txtPass.Text = "";
                    txtRePass.Text = "";
                }
                else
                {
                    tbAccount user = new tbAccount();
                    user.account_username = txtDangNhap.Text;
                    user.account_password = encrypt.MD5Hash(txtPass.Text);
                    user.account_fullname = txtFullname.Text;
                    user.account_createddate = DateTime.Now;
                    db.tbAccounts.InsertOnSubmit(user);
                    db.SubmitChanges();
                    MessageBox.Show("Tạo tài khoản thành công!");
                    Reset();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
    }
}
