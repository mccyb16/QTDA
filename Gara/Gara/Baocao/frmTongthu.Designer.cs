namespace SamLop.Baocao
{
    partial class frmTongthu
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
            this.labTongtien = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.dateDen = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_KhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Datra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_KhachTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.Size = new System.Drawing.Size(822, 187);
            this.panel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labTongtien);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.btnReset);
            this.groupPanel2.Controls.Add(this.dateDen);
            this.groupPanel2.Controls.Add(this.dateTu);
            this.groupPanel2.Controls.Add(this.buttonX6);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(822, 187);
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
            this.groupPanel2.TabIndex = 36;
            this.groupPanel2.Text = "Thống kê doanh thu";
            // 
            // labTongtien
            // 
            this.labTongtien.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labTongtien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTongtien.ForeColor = System.Drawing.Color.Red;
            this.labTongtien.Location = new System.Drawing.Point(396, 90);
            this.labTongtien.Name = "labTongtien";
            this.labTongtien.Size = new System.Drawing.Size(95, 23);
            this.labTongtien.TabIndex = 89;
            this.labTongtien.Text = ".................. VNĐ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(325, 90);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(65, 23);
            this.labelX5.TabIndex = 88;
            this.labelX5.Text = "Tổng tiền:";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Image = global::SamLop.Properties.Resources._1397802639_Refresh;
            this.btnReset.Location = new System.Drawing.Point(309, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 28);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 87;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.buttonX6.Location = new System.Drawing.Point(406, 119);
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
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 246);
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
            this.gridControl1.Size = new System.Drawing.Size(822, 246);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Id_KhachHang,
            this.Datra,
            this.NgayNhap,
            this.ID_KhachTra,
            this.Sotien,
            this.NgayTra});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(804, 426, 216, 183);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID
            // 
            this.ID.Caption = "Mã hóa đơn";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Id_KhachHang
            // 
            this.Id_KhachHang.Caption = "Mã khách hàng";
            this.Id_KhachHang.FieldName = "Id_KhachHang";
            this.Id_KhachHang.Name = "Id_KhachHang";
            this.Id_KhachHang.Visible = true;
            this.Id_KhachHang.VisibleIndex = 1;
            // 
            // Datra
            // 
            this.Datra.Caption = "Trả trong HĐ";
            this.Datra.FieldName = "Datra";
            this.Datra.Name = "Datra";
            this.Datra.Visible = true;
            this.Datra.VisibleIndex = 2;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày trả HĐ";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 3;
            // 
            // ID_KhachTra
            // 
            this.ID_KhachTra.Caption = "Khách trả sau";
            this.ID_KhachTra.FieldName = "ID_KhachTra";
            this.ID_KhachTra.Name = "ID_KhachTra";
            this.ID_KhachTra.Visible = true;
            this.ID_KhachTra.VisibleIndex = 4;
            // 
            // Sotien
            // 
            this.Sotien.Caption = "Số tiền";
            this.Sotien.FieldName = "Sotien";
            this.Sotien.Name = "Sotien";
            this.Sotien.Visible = true;
            this.Sotien.VisibleIndex = 5;
            // 
            // NgayTra
            // 
            this.NgayTra.Caption = "Ngày trả sau";
            this.NgayTra.FieldName = "NgayTra";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Visible = true;
            this.NgayTra.VisibleIndex = 6;
            // 
            // frmTongthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTongthu";
            this.Load += new System.EventHandler(this.frmTongthu_Load);
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
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDen;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTu;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Id_KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn Datra;
        private DevExpress.XtraGrid.Columns.GridColumn ID_KhachTra;
        private DevExpress.XtraGrid.Columns.GridColumn Sotien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevComponents.DotNetBar.LabelX labTongtien;
    }
}