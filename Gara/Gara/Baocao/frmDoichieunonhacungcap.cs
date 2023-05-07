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
    public partial class frmDoichieunonhacungcap : Form
    {
         public int tongmua = 0;
         public int trano = 0;
         
        public frmDoichieunonhacungcap()
        {
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void frmDoichieunonhacungcap_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NhaCungCapService.NhaCungCap_GetByAll();
            DataTable dm = NhaCungCapService.NhaCungCap_GetByTop("", "", "ID DESC");
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "Ten";
            comMaKH.ValueMember = "ID";
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            comMaKH.SelectedValue = gridView1.GetFocusedRowCellDisplayText(ID);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTien.Text = "0";
            DataTable dm = NhaCungCapService.NhaCungCap_GetByTop("", "", "ID DESC");
            comMaKH.DataSource = dm;
            comMaKH.DisplayMember = "Ten";
            comMaKH.ValueMember = "ID";
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            
             Report.Report.Type = 13;
             Report.Report.tungay = dateTu.Text;
             Report.Report.denngay = dateDen.Text;
             Report.Report.phuphi = txtTien.Text;
             //
             int tien1 = tinhtiennocu(dateTu.Text, dateDen.Text, comMaKH.SelectedValue.ToString());
             Report.Report.nocu = tien1.ToString();
             //
             tinhtien(dateTu.Text, dateDen.Text, comMaKH.SelectedValue.ToString());
             Report.Report.tientra = trano.ToString();
             Report.Report.tienmua = tongmua.ToString();

             //
              int  tiencon = tongmua - trano;
              Report.Report.tongtra = tiencon.ToString();
              int hachtoan = tiencon + tien1 + Convert.ToInt32(txtTien.Text);
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
                 Report.Report.bangchu = objConvert.DocSo(hachtoan).ToLower();
             }
             //Thong tin khach hag
             NhaCungCapInfo obj = new NhaCungCapInfo();
             obj.ID = comMaKH.SelectedValue.ToString();
             Report.Report.dt = NhaCungCapService.NhaCungCap_GetById(obj);
             Report.Report frm = new Report.Report();
             frm.Show();

             // reset
             tiencon = 0;
             hachtoan = 0;
             tongmua = 0;
             trano = 0;
        }
        public int tinhtiennocu(string date1, string date2, string makh)
        {
            Chuyenngay date = new Chuyenngay();
            string datetu = date.ngaynhap(dateTu.Text);
            string dateden = date.ngaynhap(dateDen.Text);
            int tienmua = 0;
            int tienno = 0;
            int tongtra = 0;
            try {    
                StreamReader Re = File.OpenText("Config.txt");
                string connectionstring = Re.ReadLine();
                Re.Close();
                SqlConnection connection1 = new SqlConnection();
                connection1 = new SqlConnection(connectionstring);
                connection1.Open();
                SqlCommand cmd = new SqlCommand("select * from baocongnhacungcap where NgayNhap <'" + datetu + "' and Id_NhaCC ='" + makh + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                //Tinh tien cc
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    if (!(dm.Rows[i]["Tongtien"] is DBNull))
                    {
                        tienmua = tienmua + Convert.ToInt32(dm.Rows[i]["Tongtien"]);
                    }
                    if (!(dm.Rows[i]["Datra"] is DBNull))
                    {
                        tongtra = tongtra + Convert.ToInt32(dm.Rows[i]["Datra"]);
                    }
                }
                // tinh tien mua hang
                string sqlcommand = "select * from baocongnhacungcap where Ngaytra <'" + datetu + "' and ID_Thanhtoan ='" + makh + "'";
                SqlCommand cmd1 = new SqlCommand(sqlcommand, connection1);
                var da1 = new SqlDataAdapter(cmd1);
                DataTable dm1 = new DataTable();
                da1.Fill(dm1);
                MessageBox.Show(dm1.Rows.Count.ToString());
                for (int j = 0; j < dm1.Rows.Count; j++)
                {
                    if (!(dm1.Rows[j]["Sotien"] is DBNull))
                    {
                        tongtra = tongtra + Convert.ToInt32(dm.Rows[j]["Sotien"]);
                    }

                }
                // tinh tien no
                return tienno = tienmua - tienno;
            }
            catch {
                return tienno;
            }
            
        }
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
                string sqlcommand = "select * from baocongnhacungcap where NgayNhap >='" + datetu + "' and  NgayNhap <='" + dateden + "' and Id_NhaCC ='" + makh + "'";
                SqlCommand cmd = new SqlCommand(sqlcommand, connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                //Tinh tien cc
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    if (!(dm.Rows[i]["Tongtien"] is DBNull))
                    {
                        tongmua = tongmua + Convert.ToInt32(dm.Rows[i]["Tongtien"]);
                    }
                    if (!(dm.Rows[i]["Datra"] is DBNull))
                    {
                        trano = trano + Convert.ToInt32(dm.Rows[i]["Datra"]);
                    }
                }
                // tinh tien mua hang
                SqlCommand cmd1 = new SqlCommand("select * from baocongnhacungcap where Ngaytra <'" + datetu + "' and id_thanhtoan ='" + makh + "'", connection1);
                var da1 = new SqlDataAdapter(cmd1);
                DataTable dm1 = new DataTable();
                da1.Fill(dm1);
                for (int i = 0; i < dm1.Rows.Count; i++)
                {
                    if (!(dm1.Rows[i]["Sotien"] is DBNull))
                    {
                        trano = trano + Convert.ToInt32(dm.Rows[i]["Sotien"]);
                    }
                }
            }
            catch { }           

        }
    }
}
