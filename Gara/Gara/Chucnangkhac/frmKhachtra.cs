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

namespace SamLop.Chucnangkhac
{
    public partial class frmKhachtra : Form
    {
        public static string ma = "";
        public frmKhachtra()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txtGhichu.Text = null;
            txtTien.Text = null;
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

        private void frmKhachtra_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='1'", "");
            DataTable dm = KhachHangService.KhachHang_GetByAll();
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "TenKhachHang";
            comMaKH.ValueMember = "ID";
        }
        public int kiemtra ()
        {
            try{
            DataTable dt = HoaDonXuatService.HoaDonXuat_GetByTop("1000000000", "id_KhachHang='" + comMaKH.SelectedValue.ToString() + "'", "");
            DataTable dt1 = ChiTietBaoTriService.CHIETXEBAOTRI_GetByTop("1000000000", "id_KhachHang='" + comMaKH.SelectedValue.ToString() + "'", "");
            int tong = dt.Rows.Count + dt1.Rows.Count;
           
                if (tong > 0)
                    return 1;
                else
                    return 0;
            }
            catch{
                return 0;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        { 
            int ok=kiemtra ();
            if (ok==0)
            {
                MessageBox.Show(" Kiểm tra lại thông tin khách hàng!");
                return;
            }
            else {
                if (txtTien.Text.Trim().Equals(""))
                {
                    MessageBox.Show(" Tiền trả không để trống!");
                    txtTien.Focus();
                    return;
                }

                TranoInfo obj = new TranoInfo();
                obj.Thuoctinh = "1";
                obj.ID_Thanhtoan = comMaKH.SelectedValue.ToString();
                obj.Sotien = txtTien.Text;
                obj.ID_Nhanvien = frmMenu.isName.ToUpper();
                obj.Ghichu = txtGhichu.Text;
                obj.Ngaytra = DateTime.Now.ToString("dd-MM-yyyy");
                try
                {
                    TranoService.Trano_Insert(obj);
                    MessageBox.Show(" Chấp nhận thanh toán!");
                    gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='1'", "");
                    reset();
                }
                catch
                {
                    MessageBox.Show(" Xảy ra sự cố!");
                    reset();
                }
            }         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tiền trả không để trống!");
                txtTien.Focus();
                return;
            }

            TranoInfo obj = new TranoInfo();
            obj.ID = ma;
            obj.Thuoctinh = "1";
            obj.ID_Thanhtoan = comMaKH.SelectedValue.ToString();
            obj.Sotien = txtTien.Text;
            obj.NguoiCapNhat = frmMenu.isName.ToUpper();
            obj.Ghichu = txtGhichu.Text;
            obj.NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy");
            try
            {
                TranoService.Trano_Update(obj);
                MessageBox.Show(" Sửa thành công!");
                gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='1'", "");
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
                reset();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            ma = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTien.Text = gridView1.GetFocusedRowCellDisplayText(Sotien);
            txtGhichu.Text = gridView1.GetFocusedRowCellDisplayText(Ghichu);
            comMaKH.Text = gridView1.GetFocusedRowCellDisplayText(ID_Thanhtoan);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TranoInfo obj = new TranoInfo();
            obj.ID = ma;
            
            try
            {
                 DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                     TranoService.Trano_Delete(obj);
                     MessageBox.Show(" Xóa thành công!");
                     gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='1'", "");
                     reset();
                 }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
                reset();
            }
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }
    }
}
