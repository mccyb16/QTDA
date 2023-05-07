using SamLop.Business;
using SamLop.Data;
using SamLop.Xuathang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Baoduongxe
{
    public partial class frmXeBD : Form
    {
        public static string ngaynhan = "";
        public frmXeBD()
        {
            InitializeComponent();
            this.dateEdit1.CustomFormat = "yyyy-MM-dd";
        }
        public void reset()
        {
            txtID.Text = null;
            txtMota.Text = null;
            txtYeuCau.Text = null;
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void butMaKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable dm = KhachHangService.KhachHang_GetByAll();
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "TenKhachHang";
            comMaKH.ValueMember = "ID";

        }

        private void frmXeBD_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = XeBaoTriService.XeBaoTri_GetByAll();
            DataTable dm = KhachHangService.KhachHang_GetByAll();
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "TenKhachHang";
            comMaKH.ValueMember = "ID";
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Biển số xe không để trống!");
                txtID.Focus();
                return;
            }

            if (txtYeuCau.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Yêu cầu không để trống!");
                txtYeuCau.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            XeBaoTriInfo obj = new XeBaoTriInfo();
            obj.ID = txtID.Text;
            obj.NgayNhap = DateTime.Now.ToString("dd-MM-yyyy");
            obj.ID_KhachHang = comMaKH.SelectedValue.ToString();
            obj.YeuCau = txtYeuCau.Text;
            obj.Mota = txtMota.Text;
            obj.TinhTrang = "0";
            obj.NgayNhan = date.ngaynhap(dateEdit1.Text);
            obj.ID_NhanVien = frmMenu.isName.ToUpper();
            try {
                XeBaoTriService.XeBaoTri_Insert(obj);
                MessageBox.Show(" Đã thêm một xe mới!");
                gridControl1.DataSource = XeBaoTriService.XeBaoTri_GetByAll();
                reset();
            }
            catch
            {
                MessageBox.Show("Xảy ra sự cố!");
            }
               
         
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
                ngaynhan = gridView1.GetFocusedRowCellDisplayText(NgayNhap);
                comMaKH.Text = gridView1.GetFocusedRowCellDisplayText(ID_KhachHang);
                txtYeuCau.Text = gridView1.GetFocusedRowCellDisplayText(YeuCau);
                txtMota.Text = gridView1.GetFocusedRowCellDisplayText(Mota);
                dateEdit1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhan); 
            }
            catch
            { }
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Biển số xe không để trống!");
                txtID.Focus();
                return;
            }

            if (txtYeuCau.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Yêu cầu không để trống!");
                txtYeuCau.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            XeBaoTriInfo obj = new XeBaoTriInfo();
            obj.ID = txtID.Text;
            obj.NgayNhap = date.ngaynhap(dateEdit1.Text) ;
            obj.ID_KhachHang = comMaKH.SelectedValue.ToString();
            obj.YeuCau = txtYeuCau.Text;
            obj.Mota = txtMota.Text;
            obj.TinhTrang = "0";
            obj.NgayNhan = dateEdit1.Text;
            obj.NguoiCapNhat = frmMenu.isName.ToUpper();
            obj.NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy");
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không? (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    XeBaoTriService.XeBaoTri_Update(obj);
                    MessageBox.Show(" Update thành công!");
                    gridControl1.DataSource = XeBaoTriService.XeBaoTri_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra sự cố!");
            }
               
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XeBaoTriInfo obj = new XeBaoTriInfo();
            obj.ID = txtID.Text;
            obj.NgayNhap = ngaynhan;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    XeBaoTriService.XeBaoTri_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = XeBaoTriService.XeBaoTri_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra sự cố!");
            }
               
        }
    }
}