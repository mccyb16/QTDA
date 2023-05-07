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

namespace SamLop.Nhaphang
{
   
    public partial class frmChitietnhap : Form
    {
        public static string giatien = "0";
        public frmChitietnhap()
        {
            InitializeComponent();
            this.datetime1.CustomFormat = "yyyy-MM-dd";
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void frmChitietnhap_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietNhapService.ChiTietNhap_GetByTop("", "", "ID_HoaDon DESC");
            var dt = SanPhamService.SanPham_GetByTop("", "", "ID DESC");
            comMaSP.DataSource = dt;
            comMaSP.DisplayMember = "TenSanPham";
            comMaSP.ValueMember = "ID";
            var dt1 = HoaDonNhapService.HoaDonNhap_GetByTop("", "", "ID DESC");
            comMaHD.DataSource = dt1;
            comMaHD.DisplayMember = "ID";
            comMaHD.ValueMember = "ID";
            comHD.DataSource = dt1;
            comHD.DisplayMember = "ID";
            comHD.ValueMember = "ID";
            datetime1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void reset()
        {
            txtSoluong.Text = "1";
            txtGiaCu.Text = "0";
            txtGiaMoi.Text = "0";
            gridControl1.DataSource = ChiTietNhapService.ChiTietNhap_GetByTop("", "", "ID_HoaDon DESC");

        }
            
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSoluong.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số lượng không để trống!");
                txtSoluong.Focus();
                return;
            }
            if (txtGiaCu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đơn giá !");
                txtGiaCu.Focus();
                return;
            }
            if (txtGiaMoi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đơn giá !");
                txtGiaMoi.Focus();
                return;
            }
            try {
                if (Convert.ToUInt32(txtGiaCu.Text) > Convert.ToUInt32(txtGiaMoi.Text))
                {
                    MessageBox.Show("Giá bán thấp hơn giá nhập !");
                    txtGiaMoi.Focus();
                    return;
                }
            }
            catch
            {
                    MessageBox.Show("Tiền là kiểu số!");     
            }
            //Insert
            Chuyenngay date = new Chuyenngay();
            ChiTietNhapInfo obj = new ChiTietNhapInfo();
            obj.ID_HoaDon = comMaHD.SelectedValue.ToString();
            obj.ID_NhanVien = frmMenu.isName.ToUpper();
            obj.SoLuong = txtSoluong.Text;
            obj.ID_SanPham = comMaSP.SelectedValue.ToString();
            obj.GiaCu = txtGiaCu.Text;
            obj.GiaMoi = txtGiaMoi.Text;
            obj.NgayNhap = date.ngaynhap(datetime1.Text);
            try {
                obj.ThanhTien = (Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtGiaCu.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Kiểu giá trị số lượng hoặc đơn giá không được chấp nhận !");
            }
            try {
                ChiTietNhapService.ChiTietNhap_Insert(obj);
                MessageBox.Show(" Đã thêm thành công!");
                SanPhamInfo obj1 = new SanPhamInfo();
                obj1.ID = comMaSP.SelectedValue.ToString();
                obj1.Giaban = txtGiaMoi.Text;
                DataTable dx = SanPhamService.SanPham_GetById(obj1);
                if (Convert.ToInt32(txtGiaMoi.Text) != Convert.ToInt32(dx.Rows[0]["Giaban"].ToString()))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật bảng giá cho sản phẩm này(Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SanPhamService.SanPham_Updategia(obj1);
                        MessageBox.Show(" Đã update thành công!");
                    }

                }
                gridControl1.DataSource = ChiTietNhapService.ChiTietNhap_GetByTop("", "", "ID_HoaDon DESC");
                reset(); 
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
            }
                  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSoluong.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số lượng không để trống!");
                txtSoluong.Focus();
                return;
            }
            if (txtGiaCu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đơn giá !");
                txtGiaCu.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            ChiTietNhapInfo obj = new ChiTietNhapInfo();
            obj.ID_HoaDon = comMaHD.SelectedValue.ToString();
            obj.NguoiCapNhat = frmMenu.isName.ToUpper();
            obj.SoLuong = txtSoluong.Text;
            obj.ID_SanPham = comMaSP.SelectedValue.ToString();
            obj.ThanhTien = (Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtGiaCu.Text)).ToString();
            obj.GiaCu = txtGiaCu.Text;
            obj.GiaMoi = txtGiaMoi.Text;
            obj.NgayNhap = date.ngaynhap(datetime1.Text);
            obj.NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy");
              try  
           {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiTietNhapService.ChiTietNhap_Update(obj);
                    MessageBox.Show(" Đã update thành công!");
                    //Update gia
                    SanPhamInfo obj1 = new SanPhamInfo();
                    obj1.ID = comMaSP.SelectedValue.ToString();
                    obj1.Giaban = txtGiaMoi.Text;
                    DataTable dx = SanPhamService.SanPham_GetById(obj1);
                    if (Convert.ToInt32(txtGiaMoi.Text) != Convert.ToInt32(dx.Rows[0]["Giaban"].ToString()))
                    {
                        DialogResult dialogResult1 = MessageBox.Show("Bạn có muốn cập nhật bảng giá cho sản phẩm này(Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SanPhamService.SanPham_Updategia(obj1);
                            MessageBox.Show(" Đã update thành công!");
                        }

                    }
                    reset();
                }

            }
            catch
            {
                MessageBox.Show("Xảy ra sự cố !");
                reset();
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ChiTietNhapInfo obj = new ChiTietNhapInfo();
            obj.ID_HoaDon = comMaHD.SelectedValue.ToString();
            obj.ID_SanPham = comMaSP.SelectedValue.ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiTietNhapService.ChiTietNhap_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = ChiTietNhapService.ChiTietNhap_GetByTop("", "", "ID_HoaDon DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var dt = HoaDonNhapService.HoaDonNhap_GetByTop("", "", "ID DESC");
            comMaHD.DataSource = dt;
            comMaHD.DisplayMember = "ID";
            comMaHD.ValueMember = "ID";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmHoadonnhap frm = new frmHoadonnhap();
            frm.Show();
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {
            comMaSP.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_SanPham);
            comMaHD.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_HoaDon);
            txtSoluong.Text = gridView1.GetFocusedRowCellDisplayText(SoLuong);
            txtGiaCu.Text = gridView1.GetFocusedRowCellDisplayText(GiaCu);
            txtGiaMoi.Text = gridView1.GetFocusedRowCellDisplayText(GiaMoi);
            datetime1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhap);     
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var dt2 = HoaDonNhapService.HoaDonNhap_GetByAll();
            comHD.DataSource = dt2;
            comHD.DisplayMember = "ID";
            comHD.ValueMember = "ID";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var dt = SanPhamService.SanPham_GetByTop("", "", "ID DESC");
            comMaSP.DataSource = dt;
            comMaSP.DisplayMember = "TenSanPham";
            comMaSP.ValueMember = "ID";
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietNhapInfo obj = new ChiTietNhapInfo();
                obj.ID_HoaDon = comHD.SelectedValue.ToString();
                DataTable dt = ChiTietNhapService.ChiTietNhap_Sum(obj);
                if (dt.Rows[0]["Tong"].ToString()=="")
                {
                    labelX7.Text = "0 VNĐ";
                }
                else
                    labelX7.Text = dt.Rows[0]["Tong"].ToString() + " VNĐ";
            }
            catch
            { }
        }

        private void butMaSP_Click(object sender, EventArgs e)
        {
            frmSanpham frm = new frmSanpham();
            frm.Show();
        }

        private void comMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                SanPhamInfo obj = new SanPhamInfo();
                obj.ID = comMaSP.SelectedValue.ToString();
                DataTable dt = SanPhamService.SanPham_GetById(obj);
                txtGiaMoi.Text = dt.Rows[0]["Giaban"].ToString();
            }
            catch { }
            
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            Chuyenngay date = new Chuyenngay();
            string datetu = date.ngaynhap(dateTu.Text);
            string dateden = date.ngaynhap(dateDen.Text);
         //  a = DateTime.ParseExact(dateTu.Text, "yyyy-MM-dd ", null);
       //    b = DateTime.ParseExact(dateDen.Text, "yyyy-MM-dd ", null);
          // MessageBox.Show(a.ToString());
            gridControl1.DataSource = ChiTietNhapService.ChiTietNhap_GetByTop("100000000000000000", "Ngaynhap >= '" + datetu + "' and Ngaynhap <='" + dateden + "'", "");
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtGiaMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtGiaCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            try { 
                 //Tinh tong tien
                ChiTietNhapInfo obj = new ChiTietNhapInfo();
                obj.ID_HoaDon = comHD.SelectedValue.ToString();
                DataTable dt = ChiTietNhapService.ChiTietNhap_Sum(obj);
                giatien = dt.Rows[0]["Tong"].ToString();
                if (giatien=="")
                {
                    giatien = "0";
                }
                //
                HoaDonNhapInfo obj1= new HoaDonNhapInfo();
                obj1.ID = comHD.SelectedValue.ToString();
                obj1.TongTien = giatien;
                HoaDonNhapService.HoaDonNhap_Tien(obj1);
                MessageBox.Show(" Tổng tiền hóa đơn " + comHD.SelectedValue + " là " + giatien + " VNĐ!");
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
            }
           
        }
    }
}
