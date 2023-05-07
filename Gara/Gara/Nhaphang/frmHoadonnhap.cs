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
    public partial class frmHoadonnhap : Form
    {
        public static string st="HDN";
        public frmHoadonnhap()
        {
            InitializeComponent();
            this.dateEdit1.CustomFormat = "yyyy-MM-dd";
        }

        private void butNhaCC_Click(object sender, EventArgs e)
        {
            frmCongty frm = new frmCongty();
            frm.Show();
        }

        private void frmHoadonnhap_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = HoaDonNhapService.HoaDonNhap_GetByTop("", "1=1", "ID ");
            loadCombox();
            txtNhanVien.Text = frmMenu.isName.ToUpper();
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void loadCombox()
        {
            DataTable dm = NhaCungCapService.NhaCungCap_GetByTop("", "", "ID DESC");
            comNhaCC.DataSource = dm;
            comNhaCC.DisplayMember = "Ten";
            comNhaCC.ValueMember = "ID";
        }
        public string MaTuDong()
        {
            string s, snew;
            int i = 0;
            DataTable dt = HoaDonNhapService.HoaDonNhap_GetByTop("", "1=1", "ID DESC");
            if (dt.Rows.Count == 0)
            {
                return st = "HDN0000001";
            }
            else
            {
                st = "HDN";
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
                MessageBox.Show(" Tổng tiền không để trống!");
                txtTongTien.Focus();
                return;
            }
            if (txtDatra.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Chưa trả hãy điền 0!");
                txtDatra.Focus();
                return;
            }
            if (comNhaCC.SelectedValue.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp !");
                return;
            }
            Chuyenngay date = new Chuyenngay();
            HoaDonNhapInfo obj = new HoaDonNhapInfo();
            MaTuDong();
            obj.ID = st;
            obj.ID_NhanVien = txtNhanVien.Text;
            obj.ID_NhaCC = comNhaCC.SelectedValue.ToString();
            obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
            obj.TongTien = txtTongTien.Text;
            obj.Datra = txtDatra.Text;
            obj.Quyen = txtQuyen.Text;
            obj.Trang = txtTrang.Text;
            try
            {
                HoaDonNhapService.HoaDonNhap_Insert(obj);
                MessageBox.Show(" Đã thêm một hóa đơn mới!");
                gridControl1.DataSource = HoaDonNhapService.HoaDonNhap_GetByTop("", "", "ID DESC");
                reset();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi");
                reset();
            }   
         
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {   
            loadCombox();
        }
        public void reset()
        {
            txtDatra.Text ="0";
            txtID.Text = "Mã tự sinh";
            txtTongTien.Text ="0";
            txtTrang.Text = null;
            txtQuyen.Text = null;
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tổng tiền không để trống!");
                txtTongTien.Focus();
                return;
            }
            if (comNhaCC.SelectedValue.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp!");
                return;
            }
            if (txtDatra.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Chưa trả hãy điền 0!");
                txtDatra.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            HoaDonNhapInfo obj = new HoaDonNhapInfo(); 
            obj.ID =txtID.Text;
            obj.ID_NhanVien = txtNhanVien.Text;
            obj.NguoiCN = txtNhanVien.Text;
            obj.ID_NhaCC = comNhaCC.SelectedValue.ToString();
            obj.TongTien = txtTongTien.Text ;
            obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
            obj.Datra = txtDatra.Text;
            obj.Quyen = txtQuyen.Text;
            obj.Trang = txtTrang.Text;
            obj.NgayCapNhap = DateTime.Now.ToString("dd-MM-yyyy");
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonNhapService.HoaDonNhap_Update(obj);
                    MessageBox.Show(" Cập nhật thành công!");
                    gridControl1.DataSource = HoaDonNhapService.HoaDonNhap_GetByTop("", "", "ID DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi");
                reset();
            }        
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTongTien.Text = gridView1.GetFocusedRowCellDisplayText(Tongtien);
            txtDatra.Text = gridView1.GetFocusedRowCellDisplayText(Datra);
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            dateEdit1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhap);
            comNhaCC.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_NhaCC);
            txtQuyen.Text = gridView1.GetFocusedRowCellDisplayText(Quyen);
            txtTrang.Text = gridView1.GetFocusedRowCellDisplayText(Trang);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HoaDonNhapInfo obj = new HoaDonNhapInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonNhapService.HoaDonNhap_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = HoaDonNhapService.HoaDonNhap_GetByTop("", "", "ID DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void butint_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "Mã tự sinh")
            {
                MessageBox.Show(" Bạn chưa chọn hóa đơn!");
                return;
            }
            Report.Report.tongtien = "0";
            Report.Report.tongtra = "0";
            Report.Report.bangchu = "";
            //truyen du lieu
            Report.Report.dt = ChiTietBaoTriService.TATTANTATVENHAPHANG_GetByTop("", "ID_HoaDon='" + txtID.Text + "'", "");
            Report.Report.Type = 2;
            Report.Report.tongtien = txtTongTien.Text;
            Report.Report.tongtra = (Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(txtDatra.Text)).ToString();
            int tiennocu = Convert.ToInt32(Report.Report.tongtra);
            if (tiennocu < 0)
            {
                Report.Report.bangchu = "Âm";
                tiennocu = tiennocu * (-1);
                ConvertNumToStr objConvert = new ConvertNumToStr();
                Report.Report.bangchu = Report.Report.bangchu + objConvert.converNumToString(objConvert.slipArray(tiennocu.ToString()));
            }
            else
            {
                ConvertNumToStr objConvert = new ConvertNumToStr();
                Report.Report.bangchu = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(objConvert.converNumToString(objConvert.slipArray(tiennocu.ToString())).ToLower());
            }

            Report.Report frm = new Report.Report();
            frm.Show();
            
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
