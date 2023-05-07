namespace SamLop
{
    partial class frmphuphi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền:";
            // 
            // txttien
            // 
            // 
            // 
            // 
            this.txttien.Border.Class = "TextBoxBorder";
            this.txttien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttien.Location = new System.Drawing.Point(94, 64);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(129, 20);
            this.txttien.TabIndex = 1;
            this.txttien.Text = "0";
            this.txttien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmphuphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 165);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmphuphi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập phụ phí vào";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttien;
        private System.Windows.Forms.Button button1;
    }
}