namespace SamLop.Chucnangkhac
{
    partial class frmDoimatkhau
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPasscu = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(43, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(43, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu hiện tại:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(43, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu mới:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(43, 194);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nhập lại mật khẩu:";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(184, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(156, 20);
            this.txtTen.TabIndex = 4;
            // 
            // txtPasscu
            // 
            this.txtPasscu.Location = new System.Drawing.Point(184, 112);
            this.txtPasscu.Name = "txtPasscu";
            this.txtPasscu.Size = new System.Drawing.Size(156, 20);
            this.txtPasscu.TabIndex = 5;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(184, 152);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(156, 20);
            this.txtPass1.TabIndex = 6;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(184, 193);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(156, 20);
            this.txtPass2.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(71, 259);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Đồng ý";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(236, 259);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Làm tươi";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 341);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtPasscu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoimatkhau";
            this.Text = "frmDoimatkhau";
            this.Load += new System.EventHandler(this.frmDoimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPasscu;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtPass2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}