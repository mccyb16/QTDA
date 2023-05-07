using SamLop.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Report
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public static DataTable dt;
        public static int Type;
        public static string bangchu;
        public static string tongtien;
        public static string tungay;
        public static string denngay;
        public static string phuphi;
        public static string nocu;
        public static string hoachtoan;
        public static string tongtra;
        public static string conno;
        public static string tienmua;
        public static string tientra;
        private void Report_Load(object sender, EventArgs e)
        {
            if( Type==1)
            {
                Hoadonbaotri obj = new Hoadonbaotri();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTongtien", tongtien);
                obj.SetParameterValue("txtNocu", nocu);
                obj.SetParameterValue("txtTongtra", tongtra);
                obj.SetParameterValue("labBangchu", bangchu);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();      
            }
            if (Type == 2)
            {
                Hoadonnhap obj = new Hoadonnhap();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTongtiennhap", tongtien);
                obj.SetParameterValue("txtconno", tongtra);
                obj.SetParameterValue("txtbangchu", bangchu);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 3)
            {
                Hoadonbanhang obj = new Hoadonbanhang();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtbangchu", bangchu);
                obj.SetParameterValue("txtnocu", nocu);
                obj.SetParameterValue("txttongtien", conno);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 4)
            {
                Thongkexuathang obj = new Thongkexuathang();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTungay", nocu);
                obj.SetParameterValue("txtDenngay", conno);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 5)
            {
                Thongkenhaphang obj = new Thongkenhaphang();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTungay", nocu);
                obj.SetParameterValue("txtDenngay", conno);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 6)
            {
                Danhsachtonkho obj = new Danhsachtonkho();
                obj.SetDataSource(dt);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 7)
            {
                Thongkehoadonbaoduong obj = new Thongkehoadonbaoduong();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTungay", nocu);
                obj.SetParameterValue("txtDenngay",tongtra);
                obj.SetParameterValue("txtTongtien", tongtien);
                obj.SetParameterValue("txtbangchu", bangchu);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 8)
            {
                Thongkehoadonbanhang obj = new Thongkehoadonbanhang();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTungay", nocu);
                obj.SetParameterValue("txtDenngay", tongtra);
                obj.SetParameterValue("txtTongtien", tongtien);
                obj.SetParameterValue("txtDatra", bangchu);
                obj.SetParameterValue("txtChuatra", conno);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 9)
            {
                Thongkehdnhap obj = new Thongkehdnhap();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTungay", nocu);
                obj.SetParameterValue("txtDenngay", tongtra);
                obj.SetParameterValue("txtTongtien", tongtien);
                obj.SetParameterValue("txtDatra", bangchu);
                obj.SetParameterValue("txtChuatra", conno);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 10)
            {
                Thongkekhachno obj = new Thongkekhachno();
                obj.SetDataSource(dt);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 11)
            {
                NoNCC obj = new NoNCC();
                obj.SetDataSource(dt);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 12)
            {
                baocongkhachhang obj = new baocongkhachhang();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTu", tungay);
                obj.SetParameterValue("txtDen", denngay);
                obj.SetParameterValue("txtnocu", nocu);
                obj.SetParameterValue("txttienmua", tienmua);
                obj.SetParameterValue("txttientra", tientra);
                obj.SetParameterValue("txtphuphi", phuphi);
                obj.SetParameterValue("txtTongcong", hoachtoan);
                obj.SetParameterValue("txtBangchu", bangchu);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
            if (Type == 13)
            {
                baocongnhacungcap obj = new baocongnhacungcap();
                obj.SetDataSource(dt);
                obj.SetParameterValue("txtTu", tungay);
                obj.SetParameterValue("txtDen", denngay);
                obj.SetParameterValue("txtnocu", nocu);
                obj.SetParameterValue("txttienmua", tienmua);
                obj.SetParameterValue("txttientra", tientra);
                obj.SetParameterValue("txtphuphi", phuphi);
                obj.SetParameterValue("txtTongcong", hoachtoan);
                obj.SetParameterValue("txtBangchu", bangchu);
                crystalReportViewer1.ReportSource = obj;
                crystalReportViewer1.Refresh();
            }
        }

    }
}
