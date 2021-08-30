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

namespace QuanLyChiTieu.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        private static tbAccount _user;
        public delegate void SendUser(tbAccount user);
        public SendUser Sender;
        cls_Encrypt encrypt = new cls_Encrypt();
        public frmDoiMatKhau()
        {
            InitializeComponent();
            Sender = new SendUser(GetUser);
        }
        public void GetUser(tbAccount user)
        {
            _user = user;
        }

        public void ResetData()
        {
            txtNewPass.Text = "";
            txtOldPass.Text = "";
            txtRePass.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == "" || txtOldPass.Text == "" || txtRePass.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!");
                ResetData();
            }
            else
            {
                if (encrypt.MD5Hash(txtOldPass.Text) != _user.account_password)
                {
                    MessageBox.Show("Nhập mật khẩu cũ chưa đúng!");
                    ResetData();
                }
                else if(txtRePass.Text != txtNewPass.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa chính xác!");
                    ResetData();
                }
                else
                {
                    var change = (from us in db.tbAccounts
                                  where us.account_id == _user.account_id
                                  select us).FirstOrDefault();
                    change.account_password = encrypt.MD5Hash(txtNewPass.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    ResetData();
                }    
            }    

        }
    }
}
