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
    public partial class frmPhuchoi : Form
    {
        FileDialog dl;
        public frmPhuchoi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dl = new SaveFileDialog();
            dl.Filter = "File type(*.bak)|*.bak";
            dl.DefaultExt = "bak";
            if(dl.ShowDialog()==DialogResult.OK)
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
            StreamReader Re = File.OpenText("Config.txt");
            string connectionstring = Re.ReadLine();
            Re.Close();
            SqlConnection connection1 = new SqlConnection();
            connection1 = new SqlConnection(connectionstring);
            try
            {
                connection1.Open();
                SqlCommand cmd = new SqlCommand("ALTER DATABASE CUAHANG SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE CUAHANG FROM DISK='"+txtTen.Text+"' WITH REPLACE ALTER DATABASE CUAHANG SET ONLINE ", connection1);
                cmd.ExecuteNonQuery();
                connection1.Close();
                MessageBox.Show("Phục hồi thành công");
               
            }
            catch
            {
                MessageBox.Show("Phục hồi thất bại");
            }       
         
        }
    }
}
