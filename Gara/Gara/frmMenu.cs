using DevComponents.DotNetBar;
using DevExpress.XtraEditors;
using SamLop.Baocao;
using SamLop.Baoduongxe;
using SamLop.Chucnangkhac;
using SamLop.Nhaphang;
using SamLop.Tonghop;
using SamLop.Xuathang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop
{
    public partial class frmMenu : Form
    {
        public static string luu="";
        public static string isLogin = "";
        public static string isLoginDate = "";
        public static string isName = "";
        public static string isPass = "";
        public frmMenu()
        {
            InitializeComponent();
        }
        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < tabControl1.Tabs.Count; i++)
            {
                if (tabControl1.Tabs[i].Text == name)
                {
                    tabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmLogin fr = new frmLogin();
            fr.Show();
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Đổi mật khẩu"))
            {
                TabItem t = tabControl1.CreateTab("Đổi mật khẩu");
                frmDoimatkhau frm = new frmDoimatkhau();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Đổi thông tin cá nhân"))
            {
                TabItem t = tabControl1.CreateTab("Đổi thông tin cá nhân");
                frmThongtincanhan frm = new frmThongtincanhan();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh sách nhân viên"))
            {
                TabItem t = tabControl1.CreateTab("Danh sách nhân viên");
                frmNhanVien frm = new frmNhanVien();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quyền hạn"))
            {
                TabItem t = tabControl1.CreateTab("Quyền hạn");
                frmQuyen frm = new frmQuyen();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Sao lưu"))
            {
               TabItem t = tabControl1.CreateTab("Sao lưu");
                frmSaoluu frm = new frmSaoluu();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;    
         
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Phục hồi"))
            {
                TabItem t = tabControl1.CreateTab("Phục hồi");
                frmPhuchoi frm = new frmPhuchoi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Hóa đơn nhập"))
            {
                TabItem t = tabControl1.CreateTab("Hóa đơn nhập");
                frmHoadonnhap frm = new frmHoadonnhap();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Công ty"))
            {
                TabItem t = tabControl1.CreateTab("Công ty");
                frmCongty frm = new frmCongty();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Nhà sản xuất"))
            {
                TabItem t = tabControl1.CreateTab("Nhà sản xuất");
                frmNhaSX frm = new frmNhaSX();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Sản phẩm"))
            {
                TabItem t = tabControl1.CreateTab("Sản phẩm");
                frmSanpham frm = new frmSanpham();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Nhóm sản phẩm"))
            {
                TabItem t = tabControl1.CreateTab("Nhóm sản phẩm");
                frmNhomSP frm = new frmNhomSP();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Chi tiết nhập"))
            {
                TabItem t = tabControl1.CreateTab("Chi tiết nhập");
                frmChitietnhap frm = new frmChitietnhap();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Khách hàng"))
            {
                TabItem t = tabControl1.CreateTab("Khách hàng");
                frmKhachhang frm = new frmKhachhang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Khách hàng"))
            {
                TabItem t = tabControl1.CreateTab("Khách hàng");
                frmKhachhang frm = new frmKhachhang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Xuất hàng"))
            {
                TabItem t = tabControl1.CreateTab("Xuất hàng");
                frmHoadonxuat frm = new frmHoadonxuat();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Chi tiết xuất"))
            {
                TabItem t = tabControl1.CreateTab("Chi tiết xuất");
                frmChitietxuat frm = new frmChitietxuat();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Xe bảo dưỡng"))
            {
                TabItem t = tabControl1.CreateTab("Xe bảo dưỡng");
                frmXeBD frm = new frmXeBD();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Hóa đơn bảo dưỡng"))
            {
                TabItem t = tabControl1.CreateTab("Hóa đơn bảo dưỡng");
                frmHoadonBD frm = new frmHoadonBD();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Chi tiết bảo dưỡng"))
            {
                TabItem t = tabControl1.CreateTab("Chi tiết bảo dưỡng");
                frmChitietBD frm = new frmChitietBD();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Khách trả nợ"))
            {
                TabItem t = tabControl1.CreateTab("Khách trả nợ");
                frmKhachtra frm = new frmKhachtra();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Trả nhà cung cấp"))
            {
                TabItem t = tabControl1.CreateTab("Trả nhà cung cấp");
                frmTraCT frm = new frmTraCT();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh sách sản phẩm"))
            {
                TabItem t = tabControl1.CreateTab("Danh sách sản phẩm");
                frmTSanPham frm = new frmTSanPham();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Xe đã bảo trì"))
            {
                TabItem t = tabControl1.CreateTab("Xe đã bảo trì");
                frmXeXong frm = new frmXeXong();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Xe chờ bảo trì"))
            {
                TabItem t = tabControl1.CreateTab("Xe chờ bảo trì");
                frmXeCho frm = new frmXeCho();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Thống kê nhập hàng"))
            {
                TabItem t = tabControl1.CreateTab("Thống kê nhập hàng");
                frmNhaphang frm = new frmNhaphang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Thống kê xuất hàng"))
            {
                TabItem t = tabControl1.CreateTab("Thống kê xuất hàng");
                frmXuathang frm = new frmXuathang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Thống kê hàng tồn"))
            {
                TabItem t = tabControl1.CreateTab("Thống kê hàng tồn");
                frmSPton frm = new frmSPton();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Thống kê hóa đơn nhập"))
            {
                TabItem t = tabControl1.CreateTab("Thống kê hóa đơn nhập");
                frmHDnhap frm = new frmHDnhap();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Thống kê hóa đơn xuất"))
            {
                TabItem t = tabControl1.CreateTab("Thống kê hóa đơn xuất");
                frmHDxuat frm = new frmHDxuat();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Thống kê hóa đơn bảo dưỡng"))
            {
                TabItem t = tabControl1.CreateTab("Thống kê hóa đơn bảo dưỡng");
                frmHDbaotri frm = new frmHDbaotri();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Tổng thu"))
            {
                TabItem t = tabControl1.CreateTab("Tổng thu");
                frmTongthu frm = new frmTongthu();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản lý nợ khách hàng"))
            {
                TabItem t = tabControl1.CreateTab("Quản lý nợ khách hàng");
                frmNo frm = new frmNo();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản lý nợ nhà cung cấp"))
            {
                TabItem t = tabControl1.CreateTab("Quản lý nợ nhà cung cấp");
                frmNoCC frm = new frmNoCC();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản lý chi phí"))
            {
                TabItem t = tabControl1.CreateTab("Quản lý chi phí");
                frmTongchi frm = new frmTongchi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Tính lãi"))
            {
                TabItem t = tabControl1.CreateTab("Tính lãi");
                frmLai frm = new frmLai();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(isLogin=="1")
            {
                barButtonItem25.Enabled = true;
                barButtonItem26.Enabled = true;
                barButtonItem42.Enabled = true;
            }
           
        }

        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Đối chiếu khách hàng"))
            {
                TabItem t = tabControl1.CreateTab("Đối chiếu khách hàng");
                frmDoichieunokhachhang frm = new frmDoichieunokhachhang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Đối chiếu nhà cung cấp"))
            {
                TabItem t = tabControl1.CreateTab("Đối chiếu nhà cung cấp");
                frmDoichieunonhacungcap frm = new frmDoichieunonhacungcap();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }
    }
}
