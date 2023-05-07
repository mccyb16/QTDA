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
    public partial class frmSanpham : Form
    {
        public string st = "";
        public frmSanpham()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = "Mã tự động";
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "", "ID DESC");
            showNhaSX();
            showNhomSP();
            showSSX();
            showSSP();
            radioButton1.Checked = true;
        }
        public void showNhaSX()
        {
            var dt = NhaSanXuatService.NhaSanXuat_GetByTop("", "", "ID DESC");
            var dt1 = NhomSPService.NhomSP_GetByTop("", "", "ID DESC");
            comNhaSX.DataSource = dt;
            comNhaSX.DisplayMember = "TenNhaSX";
            comNhaSX.ValueMember = "ID";
        }
        public void showSSX()
        {
            var dt = NhaSanXuatService.NhaSanXuat_GetByTop("", "", "ID DESC");
            var dt1 = NhomSPService.NhomSP_GetByTop("", "", "ID DESC");
            comSSX.DataSource = dt;
            comSSX.DisplayMember = "TenNhaSX";
            comSSX.ValueMember = "ID";
        }
        public void showNhomSP()
        {
            var dt = NhomSPService.NhomSP_GetByTop("", "", "ID DESC");
            comNhomSP.DataSource = dt;
            comNhomSP.DisplayMember = "Ten";
            comNhomSP.ValueMember = "ID";
        }
        public void showSSP()
        {
            var dt = NhomSPService.NhomSP_GetByTop("","","ID DESC");
            comSSP.DataSource = dt;
            comSSP.DisplayMember = "Ten";
            comSSP.ValueMember = "ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Text = null;
        }

        private void butNhaSX_Click(object sender, EventArgs e)
        {
            frmNhaSX frm = new frmNhaSX();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNhomSP frm = new frmNhomSP();
            frm.Show();
        }
        public void reset()
        {
            radioButton1.Checked = true;
            txtTen.Text = null;
            txtChitiet.Text = null;
            txtGhichu.Text = null;
            txtGiaban.Text = "0";
            showNhaSX();
            showNhomSP();
        }
        public string MaTuDong()
        {
            string s, snew;
            int i = 0;
            try {
                DataTable dt = SanPhamService.SanPham_GetByTop("", "ID_NhomSP='" + comNhomSP.SelectedValue.ToString() + "'", "ID DESC");
                if (dt.Rows.Count == 0)
                {
                    return st = "" + st + "" + "000001";
                }
                else
                {
                    s = dt.Rows[0]["ID"].ToString();
                    snew = s.Substring(3, 6).ToString();
                    i = int.Parse(snew);
                    i++;
                    
                    if (i < 10)
                    {
                        return st = st.ToString() + "00000" + i.ToString();
                    }
                        
                    else if (i >= 10 && i < 100)
                        return st = st.ToString() + "0000" + i.ToString();
                    else if (i >= 100 && i < 1000)
                        return st = st.ToString() + "000" + i.ToString();
                    else if (i >= 100 && i < 10000)
                        return st = st.ToString() + "00" + i.ToString();
                    else if (i >= 100 && i < 100000)
                        return st = st.ToString() + "0" + i.ToString();
                    else
                        return st = st.ToString() + i.ToString();
                }
            }
            
            catch
            {
                MessageBox.Show(" Mã này bạn phải nập bằng tay!");
                radioButton2.Checked=true;
                return st = "";
            }
        }
    
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Mã sản phẩm không để trống!");
                txtID.Focus();
                return;
            }
            if (txtGiaban.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Giá bán không để trống!");
                txtGiaban.Focus();
                return;
            }

            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên sản phẩm không để trống!");
                txtTen.Focus();
                return;
            }
            
            SanPhamInfo obj = new SanPhamInfo();
            if (radioButton1.Checked==true)
            {
                string manhom = comNhomSP.SelectedValue.ToString();
                st = manhom;
                MaTuDong();
                obj.ID = st;
            }
            else
            {
                obj.ID = txtID.Text.ToUpper();
            }
          
            obj.TenSanPham = txtTen.Text;
            obj.Giaban = txtGiaban.Text;
            obj.ID_NhaSX = comNhaSX.SelectedValue.ToString();
            obj.Donvitinh = comDonvitinh.Text;
            obj.Diengiai = txtChitiet.Text;
            obj.Ghichu= txtGhichu.Text;
            obj.ID_NhomSP =comNhomSP.SelectedValue.ToString();
            try {
                SanPhamService.SanPham_Insert(obj);
                MessageBox.Show(" Đã thêm một sản phẩm mới!");
                gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "", "ID DESC");
                reset();
            }
            catch
            {
                MessageBox.Show(" Bạn cần nhập mã sản phẩm bằng tay!");
                radioButton2.Checked=true;
                reset();
            }
                
               
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            showNhaSX();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            showNhomSP();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Mã sản phẩm không để trống!");
                txtID.Focus();
                return;
            }

            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên sản phẩm không để trống!");
                txtTen.Focus();
                return;
            }

            SanPhamInfo obj = new SanPhamInfo();
            obj.ID = txtID.Text;
            obj.Giaban = txtGiaban.Text;
            obj.TenSanPham = txtTen.Text;
            obj.Donvitinh = comDonvitinh.Text;
            obj.Diengiai = txtChitiet.Text;
            obj.Ghichu = txtGhichu.Text;
           try  
           {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                SanPhamService.SanPham_Update(obj);
                MessageBox.Show(" Update thành công!");
                gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "", "ID DESC");
                reset();
                }
            }
            catch
            {
                MessageBox.Show("Update thất bại!");
                radioButton2.Checked = true;
                reset();
            }
                
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtGiaban.Text = gridView1.GetFocusedRowCellDisplayText(Giaban);
            txtGhichu.Text = gridView1.GetFocusedRowCellDisplayText(Ghichu);
            txtChitiet.Text = gridView1.GetFocusedRowCellDisplayText(Diengiai);
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(TenSanPham);
            comDonvitinh.Text = gridView1.GetFocusedRowCellDisplayText(Donvitinh);
            comNhaSX.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_NhaSX);
            comNhomSP.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID_NhomSP); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SanPhamInfo obj = new SanPhamInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SanPhamService.SanPham_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "", "ID DESC");
                    reset();
                }

            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (comSearch.Text == "Nhà sản xuất")
                {
                    gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "ID_NhaSX='" + comSSX.SelectedValue + "'", "ID DESC");
                }
                if (comSearch.Text == "Nhóm sản phẩm")
                {
                    gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "ID_NhomSP='" + comSSP.SelectedValue + "'", "ID DESC");
                }
                if (comSearch.Text == "Cả hai")
                {
                    gridControl1.DataSource = SanPhamService.SanPham_GetByTop("", "ID_NhomSP='" + comSSP.SelectedValue + "' and ID_NhaSX='" + comSSX.SelectedValue + "'", "ID DESC");
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            showSSP();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
           
            showSSX();
        }

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
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
