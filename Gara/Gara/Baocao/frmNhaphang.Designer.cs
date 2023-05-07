namespace SamLop.Baocao
{
    partial class frmNhaphang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.butint = new DevComponents.DotNetBar.ButtonX();
            this.dateDen = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_Masanpham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tongnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Donvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongxuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 182);
            this.panel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnReset);
            this.groupPanel2.Controls.Add(this.butint);
            this.groupPanel2.Controls.Add(this.dateDen);
            this.groupPanel2.Controls.Add(this.dateTu);
            this.groupPanel2.Controls.Add(this.buttonX6);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(805, 182);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 33;
            this.groupPanel2.Text = "Thống kê nhập hàng";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Image = global::SamLop.Properties.Resources._1397802639_Refresh;
            this.btnReset.Location = new System.Drawing.Point(203, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 28);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 87;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // butint
            // 
            this.butint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butint.Image = global::SamLop.Properties.Resources.print;
            this.butint.Location = new System.Drawing.Point(409, 95);
            this.butint.Name = "butint";
            this.butint.Size = new System.Drawing.Size(93, 28);
            this.butint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butint.TabIndex = 86;
            this.butint.Text = "In ấn";
            this.butint.Click += new System.EventHandler(this.butint_Click);
            // 
            // dateDen
            // 
            // 
            // 
            // 
            this.dateDen.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDen.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateDen.ButtonDropDown.Visible = true;
            this.dateDen.IsPopupCalendarOpen = false;
            this.dateDen.Location = new System.Drawing.Point(462, 45);
            // 
            // 
            // 
            this.dateDen.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateDen.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateDen.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDen.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateDen.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDen.MonthCalendar.DisplayMonth = new System.DateTime(2014, 4, 1, 0, 0, 0, 0);
            this.dateDen.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateDen.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateDen.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateDen.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateDen.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateDen.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDen.MonthCalendar.TodayButtonVisible = true;
            this.dateDen.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateDen.Name = "dateDen";
            this.dateDen.Size = new System.Drawing.Size(77, 20);
            this.dateDen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateDen.TabIndex = 85;
            // 
            // dateTu
            // 
            // 
            // 
            // 
            this.dateTu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTu.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTu.ButtonDropDown.Visible = true;
            this.dateTu.IsPopupCalendarOpen = false;
            this.dateTu.Location = new System.Drawing.Point(299, 45);
            // 
            // 
            // 
            this.dateTu.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTu.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTu.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTu.MonthCalendar.DisplayMonth = new System.DateTime(2014, 4, 1, 0, 0, 0, 0);
            this.dateTu.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTu.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTu.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTu.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTu.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTu.MonthCalendar.TodayButtonVisible = true;
            this.dateTu.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTu.Name = "dateTu";
            this.dateTu.Size = new System.Drawing.Size(77, 20);
            this.dateTu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTu.TabIndex = 84;
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Image = global::SamLop.Properties.Resources.binoculars_1281;
            this.buttonX6.Location = new System.Drawing.Point(299, 95);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(87, 28);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 81;
            this.buttonX6.Text = "Hiển thị";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(394, 45);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(62, 23);
            this.labelX11.TabIndex = 79;
            this.labelX11.Text = "Đến ngày:";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(231, 45);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(62, 23);
            this.labelX10.TabIndex = 77;
            this.labelX10.Text = "Từ ngày:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 215);
            this.panel2.TabIndex = 1;
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
            this.gridControl1.Size = new System.Drawing.Size(805, 215);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_Masanpham,
            this.TenSanPham,
            this.Tennhom,
            this.Tongnhap,
            this.Donvitinh,
            this.tongxuat,
            this.TenNhaSX,
            this.NgayNhap});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(804, 426, 216, 183);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID_Masanpham
            // 
            this.ID_Masanpham.Caption = "Mã sản phẩm";
            this.ID_Masanpham.FieldName = "ID_Masanpham";
            this.ID_Masanpham.Name = "ID_Masanpham";
            this.ID_Masanpham.Visible = true;
            this.ID_Masanpham.VisibleIndex = 0;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            // 
            // Tennhom
            // 
            this.Tennhom.Caption = "Nhóm sản phẩm";
            this.Tennhom.FieldName = "Tennhom";
            this.Tennhom.Name = "Tennhom";
            this.Tennhom.Visible = true;
            this.Tennhom.VisibleIndex = 2;
            // 
            // Tongnhap
            // 
            this.Tongnhap.Caption = "Số lượng";
            this.Tongnhap.FieldName = "Tongnhap";
            this.Tongnhap.Name = "Tongnhap";
            this.Tongnhap.Visible = true;
            this.Tongnhap.VisibleIndex = 3;
            // 
            // Donvitinh
            // 
            this.Donvitinh.Caption = "Đơn vị tính";
            this.Donvitinh.FieldName = "Donvitinh";
            this.Donvitinh.Name = "Donvitinh";
            this.Donvitinh.Visible = true;
            this.Donvitinh.VisibleIndex = 4;
            // 
            // tongxuat
            // 
            this.tongxuat.Caption = "Đã bán";
            this.tongxuat.FieldName = "tongxuat";
            this.tongxuat.Name = "tongxuat";
            this.tongxuat.Visible = true;
            this.tongxuat.VisibleIndex = 5;
            // 
            // TenNhaSX
            // 
            this.TenNhaSX.Caption = "Tên nhà sản xuất";
            this.TenNhaSX.FieldName = "TenNhaSX";
            this.TenNhaSX.Name = "TenNhaSX";
            this.TenNhaSX.Visible = true;
            this.TenNhaSX.VisibleIndex = 6;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 7;
            // 
            // frmNhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmNhaphang";
            this.Load += new System.EventHandler(this.frmNhaphang_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDen;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTu;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX butint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_Masanpham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn Tennhom;
        private DevExpress.XtraGrid.Columns.GridColumn Donvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn tongxuat;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaSX;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn Tongnhap;
        private DevComponents.DotNetBar.ButtonX btnReset;
    }
}