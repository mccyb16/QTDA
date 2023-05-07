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
    public partial class frmTongchi : Form
    {
        public static int tongtien = 0;
        public frmTongchi()
        {
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void frmTongchi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietBaoTriService.Chitietthanhtoanno_GetByAll();
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietBaoTriService.Chitietthanhtoanno_GetByAll();
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader Re = File.OpenText("Config.txt");
                string connectionstring = Re.ReadLine();
                Re.Close();
                SqlConnection connection1 = new SqlConnection();
                connection1 = new SqlConnection(connectionstring);
                connection1.Open();
                SqlCommand cmd = new SqlCommand("select * from Chitietthanhtoanno where ngaynhap >='" + dateTu.Text + "' and ngaynhap <='" + dateDen.Text + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
            
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dm.Rows[i]["Datra"]);
                }
                SqlCommand cmd1 = new SqlCommand("select * from Chitietthanhtoanno where ngaytra >='" + dateTu.Text + "' and ngaytra <='" + dateDen.Text + "'", connection1);
                var da1 = new SqlDataAdapter(cmd1);
                DataTable dm1 = new DataTable();
                da1.Fill(dm1);
                for (int i = 0; i < dm1.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dm1.Rows[i]["Sotien"]);
                }
                labDatra.Text = tongtien.ToString() + " VNĐ";
                tongtien = 0;
            }
            catch
            { }
        }
    }
}
