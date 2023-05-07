using SamLop.Business;
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
    public partial class frmHDxuat : Form
    {
        public static int tongtien = 0;
        public static int datra = 0;
        public frmHDxuat()
        {
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void frmHDxuat_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietXuatService.Chitiethoadonxuat_GetByAll();
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietXuatService.Chitiethoadonxuat_GetByAll();
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
                SqlCommand cmd = new SqlCommand("select * from Chitiethoadonxuat where ngaynhap >='" + datetu+ "' and ngaynhap <='" + dateden + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                gridControl1.DataSource = dm;
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dm.Rows[i]["Tongtien"]);
                    datra = datra + Convert.ToInt32(dm.Rows[i]["Datra"]);
                }
                labTongtien.Text = tongtien.ToString() + " VNĐ";
                labDatra.Text = datra.ToString() + " VNĐ";
                tongtien = 0;
                datra = 0;
            }
            catch
            { }
        }

        private void butint_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("select * from Chitiethoadonxuat where ngaynhap >='" + datetu + "' and ngaynhap <='" + dateden + "'", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = tongtien + Convert.ToInt32(dt.Rows[i]["Tongtien"]);
                datra = datra + Convert.ToInt32(dt.Rows[i]["Datra"]);
            }
            string chuatra = (Convert.ToInt32(tongtien) - Convert.ToInt32(datra)).ToString();
            labTongtien.Text = tongtien.ToString() + " VNĐ";
            labDatra.Text = datra.ToString() + " VNĐ";
            Report.Report.nocu = dateTu.Text;
            Report.Report.tongtra = dateDen.Text;
            Report.Report.tongtien = tongtien.ToString();
            Report.Report.bangchu = datra.ToString();
            Report.Report.conno = chuatra;
            //
            Report.Report.Type = 8;
            Report.Report.dt = dt;
            Report.Report frm = new Report.Report();
            frm.Show();
            tongtien = 0;
            datra = 0;
            chuatra = "0";
        }
    }
}
