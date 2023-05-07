namespace SamLop
{
    partial class frmConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.butExit = new DevExpress.XtraEditors.SimpleButton();
            this.butOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.txtdb = new DevExpress.XtraEditors.TextEdit();
            this.txtserver = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserver.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.butExit);
            this.groupControl1.Controls.Add(this.butOk);
            this.groupControl1.Controls.Add(this.txtpass);
            this.groupControl1.Controls.Add(this.txtuser);
            this.groupControl1.Controls.Add(this.txtdb);
            this.groupControl1.Controls.Add(this.txtserver);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(301, 344);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "THÔNG TIN KẾT NỐI SERVER";
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(178, 298);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 10;
            this.butExit.Text = "Exit";
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(27, 298);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 9;
            this.butOk.Text = "OK";
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(27, 267);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(226, 20);
            this.txtpass.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(27, 191);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(226, 20);
            this.txtuser.TabIndex = 6;
            // 
            // txtdb
            // 
            this.txtdb.Location = new System.Drawing.Point(27, 124);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(226, 20);
            this.txtdb.TabIndex = 5;
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(27, 63);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(226, 20);
            this.txtserver.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(27, 235);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(216, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nhập mật khẩu đăng nhập Server";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(27, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(220, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nhập tài khoản đăng nhập Server ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(27, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhập tên DataBase";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(27, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(256, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập Server hoặc địa chỉ IP cần kết nối ";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 344);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT NỐI DATABASE";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserver.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton butExit;
        private DevExpress.XtraEditors.SimpleButton butOk;
        private System.Windows.Forms.TextBox txtpass;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.TextEdit txtdb;
        private DevExpress.XtraEditors.TextEdit txtserver;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

