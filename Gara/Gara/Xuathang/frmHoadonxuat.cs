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

namespace SamLop.Xuathang
{
    public partial class frmHoadonxuat : Form
    {
        public static string st = "HDX";
        public frmHoadonxuat()
        {
            InitializeComponent();
            this.dateEdit1.CustomFormat = "yyyy-MM-dd";
        }


        private void frmHoadonxuat_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
            loadCombox();
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void loadCombox()
        {
            DataTable dm = KhachHangService.KhachHang_GetByTop("", "", "ID DESC");
            comKhachhang.DataSource = dm;
            comKhachhang.DisplayMember = "TenKhachHang";
            comKhachhang.ValueMember = "ID";
        }
        public void reset()
        {
            txtDatra.Text = "0";
            txtID.Text = "Mã tự sinh";
            txtTongTien.Text = "0";
            txtPhuphi.Text = "0";
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void butKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            loadCombox();
        }
        public string MaTuDong()
        {
            string s, snew;
            int i = 0;
            DataTable dt = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
            if (dt.Rows.Count == 0)
            {
                return st = "HDX0000001";
            }
            else
            {
                st = "HDX";
                s = dt.Rows[0]["ID"].ToString();
                snew = s.Substring(3, 7).ToString();
                i = int.Parse(snew);
                i++;
                if (i < 10)
                    return st = st.ToString() + "000000" + i.ToString();
                else if (i >= 10 && i < 100)
                    return st = st.ToString() + "00000" + i.ToString();
                else if (i >= 100 && i < 1000)
                    return st = st.ToString() + "0000" + i.ToString();
                else if (i >= 1000 && i < 10000)
                    return st = st.ToString() + "000" + i.ToString();
                else if (i >= 10000 && i < 100000)
                    return st = st.ToString() + "00" + i.ToString();
                else if (i >= 10000 && i < 1000000)
                    return st = st.ToString() + "0" + i.ToString();
                else
                    return st = st.ToString() + i.ToString();
            }    
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tổng tiền hãy điền 0!");
                txtTongTien.Focus();
                return;
            }
            if (txtDatra.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Chưa trả hãy điền 0!");
                txtDatra.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            HoaDonXuatInfo obj = new HoaDonXuatInfo();
            MaTuDong();
            obj.ID = st;
            obj.ID_NhanVien = frmMenu.isName.ToUpper();
            obj.ID_KhachHang = comKhachhang.SelectedValue.ToString();
            obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
            obj.Phuphi = txtPhuphi.Text;
            obj.TongTien = txtTongTien.Text;
            obj.Datra = txtDatra.Text;
            obj.Quyen = txtQuyen.Text;
            obj.Trang = txtTrang.Text;

            try {
                HoaDonXuatService.HoaDonXuat_Insert(obj);
                MessageBox.Show(" Đã thêm một hóa đơn mới!");
                gridControl1.DataSource = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");

            }    
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTongTien.Text = gridView1.GetFocusedRowCellDisplayText(TongTien);
            txtDatra.Text = gridView1.GetFocusedRowCellDisplayText(Datra);
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            dateEdit1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhap);
            txtPhuphi.Text = gridView1.GetFocusedRowCellDisplayText(Phuphi);
            txtQuyen.Text = gridView1.GetFocusedRowCellDisplayText(Quyen);
            txtTrang.Text = gridView1.GetFocusedRowCellDisplayText(Trang);
            comKhachhang.SelectedValue = gridView1.GetFocusedRowCellDisplayText(Id_KhachHang);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tổng tiền hãy điền 0!");
                txtTongTien.Focus();
                return;
            }
            if (txtDatra.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Chưa trả hãy điền 0!");
                txtDatra.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            HoaDonXuatInfo obj = new HoaDonXuatInfo();
            obj.ID = txtID.Text;
            obj.NguoiCapNhat = frmMenu.isName.ToUpper();
            obj.ID_KhachHang = comKhachhang.SelectedValue.ToString();
            obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
            obj.NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy");
            obj.Phuphi = txtPhuphi.Text;
            obj.TongTien = txtTongTien.Text;
            obj.Datra = txtDatra.Text;
            obj.Quyen = txtQuyen.Text;
            obj.Trang = txtTrang.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonXuatService.HoaDonXuat_Update(obj);
                    MessageBox.Show(" Update thành công!");
                    gridControl1.DataSource = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HoaDonXuatInfo obj = new HoaDonXuatInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonXuatService.HoaDonXuat_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
            }
        }

        private void butint_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "Mã tự sinh")
            {
                MessageBox.Show(" Bạn chưa chọn hóa đơn!");
                return;
            }
            //tính tong tien
            Report.Report.Type = 3;
            var dn = ChiTietBaoTriService.Bangnokhachhang_GetByTop("", "ID='" +comKhachhang.SelectedValue + "'", "");
            string conno = dn.Rows[0]["nocu"].ToString();
            Report.Report.conno = conno;
            string nocu = (Convert.ToInt32(conno) + Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(txtDatra.Text)).ToString();
            Report.Report.nocu = nocu;
            Report.Report.dt = ChiTietBaoTriService.XUATHANGTATTANTAT_GetByTop("","ID='"+ gridView1.GetFocusedRowCellDisplayText(ID)+"'","");
            //doc so tien
            int tiennocu = Convert.ToInt32(conno);
            if (tiennocu < 0)
            {
                Report.Report.bangchu = "Âm";
                tiennocu = tiennocu * (-1);
                docso objConvert = new docso();
                Report.Report.bangchu = Report.Report.bangchu + objConvert.DocSo(tiennocu).ToLower();
            }
            else
            {
                docso objConvert = new docso();
                Report.Report.bangchu =  objConvert.DocSo(tiennocu).ToLower();
            }

            Report.Report frm = new Report.Report();
            frm.Show();
        }

        private void txtPhuphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtDatra_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtQuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }


        private void txtTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }
    }
}