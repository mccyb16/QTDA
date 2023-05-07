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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NhanVienService.NhanVien_GetByAll();
            loadCombox();
        }
        public void loadCombox()
        {
            DataTable dm =QuyenService.Quyen_GetByTop("", "1=1", "ID DESC");
            comQuyen.DataSource = dm;
            comQuyen.DisplayMember = "TenQuyen";
            comQuyen.ValueMember = "ID";
        }
        public void reset()
        {
            txtDiachi.Text = null;
            txtSDT.Text = null;
            txtTen.Text = null;
            txtSoTK.Text = null;
            txtEmail.Text = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên quyền không để trống!");
                txtTen.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số điện thoại không để trống!");
                txtSDT.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Địa chỉ không để trống!");
                txtDiachi.Focus();
                return;
            }
            if (txtSoCMTND.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số CMTND không để trống!");
                txtSoCMTND.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên nhân viên không để trống!");
                txtTenNV.Focus();
                return;
            }
            NhanVienInfo obj = new NhanVienInfo();
            obj.Username = txtTen.Text.ToUpper();
            obj.DiaChi = txtDiachi.Text;
            obj.SoCMTND = txtSoCMTND.Text;
            obj.Ten = txtTenNV.Text;
            obj.TinhTrang = comTinhTrang.Text;
            obj.Email = txtEmail.Text;
            obj.SDT = txtSDT.Text;
            obj.Password = StringClass.Encrypt(txtPass.Text);
            obj.SoTK = txtSoTK.Text;
            obj.QuyenHan = comQuyen.SelectedValue.ToString();
            try
            {
               NhanVienService.NhanVien_Insert(obj);
                MessageBox.Show(" Đã thêm một nhân viên mới!");
                gridControl1.DataSource =NhanVienService.NhanVien_GetByAll();
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
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên quyền không để trống!");
                txtTen.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số điện thoại không để trống!");
                txtSDT.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Địa chỉ không để trống!");
                txtDiachi.Focus();
                return;
            }
            if (txtSoCMTND.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số CMTND không để trống!");
                txtSoCMTND.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên nhân viên không để trống!");
                txtTenNV.Focus();
                return;
            }
            NhanVienInfo obj = new NhanVienInfo();
            obj.Username = txtTen.Text.ToUpper();
            obj.DiaChi = txtDiachi.Text;
            obj.Email = txtEmail.Text;
            obj.SoCMTND = txtSoCMTND.Text;
            obj.Ten = txtTenNV.Text;
            obj.TinhTrang = comTinhTrang.Text;
            obj.SDT = txtSDT.Text;
            obj.Password = StringClass.Encrypt(txtPass.Text);
            obj.SoTK = txtSoTK.Text;
            obj.QuyenHan = comQuyen.SelectedValue.ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhanVienService.NhanVien_Update(obj);
                    MessageBox.Show(" Sửa thành công!");
                    gridControl1.DataSource = NhanVienService.NhanVien_GetByAll();
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
            NhanVienInfo obj = new NhanVienInfo();
            obj.Username=txtTen.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhanVienService.NhanVien_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = NhanVienService.NhanVien_GetByAll();
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
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(User);
            txtSDT.Text = gridView1.GetFocusedRowCellDisplayText(SDT);
            txtDiachi.Text = gridView1.GetFocusedRowCellDisplayText(Diachi);
            txtSoTK.Text = gridView1.GetFocusedRowCellDisplayText(SoTK);
            txtEmail.Text = gridView1.GetFocusedRowCellDisplayText(Email);
            txtSoCMTND.Text = gridView1.GetFocusedRowCellDisplayText(SoCMTND);
            txtTenNV.Text = gridView1.GetFocusedRowCellDisplayText(Ten);
            comTinhTrang.SelectedValue = gridView1.GetFocusedRowCellDisplayText(TinhTrang);
        }

        private void comQuyen_KeyDown(object sender, KeyEventArgs e)
        {
            comQuyen.DroppedDown = false;
            comQuyen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comQuyen.AutoCompleteSource = AutoCompleteSource.ListItems;
            DataTable dm = QuyenService.Quyen_GetByTop("", "1=1", "ID DESC");  
            dm.Columns.Add("ID", typeof(string));
            dm.Columns.Add("TenQuyen", typeof(string));
            comQuyen.DataSource = dm;
            comQuyen.ValueMember = "ID";
            comQuyen.DisplayMember = "TenQuyen";       
        }

        private void comQuyen_Click(object sender, EventArgs e)
        {
            loadCombox();
        }

        private void txtSoCMTND_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((int)e.KeyChar > 127)
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
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
