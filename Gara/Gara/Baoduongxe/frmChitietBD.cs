using SamLop.Business;
using SamLop.Data;
using SamLop.Nhaphang;
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
    public partial class frmChitietBD : Form
    {
        public static int ok;
        public static string giatri="0";
        public static string id;
        public static int dk=0;
        public static int dieuhuong = 1;
        public frmChitietBD()
        {
            InitializeComponent();
            this.datetime1.CustomFormat = "yyyy-MM-dd";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmHoadonBD frm = new frmHoadonBD();
            frm.Show();
        }

        private void butMaSP_Click(object sender, EventArgs e)
        {
            frmSanpham frm = new frmSanpham();
            frm.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var dt = HoaDonBaoTriService.HoaDonBaoTri_GetByAll();
            comMaHD.DataSource = dt;
            comMaHD.DisplayMember = "ID";
            comMaHD.ValueMember = "ID";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var dt = ChiTietNhapService.ChiTietNhap_GetByAll();
            comMaSP.DataSource = dt;
            comMaSP.DisplayMember = "ID_SanPham";
            comMaSP.ValueMember = "ID_SanPham";
        }

        private void frmChitietBD_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietBaoTriService.ChiTietBaoTri_GetByAll();
            var dt = ChiTietNhapService.ChiTietNhap_GetByAll();
            comMaSP.DataSource = dt;
            comMaSP.DisplayMember = "ID_SanPham";
            comMaSP.ValueMember = "ID_SanPham";
            var dt1 = HoaDonBaoTriService.HoaDonBaoTri_GetByAll();
            comMaHD.DataSource = dt1;
            comMaHD.DisplayMember = "ID";
            comMaHD.ValueMember = "ID";
            comHD.DataSource = dt1;
            comHD.DisplayMember = "ID";
            comHD.ValueMember = "ID";
            datetime1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void reset()
        {
            txtSoluong.Text = "1";
            txtChitiet.Text = null;
            txtDongia.Text = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        public int kiemtra(string sl)
        {
            DataTable kt = TonkhoService.Tonkho_GetByTop("1", "ID_SanPham='" + sl + "'", "");
            int con = Convert.ToInt32(kt.Rows[0]["TONKHO"].ToString());
            if (dieuhuong == 1)
            {
                con = Convert.ToInt32(kt.Rows[0]["TONKHO"].ToString());
            }
            else
            {
                con = Convert.ToInt32(kt.Rows[0]["TONKHO"].ToString()) + Convert.ToInt32(gridView1.GetFocusedRowCellDisplayText(SoLuong));
            }

            if (con < Convert.ToInt32(txtSoluong.Text))
            {
                MessageBox.Show("Số sản phẩm còn là " + con + "!");
                txtSoluong.Text = null;
                return 0;
            }
            return 1;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dieuhuong = 1;
            if (txtSoluong.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số lượng không để trống!");
                txtSoluong.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đơn giá !");
                txtDongia.Focus();
                return;
            }
            ok = kiemtra(comMaSP.SelectedValue.ToString());
            if (ok == 0)
            {
                return;
            }
            else
            {
                Chuyenngay date = new Chuyenngay();
                ChiTietBaoTriInfo obj = new ChiTietBaoTriInfo();
                obj.ID = comMaHD.SelectedValue.ToString();
                obj.ID_NhanVien = frmMenu.isName.ToUpper();
                obj.SoLuong = txtSoluong.Text;
                obj.ID_SanPham = comMaSP.SelectedValue.ToString();
                obj.DonGia = txtDongia.Text;
                obj.Chitietbaohanh = txtChitiet.Text;
                obj.NgayNhap = date.ngaynhap(datetime1.Text);
                try
                {
                    obj.ThanhTien = (Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtDongia.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Kiểu giá trị số lượng hoặc đơn giá không được chấp nhận !");
                }
                try
                {
                    ChiTietBaoTriService.ChiTietBaoTri_Insert(obj);
                    MessageBox.Show(" Đã thêm thành công!");
                    gridControl1.DataSource = ChiTietBaoTriService.ChiTietBaoTri_GetByAll();
                    reset();
                }
                catch
                {
                    MessageBox.Show("Xảy ra sự cố !");
                    reset();
                }
            }

        }

        private void comMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt2 = ChiTietNhapService.ChiTietNhap_GetByTop("", "ID_SanPham='" + comMaSP.SelectedValue + "'", "");
                txtDongia.Text = dt2.Rows[0]["GiaMoi"].ToString();
            }
            catch
            {
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            comMaSP.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_SanPham);
            comMaHD.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID);
            txtSoluong.Text = gridView1.GetFocusedRowCellDisplayText(SoLuong);
            txtDongia.Text = gridView1.GetFocusedRowCellDisplayText(DonGia);
            datetime1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhap);
            txtChitiet.Text = gridView1.GetFocusedRowCellDisplayText(Chitietbaohanh);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dieuhuong = 0;
            if (txtSoluong.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số lượng không để trống!");
                txtSoluong.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đơn giá !");
                txtDongia.Focus();
                return;
            }
            ok = kiemtra(comMaSP.SelectedValue.ToString());
            if (ok == 0)
            {
                return;
            }
            else
            {
                Chuyenngay date = new Chuyenngay();
                ChiTietBaoTriInfo obj = new ChiTietBaoTriInfo();
                obj.ID = comMaHD.SelectedValue.ToString();
                obj.NguoiCapNhat = frmMenu.isName.ToUpper();
                obj.SoLuong = txtSoluong.Text;
                obj.ID_SanPham = comMaSP.SelectedValue.ToString();
                obj.DonGia = txtDongia.Text;
                obj.Chitietbaohanh = txtChitiet.Text;
                obj.NgayNhap = date.ngaynhap(datetime1.Text);
                obj.NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy");
                try
                {
                    obj.ThanhTien = (Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtDongia.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Kiểu giá trị số lượng hoặc đơn giá không được chấp nhận !");
                }
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ChiTietBaoTriService.ChiTietBaoTri_Update(obj);
                        MessageBox.Show(" Đã sửa thành công!");
                        gridControl1.DataSource = ChiTietBaoTriService.ChiTietBaoTri_GetByAll();
                        reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Xảy ra sự cố !");
                    reset();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ChiTietBaoTriInfo obj = new ChiTietBaoTriInfo();
            obj.ID = comMaHD.SelectedValue.ToString();
            obj.ID_SanPham = comMaSP.SelectedValue.ToString();

            try
            {
                obj.ThanhTien = (Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtDongia.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Kiểu giá trị số lượng hoặc đơn giá không được chấp nhận !");
            }
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiTietBaoTriService.ChiTietBaoTri_Delete(obj);
                    MessageBox.Show(" Đã xóa thành công!");
                    gridControl1.DataSource = ChiTietBaoTriService.ChiTietBaoTri_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra sự cố !");
                reset();
            }

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var dt = HoaDonBaoTriService.HoaDonBaoTri_GetByAll();
            comHD.DataSource = dt;
            comHD.DisplayMember = "ID";
            comHD.ValueMember = "ID";
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietBaoTriInfo obj = new ChiTietBaoTriInfo();
                obj.ID = comHD.SelectedValue.ToString();
                DataTable dt = ChiTietBaoTriService.ChiTietBaoTri_Sum(obj);
                labelX7.Text = dt.Rows[0]["Tong"].ToString() + " VNĐ";
            }
            catch
            { }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            dk = 2;
            frmphuphi frm = new frmphuphi();
            frm.Show();
            ChiTietBaoTriInfo obj = new ChiTietBaoTriInfo();
            obj.ID = comHD.SelectedValue.ToString();
            DataTable dt = ChiTietBaoTriService.ChiTietBaoTri_Sum(obj);
            giatri = dt.Rows[0]["Tong"].ToString();
            id = comHD.SelectedValue.ToString(); 
        }
    }
}
              
