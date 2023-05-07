using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace SamLop
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống (Yes/ No)?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        public SqlConnection Getcon(string ser, string db, string user, string pass)
        {
            return new SqlConnection("Data Source="+ser+";Initial Catalog="+db+";User ID="+user+";Password="+pass+";Integrated Security=True");
        }
        private void butOk_Click(object sender, EventArgs e)
        {
            if (txtserver.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên Server không được để trống!");
                txtserver.Focus();
                return;
            }
            if (txtdb.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Tên Database không được để trống!");
                txtdb.Focus();
                return;
            }
           SqlConnection con= Getcon(txtserver.Text,txtdb.Text,txtuser.Text,txtpass.Text);
           try {
               con.Open();
               MessageBox.Show("Kết nối thành công!");
               FileInfo myfile = new FileInfo("Config.txt");
               StreamWriter tex = myfile.CreateText();
               tex.WriteLine("Data Source=" + txtserver.Text + ";Initial Catalog=" + txtdb.Text + ";User ID=" + txtuser.Text + ";Password=" + txtpass.Text + ";Integrated Security=True");
               tex.Close();
               this.Hide();
               frmLogin frm = new frmLogin();
               frm.Show();
           }
            catch
           {
               MessageBox.Show("Kết nối thất bại!");
           }
        }
    }
}
