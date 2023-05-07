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
    public partial class frmXuathang : Form
    {
        public frmXuathang()
        {
    
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void frmXuathang_Load(object sender, EventArgs e)
        {
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            connection1.Open();
            SqlCommand cmd = new SqlCommand("select * from BAOCAOXUAT", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dm = new DataTable();
            da.Fill(dm);
            gridControl1.DataSource = dm;
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            connection1.Open();
            SqlCommand cmd = new SqlCommand("select * from BAOCAOXUAT",connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dm = new DataTable();
            da.Fill(dm);
            gridControl1.DataSource = dm;
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            SqlCommand cmd = new SqlCommand("select * from BAOCAOXUAT where Ngaynhap >= '" + datetu + "' and Ngaynhap <='" + dateden + "' ", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt; 
            Report.Report.nocu = dateTu.Text;
            Report.Report.conno = dateDen.Text;
            Report.Report.Type = 4;
            Report.Report.dt = dt;
            Report.Report frm = new Report.Report();
            frm.Show();
        }

        private void buttonX6_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("select * from BAOCAOXUAT where Ngaynhap >= '" + datetu + "' and Ngaynhap <='" + dateden + "' ", connection1);
            var da = new SqlDataAdapter(cmd);
            DataTable dm = new DataTable();
            da.Fill(dm);
            gridControl1.DataSource = dm; 
        }
    }
}
