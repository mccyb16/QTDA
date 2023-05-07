using SamLop.Business;
using SamLop.Common;
using SamLop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Chucnangkhac
{
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void frmDoimatkhau_Load(object sender, EventArgs e)
        {
            txtTen.Text = frmMenu.isName.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtPasscu.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Nhập đầy đủ thông tin!");
                txtPasscu.Focus();
                return;
            }
            if (txtPass1.Text.Trim().Equals(""))
            {
                MessageBox.Show("  Nhập đầy đủ thông tin!");
                txtPass1.Focus();
                return;
            }
            if (txtPass2.Text.Trim().Equals(""))
            {
                MessageBox.Show("  Nhập đầy đủ thông tin!");
                txtPass2.Focus();
                return;
            }
            if (txtPasscu.Text != frmMenu.isPass)
            {
                MessageBox.Show("  Nhập lại mật khẩu!");
                txtPasscu.Text = null;
                txtPasscu.Focus();
                return;
            }
            if (txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("  Hai mật khẩu không khớp!");
                txtPass1.Text = null;
                txtPass2.Text = null;
                txtPass1.Focus();
                return;
            }
            try
            {
                NhanVienInfo obj = new NhanVienInfo();
                obj.Username = frmMenu.isName;
                obj.Password = StringClass.Encrypt(txtPass2.Text);
                NhanVienService.NhanVien_DoiMatKhau(obj);
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                this.Close();
                this.Hide();
                frmLogin fr = new frmLogin();
                fr.Show();
            }
            catch
            {
                MessageBox.Show("Gặp sự cố!");
                txtPasscu.Text = null;
                txtPass1.Text = null;
                txtPass2.Text = null;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtPasscu.Text = null;
            txtPass1.Text = null;
            txtPass2.Text = null;
        }
    }
}
