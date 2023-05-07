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
    public partial class frmCongty : Form
    {
        public static string st = "CT";
        public frmCongty()
        {
            InitializeComponent();
        }

        private void frmCongty_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NhaCungCapService.NhaCungCap_GetByAll();     
        }
         public string MaTuDong()       
         {
                string s, snew;
                int i = 0;
                DataTable dt = NhaCungCapService.NhaCungCap_GetByTop("","1=1","ID DESC");
             if (dt.Rows.Count==0)
             {
                 return st = "CT0001";
             }
             else
             {
                 st = "CT";
                 s = dt.Rows[0]["ID"].ToString();
                 snew = s.Substring(2, 4).ToString();
                 i = int.Parse(snew); 
                 i++;
                 if (i < 10)
                     return st=st.ToString() + "000" + i.ToString();
                 else if (i >= 10 && i < 100)
                     return st=st.ToString() + "00" + i.ToString();
                 else if (i >= 100 && i < 1000)
                     return st=st.ToString() + "0" + i.ToString();
                 else
                     return st=st.ToString() + i.ToString();
             }               
        }
      
        public void reset()
         {
             txtDiachi.Text = null;
             txtSDT.Text = null;
             txtFax.Text = null;
             txtEmail.Text = null;
             txtTK.Text = null;
             txtTen.Text = null;
             txtID.Text = "CT0001";
         }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên công ty không để trống!");
                txtTen.Focus();
                return;
            }
           
            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Địa chỉ không để trống!");
                txtDiachi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số điện thoại không để trống!");
                txtSDT.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Email không để trống!");
                txtEmail.Focus();
                return;
            }
            MaTuDong();
            NhaCungCapInfo obj = new NhaCungCapInfo();
            obj.ID = st;
            obj.DiaChi = txtDiachi.Text;
            obj.Email = txtEmail.Text;
            obj.SDT = txtSDT.Text;
            obj.Fax = txtFax.Text;
            obj.SoTK = txtTK.Text;
            obj.Ten = txtTen.Text;
            try
            {
                NhaCungCapService.NhaCungCap_Insert(obj);
                MessageBox.Show(" Đã thêm một nhà cung cấp mới!");
                gridControl1.DataSource = NhaCungCapService.NhaCungCap_GetByAll();
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
                MessageBox.Show(" Tên quyền không để trống!");
                txtTen.Focus();
                return;
            }

            if (txtDiachi.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Địa chỉ không để trống!");
                txtDiachi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Số điện thoại không để trống!");
                txtSDT.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Email không để trống!");
                txtEmail.Focus();
                return;
            }
          
            NhaCungCapInfo obj = new NhaCungCapInfo();
            obj.ID = txtID.Text;
            obj.DiaChi = txtDiachi.Text;
            obj.Email = txtEmail.Text;
            obj.SDT = txtSDT.Text;
            obj.Fax = txtFax.Text;
            obj.SoTK = txtTK.Text;
            obj.Ten = txtTen.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhaCungCapService.NhaCungCap_Update(obj);
                    MessageBox.Show(" Cập nhật thành công!");
                    gridControl1.DataSource = NhaCungCapService.NhaCungCap_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           NhaCungCapInfo obj = new NhaCungCapInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhaCungCapService.NhaCungCap_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = NhaCungCapService.NhaCungCap_GetByAll();
                    reset();
                }
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(Ten);
            txtSDT.Text = gridView1.GetFocusedRowCellDisplayText(SDT);
            txtDiachi.Text = gridView1.GetFocusedRowCellDisplayText(DiaChi);
            txtTK.Text = gridView1.GetFocusedRowCellDisplayText(SoTK);
            txtFax.Text = gridView1.GetFocusedRowCellDisplayText(Fax);
            txtEmail.Text = gridView1.GetFocusedRowCellDisplayText(Email);
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID); 
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
