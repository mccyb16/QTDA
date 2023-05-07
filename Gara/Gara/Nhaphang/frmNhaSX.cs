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
    public partial class frmNhaSX : Form
    {
        public static string st = "NSX";
        public frmNhaSX()
        {
            InitializeComponent();
        }

        private void frmNhaSX_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NhaSanXuatService.NhaSanXuat_GetByAll();   
        }
        public void reset()
        {
            txtTen.Text=null;
            txtMota.Text=null;
            txtID.Text = "Mã tự động";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên Nhà sản xuất không để trống!");
                txtTen.Focus();
                return;
            }
            MaTuDong();
            NhaSanXuatInfo obj = new NhaSanXuatInfo();
            obj.ID = st;
            obj.Mota = txtMota.Text;
            obj.TenNhaSX = txtTen.Text;
       
            try
            {
                NhaSanXuatService.NhaSanXuat_Insert(obj);
                MessageBox.Show(" Đã thêm một nhà sản xuất mới!");
                gridControl1.DataSource = NhaSanXuatService.NhaSanXuat_GetByAll();
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên Nhà sản xuất không để trống!");
                txtTen.Focus();
                return;
            }
            MaTuDong();
            NhaSanXuatInfo obj = new NhaSanXuatInfo();
            obj.ID = txtID.Text;
            obj.Mota = txtMota.Text;
            obj.TenNhaSX = txtTen.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhaSanXuatService.NhaSanXuat_Update(obj);
                    MessageBox.Show(" Sửa thành công!");
                    gridControl1.DataSource = NhaSanXuatService.NhaSanXuat_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }
        public string MaTuDong()
        {
            string s, snew;
            int i = 0;
            DataTable dt = NhaSanXuatService.NhaSanXuat_GetByTop("", "1=1", "ID DESC");
            if (dt.Rows.Count == 0)
            {
                return st = "NSX00001";
            }
            else
            {
                st = "NSX";
                s = dt.Rows[0]["ID"].ToString();
                snew = s.Substring(3, 5).ToString();
                i = int.Parse(snew);
                i++;
                if (i < 10)
                    return st = st.ToString() + "0000" + i.ToString();
                else if (i >= 10 && i < 100)
                    return st = st.ToString() + "000" + i.ToString();
                else if (i >= 100 && i < 1000)
                    return st = st.ToString() + "00" + i.ToString();
                else if (i >= 1000 && i < 10000)
                    return st = st.ToString() + "0" + i.ToString();
                else
                    return st = st.ToString() + i.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            NhaSanXuatInfo obj = new NhaSanXuatInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhaSanXuatService.NhaSanXuat_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = NhaSanXuatService.NhaSanXuat_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(TenNhaSX);
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtMota.Text = gridView1.GetFocusedRowCellDisplayText(Mota);    
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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
