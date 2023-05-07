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

namespace SamLop.Chucnangkhac
{
    public partial class frmSaoluu : Form
    {
        FileDialog dl;
        public frmSaoluu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dl = new SaveFileDialog();
            dl.Filter = "File type(*.bak)|*.bak";
            dl.DefaultExt = "bak";
            dl.FileName = DateTime.Now.ToString("dd-MM-yyyy-hh")+".bak";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                txtTen.Text = dl.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Bạn chưa chọn file phục hồi!");
                txtTen.Focus();
                return;
            }
            try 
            {
                StreamReader Re = File.OpenText("Config.txt");
                string connectionstring = Re.ReadLine();
                Re.Close();
                SqlConnection connection1 = new SqlConnection();
                connection1 = new SqlConnection(connectionstring);

                connection1.Open();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE CUAHANG TO DISK='" + txtTen.Text + "'", connection1);
                cmd.ExecuteNonQuery();
                connection1.Close();
                MessageBox.Show("Sao lưu thành công");
            }
            catch
            {
                MessageBox.Show("Hãy chọn ổ D hoặc E!");
            }
        }
    }
}

