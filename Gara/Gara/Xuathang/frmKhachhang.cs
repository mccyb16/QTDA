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

namespace SamLop.Xuathang
{
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txtDiachi.Text = null;
            txtSDT.Text = null;
            txtSoTK.Text = null;
            txtID.Text = null;
            textBoxX1.Text = null;
            txtEmail.Text = null;
            txtTen.Text = null;
            txtMaST.Text = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource = KhachHangService.KhachHang_GetByTop("","","ID DESC");
       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số CMTND không được để trống!");
                txtID.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên khách hàng không để trống!");
                txtSDT.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Địa chỉ không để trống!");
                txtDiachi.Focus();
                return;
            }
            KhachHangInfo obj = new KhachHangInfo();
            obj.ID = txtID.Text;
            obj.DiaChi = txtDiachi.Text;
            obj.Email = txtEmail.Text;
            obj.SDT = txtSDT.Text;
            obj.TenKhachHang = txtTen.Text;
            obj.SoTK = txtSoTK.Text;
            obj.NganHang = textBoxX1.Text;
            obj.MaST = txtMaST.Text;
            try
            {
                KhachHangService.KhachHang_Insert(obj);
                MessageBox.Show(" Đã thêm một khách hàng mới!");
                gridControl1.DataSource = KhachHangService.KhachHang_GetByTop("", "", "ID DESC");
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số CMTND không được để trống!");
                txtID.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên khách hàng không để trống!");
                txtSDT.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Địa chỉ không để trống!");
                txtDiachi.Focus();
                return;
            }
            KhachHangInfo obj = new KhachHangInfo();
            obj.ID = txtID.Text;
            obj.DiaChi = txtDiachi.Text;
            obj.Email = txtEmail.Text;
            obj.SDT = txtSDT.Text;
            obj.TenKhachHang = txtTen.Text;
            obj.SoTK = txtSoTK.Text;
            obj.NganHang = textBoxX1.Text;
            obj.MaST = txtMaST.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    KhachHangService.KhachHang_Update(obj);
                    MessageBox.Show(" Thay đổi thông tin khách hàng thành công!");
                    gridControl1.DataSource = KhachHangService.KhachHang_GetByTop("", "", "ID DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            KhachHangInfo obj = new KhachHangInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    KhachHangService.KhachHang_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = KhachHangService.KhachHang_GetByTop("", "", "ID DESC");
                    reset();
                }

            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtSDT.Text = gridView1.GetFocusedRowCellDisplayText(SDT);
            txtDiachi.Text = gridView1.GetFocusedRowCellDisplayText(DiaChi);
            txtSoTK.Text = gridView1.GetFocusedRowCellDisplayText(SoTK);
            txtEmail.Text = gridView1.GetFocusedRowCellDisplayText(Email);
            textBoxX1.Text = gridView1.GetFocusedRowCellDisplayText(NganHang);
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(TenKhachHang);
            txtMaST.Text = gridView1.GetFocusedRowCellDisplayText(MaST);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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

        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaST_KeyPress(object sender, KeyPressEventArgs e)
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
