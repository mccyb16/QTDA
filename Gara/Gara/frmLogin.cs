using SamLop.Business;
using SamLop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên đăng nhập không được để trống!");
                txtID.Focus();
                return;
            }
            if (txtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Mật khẩu không được để trống!");
                txtPass.Focus();
                return;
            }
            try
            {
                DataTable qh2 = NhanVienService.NhanVien_GetByTop("", "[TinhTrang]='1' and Username='" + txtID.Text + "' and Password='" +StringClass.Encrypt(txtPass.Text) + "'", "");
                if (qh2.Rows.Count > 0)
                {
                    this.Hide();
                    frmMenu.isLogin = qh2.Rows[0]["QuyenHan"].ToString();
                    frmMenu.isPass = txtPass.Text;
                    frmMenu.isName = txtID.Text.ToUpper();
                    frmMenu.isLoginDate = DateTime.Now.ToLongTimeString();
                    frmMenu m = new frmMenu();
                    m.Show();
                    MessageBox.Show("Chúc mừng " + txtID.Text.ToUpper() + " đã đăng nhập thành công !");
                }
            }

            catch
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu?");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống (Yes/ No)?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Hide();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar > 127)
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }
    }
}
