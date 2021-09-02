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
    public partial class frmDangNhap : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        cls_Encrypt encrypt = new cls_Encrypt();
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        protected bool IsEmptyInput()
        {
            if (txtDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                return true;
            }
            else
                return false;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

      

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            string message = "Bạn có muốn thoát?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {; }
        }

        private void linklblDangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmptyInput())
                {
                    var user = (from ac in db.tbAccounts
                                where ac.account_username == txtDangNhap.Text
                                && ac.account_password == encrypt.MD5Hash(txtMatKhau.Text)
                                select ac).FirstOrDefault();

                    if (user != null)
                    {
                        this.Hide();
                        frmTrangChu trangchu = new frmTrangChu();
                        trangchu.Show();
                        trangchu.Sender(user);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                        txtDangNhap.Text = "";
                        txtMatKhau.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    txtDangNhap.Text = "";
                    txtMatKhau.Text = "";
                }

            }
            catch (Exception)
            {; }
        }
    }
}
