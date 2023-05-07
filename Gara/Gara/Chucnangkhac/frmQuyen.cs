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
    public partial class frmQuyen : Form
    {
        public string ma = "";
       public frmQuyen()
        {
            InitializeComponent();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = QuyenService.Quyen_GetByAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTen.Text= null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên quyền không để trống!");
                txtTen.Focus();
                return;
            }
            QuyenInfo obj = new  QuyenInfo();
            obj.TenQuyen =txtTen.Text;
            try
            {
                QuyenService.Quyen_Insert(obj);
                MessageBox.Show(" Đã thêm một quyền mới!");
                gridControl1.DataSource = QuyenService.Quyen_GetByAll();
                txtTen.Text=null;
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                txtTen.Text=null;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            ma = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(Ten);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên quyền không để trống!");
                txtTen.Focus();
                return;
            }
            QuyenInfo obj = new QuyenInfo();
            obj.TenQuyen = txtTen.Text;
            obj.ID = ma;
            try
            {
                QuyenService.Quyen_Update(obj);
                MessageBox.Show(" Sửa thành công!");
                gridControl1.DataSource = QuyenService.Quyen_GetByAll();
                txtTen.Text = null;
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                txtTen.Text = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QuyenInfo obj = new QuyenInfo();
            obj.ID = ma;
            try
            {
                QuyenService.Quyen_Delete(obj);
                MessageBox.Show(" Xóa thành công!");
                gridControl1.DataSource = QuyenService.Quyen_GetByAll();
                txtTen.Text = null;
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                txtTen.Text = null;
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
    }
}
