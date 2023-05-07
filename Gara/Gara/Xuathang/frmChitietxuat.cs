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
    public partial class frmChitietxuat : Form
    {
        public static string giatien="0";
        public static int ok;
        public static string id;
        public static int dk=0;
        public static int dieuhuong=1;
        public frmChitietxuat()
        {
            InitializeComponent();
            this.dateEdit1.CustomFormat = "yyyy-MM-dd";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmHoadonxuat frm = new frmHoadonxuat();
            frm.Show();
        }

        private void butMaSP_Click(object sender, EventArgs e)
        {
            frmSanpham frm = new frmSanpham();
            frm.Show();
        }

        private void frmChitietxuat_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietXuatService.ChiTietXuat_GetByTop("", "", "ID DESC");
            var dt = ChiTietNhapService.ChiTietNhap_GetByTop("", "", "ID_HoaDon DESC");
            comMaSP.DataSource = dt;
            comMaSP.DisplayMember = "ID_SanPham";
            comMaSP.ValueMember = "ID_SanPham";
            var dt1 = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
            comMaHD.DataSource = dt1;
            comMaHD.DisplayMember = "ID";
            comMaHD.ValueMember = "ID";
            comHD.DataSource = dt1;
            comHD.DisplayMember = "ID";
            comHD.ValueMember = "ID";
            dateEdit1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var dt = HoaDonXuatService.HoaDonXuat_GetByTop("", "", "ID DESC");
            comMaHD.DataSource = dt;
            comMaHD.DisplayMember = "ID";
            comMaHD.ValueMember = "ID";
        }
        public void reset()
        {
            txtSoluong.Text ="1";
            txtDongia.Text = "1";
            dieuhuong = 1;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        public int kiemtra(string sl)
        {

                DataTable kt = TonkhoService.Tonkho_GetByTop("1", "ID_SanPham='" + sl+ "'", "");
                int con = Convert.ToInt32(kt.Rows[0]["TONKHO"].ToString());
                    if (dieuhuong ==1)
                    {
                         con = Convert.ToInt32(kt.Rows[0]["TONKHO"].ToString());
                    }
                    else
                    {
                         con = Convert.ToInt32(kt.Rows[0]["TONKHO"].ToString()) + Convert.ToInt32(gridView1.GetFocusedRowCellDisplayText(gridColumn1));
                    }
               
                    if(con < Convert.ToInt32(txtSoluong.Text))
                    {
                        MessageBox.Show("Số sản phẩm còn là "+con+"!");
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
            
            ok=  kiemtra(comMaSP.SelectedValue.ToString());
            if(ok==0 )
            {
                return;
            }
            else
            {
                Chuyenngay date = new Chuyenngay();
                ChiTietXuatInfo obj = new ChiTietXuatInfo();
                obj.ID = comMaHD.SelectedValue.ToString();
                obj.ID_NhanVien = frmMenu.isName.ToUpper();
                obj.SoLuong = txtSoluong.Text;
                obj.ID_SanPham = comMaSP.SelectedValue.ToString();
                obj.DonGia = txtDongia.Text;
                obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
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
                    ChiTietXuatService.ChiTietXuat_Insert(obj);
                    MessageBox.Show(" Đã thêm thành công!");
                    gridControl1.DataSource = ChiTietXuatService.ChiTietXuat_GetByTop("", "1=1", "ID DESC");
                    reset();

                }
                catch
                {
                    MessageBox.Show("Xảy ra sự cố !");
                    reset();
                } 
            }            
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
             ok=  kiemtra(comMaSP.SelectedValue.ToString());
             if (ok == 0)
             {
                 return;
             }
             else
             {
                 Chuyenngay date = new Chuyenngay();
                 ChiTietXuatInfo obj = new ChiTietXuatInfo();
                 obj.ID = comMaHD.Text;
                 obj.NguoiCapNhat = frmMenu.isName.ToUpper();
                 obj.SoLuong = txtSoluong.Text;
                 obj.ID_SanPham = comMaSP.SelectedValue.ToString();
                 obj.DonGia = txtDongia.Text;
                 obj.NgayNhap = date.ngaynhap(dateEdit1.Text);
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

                         ChiTietXuatService.ChiTietXuat_Update(obj);
                         MessageBox.Show(" Đã update thành công!");
                         gridControl1.DataSource = ChiTietXuatService.ChiTietXuat_GetByTop("", "1=1", "ID DESC");
                         reset();
                     }
                 }
                 catch
                 {
                     MessageBox.Show(" Xảy ra sự cố !");
                     reset();
                 }
             }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            ChiTietXuatInfo obj = new ChiTietXuatInfo();
            obj.ID = comMaHD.SelectedValue.ToString();
            obj.ID_SanPham = comMaSP.SelectedValue.ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiTietXuatService.ChiTietXuat_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = ChiTietXuatService.ChiTietXuat_GetByTop("", "1=1", "ID DESC");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var dt2 = HoaDonXuatService.HoaDonXuat_GetByTop("", "1=1", "ID DESC");
            comHD.DataSource = dt2;
            comHD.DisplayMember = "ID";
            comHD.ValueMember = "ID";
        }

        private void comMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            comMaSP.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_SanPham);
            comMaHD.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID);
            txtSoluong.Text = gridView1.GetFocusedRowCellDisplayText(gridColumn1);
            txtDongia.Text = gridView1.GetFocusedRowCellDisplayText(DonGia);
            dateEdit1.Text = gridView1.GetFocusedRowCellDisplayText(NgayNhap); 
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietXuatInfo obj = new ChiTietXuatInfo();
                obj.ID= comHD.SelectedValue.ToString();
                DataTable dt = ChiTietXuatService.ChiTietXuat_Sum(obj);
                if (dt.Rows[0]["Tong"].ToString()=="")
                {
                    labelX7.Text =  "0 VNĐ";
                }
                else 
                    labelX7.Text = dt.Rows[0]["Tong"].ToString() + " VNĐ";
            }
            catch
            { }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var dt = ChiTietNhapService.ChiTietNhap_GetByTop("", "", "ID_HoaDon DESC");
            comMaSP.DataSource = dt;
            comMaSP.DisplayMember = "ID_SanPham";
            comMaSP.ValueMember = "ID_SanPham";
        }

        private void comMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            comMaSP.DroppedDown = false;
            comMaSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable t = new DataTable();
            t.Columns.Add("ID", typeof(int));
            t.Columns.Add("Display", typeof(string));

            for (int i = 1; i < 1000; i++)
            {
                t.Rows.Add(i, i.ToString("N0"));
            }

            comMaSP.DataSource = t;
            comMaSP.ValueMember = "ID";
            comMaSP.DisplayMember = "Display";       
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

        private void buttonX7_Click(object sender, EventArgs e)
        {
            //Tinh tien
            dk = 1;
            ChiTietXuatInfo obj = new ChiTietXuatInfo();
            obj.ID = comHD.SelectedValue.ToString();
            DataTable dt = ChiTietXuatService.ChiTietXuat_Sum(obj);
            giatien = dt.Rows[0]["Tong"].ToString();
            id = comHD.SelectedValue.ToString(); ;
            frmphuphi frm = new frmphuphi();
            frm.Show();
        }

        private void comMaSP_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
