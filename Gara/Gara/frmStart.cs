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

namespace SamLop
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                StreamReader Re = File.OpenText("Config.txt");
                string input = null;
                input = Re.ReadLine();
                Re.Close();
               // MessageBox.Show(input);
                SqlConnection con = new SqlConnection(input);
                con.Open();
                frmLogin fr = new frmLogin();
                this.Hide();
                fr.Show();
            }
            catch
            {
                File.Delete("Config.txt");
                frmConnect fr = new frmConnect();
                this.Hide();
                fr.Show();
            }
        }
    }
}
