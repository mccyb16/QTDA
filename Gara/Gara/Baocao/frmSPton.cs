using SamLop.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Baocao
{
    public partial class frmSPton : Form
    {
        public frmSPton()
        {
            InitializeComponent();
        }

        private void frmSPton_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TonkhoService.Tonkho_GetByTop("90000000000000", "", "ID_Sanpham DESC");
            
            
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = TonkhoService.Tonkho_GetByTop("90000000000000", "ID_NhomSP='" + comNhom.SelectedValue + "'", "ID_Sanpham DESC");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = TonkhoService.Tonkho_GetByTop("90000000000000", "", "ID_Sanpham DESC");
        }

        private void comNhom_Click(object sender, EventArgs e)
        {
            var dt = NhomSPService.NhomSP_GetByAll();
            comNhom.DataSource = dt;
            comNhom.DisplayMember = "Ten";
            comNhom.ValueMember = "ID";
        }

        private void butint_Click(object sender, EventArgs e)
        {
            if(comNhom.Text=="")
            {
                DataTable dt = TonkhoService.Tonkho_GetByTop("90000000000000", "", "ID_Sanpham DESC");
                Report.Report.Type = 6;
                Report.Report.dt = dt;
                Report.Report frm = new Report.Report();
                frm.Show();
            }
            else
            {
               DataTable  dt = TonkhoService.Tonkho_GetByTop("90000000000000", "ID_NhomSP='" + comNhom.SelectedValue + "'", "ID_Sanpham DESC");
               Report.Report.Type = 6;
               Report.Report.dt = dt;
               Report.Report frm = new Report.Report();
               frm.Show();
            }
            
         
        }
    }
}
