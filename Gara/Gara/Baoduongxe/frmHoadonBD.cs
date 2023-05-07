using CrystalDecisions.Shared;
using SamLop.Business;
using SamLop.Data;
using SamLop.Nhaphang;
using SamLop.Report;
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
    public partial class frmHoadonBD : Form
    {
        public static string st = "HBD";
        public frmHoadonBD()
        {
            InitializeComponent();
            this.dateEdit1.CustomFormat = "yyyy-MM-dd";
        }
        public string MaTuDong()
        {
            string s, snew;
            int i = 0;
            DataTable dt = HoaDonBaoTriService.HoaDonBaoTri_GetByTop("", "1=1", "ID DESC");
            if (dt.Rows.Count == 0)
            {
                return st = "HBD0000001";
            }
            else
            {
                st = "HBD";
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
        private void frmHoadonBD_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = HoaDonBaoTriService.HoaDonBaoTri_GetByTop("", "1=1", "ID ");
            loadCombox();
            dateEdit1.Text = DateTime.Now.ToString( "yyyy-MM-dd");
        }
        public void loadCombox()
        {
            DataTable dm = XeBaoTriService.XeBaoTri_GetByTop("", "Tinhtrang= '0'", "");
            comXe.DataSource = dm;
            comXe.DisplayMember = "ID";
            comXe.ValueMember = "ID";
        }
        public void reset()
        {
            
            txtID.Text = "Mã tự sinh";
            txtTongTien.Text = "0";
            txtPhuphi.Text = "0";
            txtCongviec.Text = "";
            txtQuyen.Text = null;
            txtTrang.Text = null;
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void butKhachHang_Click(object sender, EventArgs e)
        {
            frmXeBD frm = new frmXeBD();
            frm.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            loadCombox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tổng tiền hãy điền 0!");
                txtTongTien.Focus();
                return;
            }
            Chuyenngay date = new Chuyenngay();
            HoaDonBaoTriInfo obj = new HoaDonBaoTriInfo();
            MaTuDong();
            obj.ID = st;
            obj.ID_NhanVien = frmMenu.isName.ToUpper();
            obj.ID_Xe = comXe.SelectedValue.ToString();
            obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
            obj.Phuphi = txtPhuphi.Text;
            obj.TongTien = txtTongTien.Text;
            obj.CongViec = txtCongviec.Text;
            obj.Quyen = txtQuyen.Text;
            obj.Trang = txtTrang.Text;
            try
            {
                HoaDonBaoTriService.HoaDonBaoTri_Insert(obj);
                MessageBox.Show(" Đã thêm một hóa đơn mới!");
                gridControl1.DataSource = HoaDonBaoTriService.HoaDonBaoTri_GetByAll();
                reset();
            }
            catch{
                MessageBox.Show(" Xảy ra sự cố!");
            }
               
            
      
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTongTien.Text = gridView1.GetFocusedRowCellDisplayText(TongTien);
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            dateEdit1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhap);
            txtPhuphi.Text = gridView1.GetFocusedRowCellDisplayText(Phuphi);
            txtQuyen.Text = gridView1.GetFocusedRowCellDisplayText(Quyen);
            txtTrang.Text = gridView1.GetFocusedRowCellDisplayText(Trang);
            comXe.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_Xe);
            txtCongviec.Text = gridView1.GetFocusedRowCellDisplayText(CongViec);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tổng tiền hãy điền 0!");
                txtTongTien.Focus();
                return;
            }
        
            try
            {
                Chuyenngay date = new Chuyenngay();
                HoaDonBaoTriInfo obj = new HoaDonBaoTriInfo();
                obj.ID = txtID.Text;
                obj.NguoiCapNhat = frmMenu.isName.ToUpper();
                obj.ID_Xe = comXe.SelectedValue.ToString();
                obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
                obj.NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy");
                obj.Phuphi = txtPhuphi.Text;
                obj.TongTien = txtTongTien.Text;
                obj.CongViec = txtCongviec.Text;
                obj.Quyen = txtQuyen.Text;
                obj.Trang = txtTrang.Text;
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   HoaDonBaoTriService.HoaDonBaoTri_Update(obj);
                    MessageBox.Show(" Update thành công!");
                    gridControl1.DataSource =HoaDonBaoTriService.HoaDonBaoTri_GetByAll();
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
            
            try
            {
                HoaDonBaoTriInfo obj = new HoaDonBaoTriInfo();
                obj.ID = txtID.Text; 
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonBaoTriService.HoaDonBaoTri_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = HoaDonBaoTriService.HoaDonBaoTri_GetByAll();
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
            DialogResult dialogResult = MessageBox.Show("Bạn chỉ in hóa đơn nếu xe đã bảo trì xong(Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    XeBaoTriInfo obj = new XeBaoTriInfo();
                    obj.ID = comXe.SelectedValue.ToString();
                    XeBaoTriService.XeBaoTri_Updatexong(obj);
                  
                }
                catch
                { }
                XeBaoTriInfo tn = new XeBaoTriInfo();
                tn.ID = gridView1.GetFocusedRowCellDisplayText(ID_Xe);
                var dt = XeBaoTriService.XeBaoTri_GetById(tn);
                string makh = dt.Rows[0]["ID_KhachHang"].ToString();
                var dn = ChiTietBaoTriService.Bangnokhachhang_GetByTop("", "ID='" + makh + "'", "");
                string tongtien = dn.Rows[0]["nocu"].ToString();
                //tong tien no la
                string nocu = (Convert.ToInt32(tongtien) - Convert.ToInt32(txtTongTien.Text)).ToString();
                
                //truyen du lieu
                Report.Report.dt = HoaDonBaoTriService.V_HOADONBAOTRI_GetByTop("","ID='"+txtID.Text+"'","");
                Report.Report.Type = 1;
                Report.Report.tongtien = txtTongTien.Text;
                Report.Report.nocu = nocu;
                Report.Report.tongtra = tongtien;
                int tiennocu = Convert.ToInt32(tongtien);
                if ( tiennocu<0)
                {
                     Report.Report.bangchu="Âm";
                     tiennocu=tiennocu*(-1);
                     ConvertNumToStr objConvert = new ConvertNumToStr();
                    Report.Report.bangchu= Report.Report.bangchu+ objConvert.converNumToString(objConvert.slipArray(tiennocu.ToString()));
                }
                else{
                    ConvertNumToStr objConvert = new ConvertNumToStr();
                    Report.Report.bangchu = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(objConvert.converNumToString(objConvert.slipArray(tiennocu.ToString())).ToLower()); 
                }
                
                Report.Report frm = new Report.Report();
                frm.Show();
            }

       
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

        private void txtPhuphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }
    }
}
