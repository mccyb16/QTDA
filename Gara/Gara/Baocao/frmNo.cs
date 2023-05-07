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
    public partial class frmNo : Form
    {
        public static int tongtien = 0;
        public frmNo()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            connection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Bangnokhachhang where nocu>= 0", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dm = new DataTable();
            da.Fill(dm);
            gridControl1.DataSource = dm;   
        }

        private void frmNo_Load(object sender, EventArgs e)
        {
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            connection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Bangnokhachhang where nocu>= 0", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dm = new DataTable();
            da.Fill(dm);
            gridControl1.DataSource = dm;
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
                SqlCommand cmd = new SqlCommand("select * from Bangnokhachhang where nocu>=" + Convert.ToInt32(txtNotu.Text) + " and  nocu <=" + Convert.ToInt32(txtDen.Text) + " ", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                gridControl1.DataSource = dm;
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dm.Rows[i]["nocu"]);
                }
                labTongtien.Text = tongtien.ToString() + " VNĐ";
                tongtien = 0;
            }
            catch
            { }
        }

        private void butint_Click(object sender, EventArgs e)
        {
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            connection1.Open();
            if (txtNotu.Text=="0" && txtDen.Text=="0")
            {
                SqlCommand cmd = new SqlCommand("select * from Bangnokhachhang where nocu>= 0 order by nocu DESC", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                Report.Report.Type = 10;
                Report.Report.dt = dm;
                Report.Report frm = new Report.Report();
                frm.Show();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from Bangnokhachhang where nocu>=" + Convert.ToInt32(txtNotu.Text) + " and  nocu <=" + Convert.ToInt32(txtDen.Text) + " order by nocu DESC", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                Report.Report.Type = 10;
                Report.Report.dt = dm;
                Report.Report frm = new Report.Report();
                frm.Show();
            }
            
        }
    }
}
