using SamLop.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Tonghop
{
    public partial class frmTSanPham : Form
    {
        public frmTSanPham()
        {
            InitializeComponent();
        }

        private void frmTSanPham_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TonkhoService.Tonkho_GetByTop("90000000000000", "", "ID_Sanpham DESC");
            var dt = NhomSPService.NhomSP_GetByAll();
            comNhom.DataSource = dt;
            comNhom.DisplayMember = "Ten";
            comNhom.ValueMember = "ID";
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = TonkhoService.Tonkho_GetByTop("90000000000000", "ID_NhomSP='"+comNhom.SelectedValue+"'", "ID_Sanpham DESC");
        }
    }
}
