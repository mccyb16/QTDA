using SamLop.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Baocao
{
    public partial class frmHDbaotri : Form
    {
        public static int tongtien = 0;
        public frmHDbaotri()
        {
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = ChiTietBaoTriService.Chitiethoadonbaotri_GetByAll();
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void buttonX6_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("select * from Chitiethoadonbaotri where ngaynhap >='" + datetu + "' and ngaynhap <='" + dateden + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                gridControl1.DataSource = dm;
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dm.Rows[i]["Tongtien"]);
                   
                }
                labTongtien.Text = tongtien.ToString() + " VNĐ";
                tongtien = 0;
            }
            catch
            { }
        }

        private void frmHDbaotri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietBaoTriService.Chitiethoadonbaotri_GetByAll();
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            Chuyenngay date = new Chuyenngay();
            string datetu = date.ngaynhap(dateTu.Text);
            string dateden = date.ngaynhap(dateDen.Text);
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            connection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Chitiethoadonbaotri where ngaynhap >='" + datetu + "' and ngaynhap <='" + dateden+ "'", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = tongtien + Convert.ToInt32(dt.Rows[i]["Tongtien"]);
            }
            labTongtien.Text = tongtien.ToString() + " VNĐ";
            Report.Report.nocu = dateTu.Text;
            Report.Report.tongtra = dateDen.Text;
            Report.Report.tongtien = tongtien.ToString();
            //
            if (tongtien < 0)
            {
                Report.Report.bangchu = "Âm";
                tongtien = tongtien * (-1);
                docso objConvert = new docso();
                Report.Report.bangchu = Report.Report.bangchu + objConvert.DocSo(tongtien).ToLower();
            }
            else
            {
                docso objConvert = new docso();
                Report.Report.bangchu =  objConvert.DocSo(tongtien).ToLower();
            }
            Report.Report.Type = 7;
            Report.Report.dt = dt;
            Report.Report frm = new Report.Report();
            frm.Show();
            tongtien = 0;
        }  
    }
}
