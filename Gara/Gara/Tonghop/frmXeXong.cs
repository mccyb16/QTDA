﻿using SamLop.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamLop.Tonghop
{
    public partial class frmXeXong : Form
    {
        public frmXeXong()
        {
            InitializeComponent();
        }

        private void frmXeXong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ChiTietBaoTriService.CHIETXEBAOTRI_GetByTop("", "1=1", "ID DESC");       
        }
    }
}
