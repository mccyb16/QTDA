using SamLop.Baoduongxe;
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

namespace SamLop
{
    public partial class frmphuphi : Form
    {
        public static int tien =0;
        public static int tien1 = 0;
        public frmphuphi()
        {
            InitializeComponent();
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tien = Convert.ToInt32(txttien.Text);
            if(frmChitietxuat.dk==1)
            {
                HoaDonXuatInfo obj1 = new HoaDonXuatInfo();
                obj1.ID = frmChitietxuat.id;
                try {
                    tien1 = Convert.ToInt32(frmChitietxuat.giatien);
                }
                catch
                {
                    tien1 = 0;
                }
                int tongtien = tien1 + Convert.ToInt32(txttien.Text);
                obj1.TongTien = tongtien.ToString();
                obj1.Phuphi = tien.ToString();
                HoaDonXuatService.HoaDonXuat_Tien(obj1);
                MessageBox.Show("Hóa đơn " + frmChitietxuat.id + "có tổng tiền " + tongtien.ToString() + "VNĐ và " + tien.ToString() + " VNĐ phụ phí ");
                frmChitietxuat.dk = 0;
            }   
            //okokokok
            if (frmChitietBD.dk==2)
            {
                HoaDonBaoTriInfo obj = new HoaDonBaoTriInfo();
                obj.ID = frmChitietBD.id;
                try
                {
                    tien1 = Convert.ToInt32(frmChitietBD.giatri);
                }
                catch
                {
                    tien1 = 0;
                }
                obj.TongTien = (tien1 + Convert.ToInt32(tien)).ToString();
                obj.Phuphi = tien.ToString();
                HoaDonBaoTriService.HoaDonBaoTri_Tien(obj);
                MessageBox.Show("Hóa đơn " + frmChitietxuat.id + "có tổng tiền " + obj.TongTien + "VNĐ và " + tien.ToString() + " VNĐ phụ phí ");
                frmChitietBD.dk =0;
            }
            this.Hide();
        }
    }
}
