using SamLop.Business;
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
    public partial class frmThongtincanhan : Form
    {
        public frmThongtincanhan()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Nhập đầy đủ thông tin!");
                txtEmail.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Nhập đầy đủ thông tin!");
                txtSDT.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Nhập đầy đủ thông tin!");
                txtDiachi.Focus();
                return;
            }
            if (txtPass.Text!=frmMenu.isPass)
            {
                MessageBox.Show(" Sai mật khẩu");
                txtPass.Focus();
                return;
                restart();
            }
            try {
                NhanVienInfo obj = new NhanVienInfo();
                obj.Username = frmMenu.isName;
                obj.DiaChi = txtDiachi.Text;
                obj.Email = txtEmail.Text;
                obj.SDT = txtSDT.Text;
                obj.SoTK = txtTaiK.Text;
                NhanVienService.NhanVien_Doithongtincanhan(obj);
                MessageBox.Show(" Đổi thông tin thành công");
                this.Hide();
                frmLogin fr = new frmLogin();
                fr.Show();
            }
            catch
            {
                restart();
            }
        
        }
        public void restart()
        {
            try
            {
                NhanVienInfo obj = new NhanVienInfo();
                obj.Username = frmMenu.isName;
                DataTable db = NhanVienService.NhanVien_GetById(obj);
                txtDiachi.Text = db.Rows[0]["Diachi"].ToString();
                txtEmail.Text = db.Rows[0]["Email"].ToString();
                txtSDT.Text = db.Rows[0]["SDT"].ToString();
                txtTaiK.Text = db.Rows[0]["SoTK"].ToString();
            }
            catch
            {

            }       
        }
        private void frmThongtincanhan_Load(object sender, EventArgs e)
        {
            try {
                txtTen.Text = frmMenu.isName.ToUpper();
                NhanVienInfo obj = new NhanVienInfo();
                obj.Username = frmMenu.isName;
                 DataTable db=  NhanVienService.NhanVien_GetById(obj);
                 txtDiachi.Text = db.Rows[0]["Diachi"].ToString();
                 txtEmail.Text = db.Rows[0]["Email"].ToString();
                 txtSDT.Text = db.Rows[0]["SDT"].ToString();
                 txtTaiK.Text = db.Rows[0]["SoTK"].ToString();
            }
            catch
            {

            }          
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                txtTen.Text = frmMenu.isName.ToUpper();
                NhanVienInfo obj = new NhanVienInfo();
                obj.Username = frmMenu.isName;
                DataTable db = NhanVienService.NhanVien_GetById(obj);
                txtDiachi.Text = db.Rows[0]["Diachi"].ToString();
                txtEmail.Text = db.Rows[0]["Email"].ToString();
                txtSDT.Text = db.Rows[0]["SDT"].ToString();
                txtTaiK.Text = db.Rows[0]["SoTK"].ToString();
            }
            catch
            {

            }       
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
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
