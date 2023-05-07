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
    public partial class frmNhomSP : Form
    {
        public frmNhomSP()
        {
            InitializeComponent();
        }

        private void frmNhomSP_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NhomSPService.NhomSP_GetByTop("", "1=1", "ID ");
        }
        public void reset()
        {
            txtID.Text = null;
            txtTen.Text = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên nhóm không để trống!");
                txtTen.Focus();
                return;
            }

            if (txtID.Text.Length < 3)
            {
                MessageBox.Show(" Độ dài của mã sản phẩm là 3!");
                txtID.Focus();
                return;
            }


            NhomSPInfo obj = new NhomSPInfo();
            obj.ID = txtID.Text.ToUpper();
            obj.Ten = txtTen.Text;
            try
            {
                NhomSPService.NhomSP_Insert(obj);
                MessageBox.Show(" Đã thêm một nhóm mới!");
                gridControl1.DataSource = NhomSPService.NhomSP_GetByAll();
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellDisplayText(ID);
            txtTen.Text = gridView1.GetFocusedRowCellDisplayText(Ten);  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên nhóm không để trống!");
                txtTen.Focus();
                return;
            }

            if (txtID.Text.Length < 3)
            {
                MessageBox.Show(" Độ dài của mã sản phẩm là 3!");
                txtID.Focus();
                return;
            }


            NhomSPInfo obj = new NhomSPInfo();
            obj.ID = txtID.Text.ToUpper();
            obj.Ten = txtTen.Text;
            try
            {
                NhomSPService.NhomSP_Update(obj);
                MessageBox.Show(" Sửa thành công!");
                gridControl1.DataSource = NhomSPService.NhomSP_GetByAll();
                reset();
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
                reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NhomSPInfo obj = new NhomSPInfo();
            obj.ID = txtID.Text;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa (Yes/ No)", "Nguy hiểm!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhomSPService.NhomSP_Delete(obj);
                    MessageBox.Show(" Xóa thành công!");
                    gridControl1.DataSource = NhomSPService.NhomSP_GetByAll();
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

