using SamLop.Business;
using SamLop.Data;
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

namespace SamLop.Baocao
{
    public partial class frmDoichieunokhachhang : Form
    {
        public static int tiencantra = 0;
        public static int tiendatra = 0;
        public static int tiencon = 0;
        public static int hachtoan = 0;
        public frmDoichieunokhachhang()
        {
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void frmDoichieunokhachhang_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = KhachHangService.KhachHang_GetByAll();
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DataTable dm = KhachHangService.KhachHang_GetByTop("", "", "ID DESC");
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "TenKhachHang";
            comMaKH.ValueMember = "ID";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            comMaKH.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID);
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            
            Report.Report.Type = 12;
            Report.Report.tungay = dateTu.Text;
            Report.Report.denngay = dateDen.Text;
            Report.Report.phuphi = txtTien.Text;
            //
           int tien1= tinhtiennocu(dateTu.Text, dateDen.Text, comMaKH.SelectedValue.ToString());
           Report.Report.nocu = tien1.ToString();
           //
           tinhtien(dateTu.Text, dateDen.Text, comMaKH.SelectedValue.ToString());
           Report.Report.tientra = tiendatra.ToString();
           Report.Report.tienmua = tiencantra.ToString();
           
            //
           tiencon = tiencantra - tiendatra;
           Report.Report.tongtra = tiencon.ToString();  
           hachtoan = tiencon + tien1 + Convert.ToInt32(txtTien.Text);
            //Gan vao bao cao
           Report.Report.hoachtoan = hachtoan.ToString();
           if (hachtoan < 0)
           {
               Report.Report.bangchu = "Âm";
               hachtoan = hachtoan * (-1);
               docso objConvert = new docso();
               Report.Report.bangchu = Report.Report.bangchu + objConvert.DocSo(hachtoan).ToLower();

           }
           else
           {
               docso objConvert = new docso();
               Report.Report.bangchu = Report.Report.bangchu + objConvert.DocSo(hachtoan).ToLower();
           }
            //Thong tin khach hag
           KhachHangInfo obj = new KhachHangInfo();
           obj.ID = comMaKH.SelectedValue.ToString();
           Report.Report.dt = KhachHangService.KhachHang_GetById(obj);
           Report.Report frm = new Report.Report();
           frm.Show();
            
            // reset
                   tiencantra = 0;
                   tiendatra = 0;
                   tiencon = 0;
                   hachtoan = 0;
        }
        public int tinhtiennocu(string date1, string date2, string makh)
        {
            Chuyenngay date = new Chuyenngay();
            string datetu = date.ngaynhap(dateTu.Text);
            string dateden = date.ngaynhap(dateDen.Text);
            int tienbaotri = 0;
            int tienmuahang = 0;
            int tientrasau = 0;
            int tongtien = 0;
            try
            {
                StreamReader Re = File.OpenText("Config.txt");
                string connectionstring = Re.ReadLine();
                Re.Close();
                SqlConnection connection1 = new SqlConnection();
                connection1 = new SqlConnection(connectionstring);
                connection1.Open();
                SqlCommand cmd = new SqlCommand("select * from Chitietcongkhachhang where ngaynhap <'" + datetu + "' and Id_Khachhang ='" + makh + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                //Tinh tien baotri
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    tienbaotri = tienbaotri + Convert.ToInt32(dm.Rows[i]["TongTien"]);
                }
                // tinh tien mua hang
                SqlCommand cmd1 = new SqlCommand("select * from Chitietcongkhachhang where ngayxuat <'" + datetu + "' and makhachhangxuat ='" + makh + "'", connection1);
                var da1 = new SqlDataAdapter(cmd1);
                DataTable dm1 = new DataTable();
                da1.Fill(dm1);
                for (int i = 0; i < dm1.Rows.Count; i++)
                {
                    if (!(dm1.Rows[i]["tienxuathang"] is DBNull))
                    {
                        tienmuahang = tienmuahang + Convert.ToInt32(dm1.Rows[i]["tienxuathang"]);
                    }
                    if (!(dm1.Rows[i]["Datra"] is DBNull))
                    {
                        tienmuahang = tienmuahang - Convert.ToInt32(dm1.Rows[i]["Datra"]);
                    }
                }
                //Tinh tien tra sau
                SqlCommand cmd2 = new SqlCommand("select * from  Chitietcongkhachhang  where ngaytra <'" + datetu + "' and id_thanhtoan ='" + makh + "'", connection1);
                var da2 = new SqlDataAdapter(cmd1);
                DataTable dm2 = new DataTable();
                da2.Fill(dm2);
                for (int i = 0; i < dm2.Rows.Count; i++)
                {
                    if (!(dm2.Rows[i]["Sotien"] is DBNull))
                    {
                        tientrasau = tientrasau + Convert.ToInt32(dm2.Rows[i]["Sotien"]);
                    }
                }
                // tinh tien no
                return tongtien = tienbaotri + tienmuahang - tientrasau;
            }
            catch
            {
                return tongtien;
            }
        }
        // thu chi khach hang trong date1->date 2
        public void tinhtien(string date1, string date2, string makh)
        {
            Chuyenngay date = new Chuyenngay();
            string datetu = date.ngaynhap(dateTu.Text);
            string dateden = date.ngaynhap(dateDen.Text);
            try
            {
                StreamReader Re = File.OpenText("Config.txt");
                string connectionstring = Re.ReadLine();
                Re.Close();
                SqlConnection connection1 = new SqlConnection();
                connection1 = new SqlConnection(connectionstring);
                connection1.Open();
                SqlCommand cmd = new SqlCommand("select * from Chitietcongkhachhang where ngaynhap >='" + datetu + "'and ngaynhap <='" + dateden + "' and id_khachhang ='" + makh + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                //Tinh tien baotri
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    if (!(dm.Rows[i]["TongTien"] is DBNull))
                    {
                        tiencantra = tiencantra + Convert.ToInt32(dm.Rows[i]["TongTien"]);
                    }

                }
                // tinh tien mua hang
                SqlCommand cmd1 = new SqlCommand("select * from Chitietcongkhachhang where  ngayxuat >='" + datetu + "'and ngayxuat <='" + dateden + "' and makhachhangxuat ='" + makh + "'", connection1);
                var da1 = new SqlDataAdapter(cmd1);
                DataTable dm1 = new DataTable();
                da1.Fill(dm1);
                for (int i = 0; i < dm1.Rows.Count; i++)
                {
                    if (!(dm1.Rows[i]["tienxuathang"] is DBNull))
                    {
                        tiencantra = tiencantra + Convert.ToInt32(dm1.Rows[i]["tienxuathang"]);
                    }
                    if (!(dm1.Rows[i]["Datra"] is DBNull))
                    {
                        tiendatra = tiendatra + Convert.ToInt32(dm1.Rows[i]["Datra"]);
                    }
                }
                //Tinh tien tra sau
                SqlCommand cmd2 = new SqlCommand("select * from Chitietcongkhachhang where  ngaytra >='" + datetu + "'and ngaytra <='" + dateden + "' and id_thanhtoan ='" + makh + "'", connection1);
                var da2 = new SqlDataAdapter(cmd1);
                DataTable dm2 = new DataTable();
                da2.Fill(dm2);
                for (int i = 0; i < dm2.Rows.Count; i++)
                {
                    if (!(dm2.Rows[i]["Sotien"] is DBNull))
                    {
                        tiendatra = tiendatra + Convert.ToInt32(dm2.Rows[i]["Sotien"]);

                    }
                }
            }
            catch
            { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DataTable dm = KhachHangService.KhachHang_GetByTop("", "", "ID DESC");
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "TenKhachHang";
            comMaKH.ValueMember = "ID";
            txtTien.Text = "0";
        }
    }
}
