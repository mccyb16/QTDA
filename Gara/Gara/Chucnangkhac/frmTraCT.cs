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

namespace SamLop.Chucnangkhac
{
   
    public partial class frmTraCT : Form
    {
        private static string macc = "";
        public frmTraCT()
        {
            InitializeComponent();
        }

        private void butMaKH_Click(object sender, EventArgs e)
        {
            frmCongty frm = new frmCongty();
            frm.Show();
        }

        private void frmTraCT_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='0'", "");
            DataTable dm = HoaDonNhapService.HoaDonNhap_GetByAll();
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "ID_NhaCC";
            comMaKH.ValueMember = "ID_NhaCC";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTien.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tiền trả không để trống!");
                txtTien.Focus();
                return;
            }

            TranoInfo obj = new TranoInfo();
            obj.Thuoctinh = "0";
            obj.ID_Thanhtoan = comMaKH.SelectedValue.ToString();
            obj.Sotien = txtTien.Text;
            obj.ID_Nhanvien = frmMenu.isName.ToUpper();
            obj.Ghichu = txtGhichu.Text;
            obj.Ngaytra = DateTime.Now.ToString("dd/MM/yyyy");
            try
            {
                TranoService.Trano_Insert(obj);
                MessageBox.Show(" Chấp nhận thanh toán!");
                gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='0'", "");
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
            macc = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTien.Text = gridView1.GetFocusedRowCellDisplayText(Sotien);
            txtGhichu.Text = gridView1.GetFocusedRowCellDisplayText(Ghichu);
            comMaKH.Text = gridView1.GetFocusedRowCellDisplayText(ID_Thanhtoan);
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
            obj.ID = macc;
            obj.Thuoctinh = "0";
            obj.ID_Thanhtoan = comMaKH.SelectedValue.ToString();
            obj.Sotien = txtTien.Text;
            obj.NguoiCapNhat = frmMenu.isName.ToUpper();
            obj.Ghichu = txtGhichu.Text;
            obj.NgayCapNhat = DateTime.Now.ToString("dd/MM/yyyy");
            try
            {
                TranoService.Trano_Update(obj);
                MessageBox.Show(" Sửa thành công!");
                gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='0'", "");
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
                reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TranoInfo obj = new TranoInfo();
            obj.ID = macc;

            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TranoService.Trano_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = TranoService.Trano_GetByTop("", "Thuoctinh='0'", "");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố!");
                reset();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable dm = HoaDonNhapService.HoaDonNhap_GetByAll();
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "ID_NhaCC";
            comMaKH.ValueMember = "ID_NhaCC";
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }
    }
}
