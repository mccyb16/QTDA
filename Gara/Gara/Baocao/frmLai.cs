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
    public partial class frmLai : Form
    {
        public static int thu = 0;
        public static int chi = 0;
        public static int lai = 0;
        public frmLai()
        {
            InitializeComponent();
            this.dateTu.CustomFormat = "yyyy-MM-dd";
            this.dateDen.CustomFormat = "yyyy-MM-dd";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
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
                SqlCommand cmd = new SqlCommand("select * from Doanhthuthucte where ngaynhap >='" + datetu + "' and ngaynhap <='" + dateden + "'", connection1);
                var da = new SqlDataAdapter(cmd);
                DataTable dm = new DataTable();
                da.Fill(dm);
                for (int i = 0; i < dm.Rows.Count; i++)
                {
                    thu = thu + Convert.ToInt32(dm.Rows[i]["Datra"]);
                }
                SqlCommand cmd1 = new SqlCommand("select * from Doanhthuthucte where ngaytra >='" + datetu + "' and ngaytra <='" + dateden + "'", connection1);
                var da1 = new SqlDataAdapter(cmd1);
                DataTable dm1 = new DataTable();
                da1.Fill(dm1);
                for (int i = 0; i < dm1.Rows.Count; i++)
                {
                    thu = thu + Convert.ToInt32(dm1.Rows[i]["Sotien"]);
                }
                labthu.Text = thu.ToString() + " VNĐ"; 
    
                //chi
                SqlCommand cmd2 = new SqlCommand("select * from Chitietthanhtoanno where ngaynhap >='" + datetu + "' and ngaynhap <='" + dateden + "'", connection1);
                var da2 = new SqlDataAdapter(cmd2);
                DataTable dm2 = new DataTable();
                da2.Fill(dm2);

                for (int i = 0; i < dm2.Rows.Count; i++)
                {
                    chi = chi + Convert.ToInt32(dm2.Rows[i]["Datra"]);
                }
                SqlCommand cmd3 = new SqlCommand("select * from Chitietthanhtoanno where ngaytra >='" + dateTu.Text + "' and ngaytra <='" + dateDen.Text + "'", connection1);
                var da3 = new SqlDataAdapter(cmd3);
                DataTable dm3 = new DataTable();
                da3.Fill(dm3);
                for (int i = 0; i < dm3.Rows.Count; i++)
                {
                    chi = chi + Convert.ToInt32(dm3.Rows[i]["Sotien"]);
                }
                labchi.Text = chi.ToString() + " VNĐ";      
            }
            catch
            { }
            lablai.Text = (thu - chi).ToString() + " VNĐ";
            thu = chi = lai = 0;
        }

        private void frmLai_Load(object sender, EventArgs e)
        {
            dateTu.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateDen.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
