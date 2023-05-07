namespace SamLop.Tonghop
{
    partial class frmXeCho
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_xe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.gridControl1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(763, 397);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.BackColor = System.Drawing.Color.Aquamarine;
            this.groupPanel1.StyleMouseDown.BackColor2 = System.Drawing.Color.Aqua;
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 36;
            this.groupPanel1.Text = "Xe đã bảo trì";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 376);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_xe,
            this.YeuCau,
            this.NgayNhan,
            this.TenKhachHang,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.SoTK,
            this.NganHang});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(804, 426, 216, 183);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID_xe
            // 
            this.ID_xe.Caption = "Biển số xe";
            this.ID_xe.FieldName = "ID_xe";
            this.ID_xe.Name = "ID_xe";
            this.ID_xe.Visible = true;
            this.ID_xe.VisibleIndex = 0;
            // 
            // YeuCau
            // 
            this.YeuCau.Caption = "Yêu cầu";
            this.YeuCau.FieldName = "YeuCau";
            this.YeuCau.Name = "YeuCau";
            this.YeuCau.Visible = true;
            this.YeuCau.VisibleIndex = 7;
            // 
            // NgayNhan
            // 
            this.NgayNhan.Caption = "Ngày nhận";
            this.NgayNhan.FieldName = "NgayNhan";
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.Visible = true;
            this.NgayNhan.VisibleIndex = 8;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Caption = "Tên khách hàng";
            this.TenKhachHang.FieldName = "TenKhachHang";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Visible = true;
            this.TenKhachHang.VisibleIndex = 1;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            // 
            // SDT
            // 
            this.SDT.Caption = "SĐT";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            // 
            // SoTK
            // 
            this.SoTK.Caption = "Số tài khoản";
            this.SoTK.FieldName = "SoTK";
            this.SoTK.Name = "SoTK";
            this.SoTK.Visible = true;
            this.SoTK.VisibleIndex = 5;
            // 
            // NganHang
            // 
            this.NganHang.Caption = "Ngân hàng";
            this.NganHang.FieldName = "NganHang";
            this.NganHang.Name = "NganHang";
            this.NganHang.Visible = true;
            this.NganHang.VisibleIndex = 6;
            // 
            // frmXeCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 397);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmXeCho";
            this.Load += new System.EventHandler(this.frmXeCho_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_xe;
        private DevExpress.XtraGrid.Columns.GridColumn YeuCau;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhan;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn SoTK;
        private DevExpress.XtraGrid.Columns.GridColumn NganHang;
    }
}