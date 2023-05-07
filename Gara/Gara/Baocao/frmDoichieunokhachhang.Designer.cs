namespace SamLop.Baocao
{
    partial class frmDoichieunokhachhang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.butPrint = new DevComponents.DotNetBar.ButtonX();
            this.butMaKH = new DevExpress.XtraEditors.SimpleButton();
            this.comMaKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.dateDen = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaST = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.Size = new System.Drawing.Size(782, 204);
            this.panel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.butPrint);
            this.groupPanel2.Controls.Add(this.butMaKH);
            this.groupPanel2.Controls.Add(this.comMaKH);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtTien);
            this.groupPanel2.Controls.Add(this.btnReset);
            this.groupPanel2.Controls.Add(this.dateDen);
            this.groupPanel2.Controls.Add(this.dateTu);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(782, 204);
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
            this.groupPanel2.TabIndex = 35;
            this.groupPanel2.Text = "Đối chiếu khách hàng nợ";
            // 
            // butPrint
            // 
            this.butPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butPrint.Image = global::SamLop.Properties.Resources.print;
            this.butPrint.Location = new System.Drawing.Point(372, 114);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(93, 28);
            this.butPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butPrint.TabIndex = 105;
            this.butPrint.Text = "In ấn";
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // butMaKH
            // 
            this.butMaKH.Location = new System.Drawing.Point(241, 75);
            this.butMaKH.Name = "butMaKH";
            this.butMaKH.Size = new System.Drawing.Size(50, 23);
            this.butMaKH.TabIndex = 104;
            this.butMaKH.Text = "....";
            // 
            // comMaKH
            // 
            this.comMaKH.DisplayMember = "Text";
            this.comMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comMaKH.FormattingEnabled = true;
            this.comMaKH.ItemHeight = 14;
            this.comMaKH.Location = new System.Drawing.Point(114, 78);
            this.comMaKH.Name = "comMaKH";
            this.comMaKH.Size = new System.Drawing.Size(121, 20);
            this.comMaKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comMaKH.TabIndex = 103;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(17, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(91, 23);
            this.labelX2.TabIndex = 102;
            this.labelX2.Text = "Tên khách hàng:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(320, 78);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 23);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "Tiền tăng thêm:";
            // 
            // txtTien
            // 
            // 
            // 
            // 
            this.txtTien.Border.Class = "TextBoxBorder";
            this.txtTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTien.Location = new System.Drawing.Point(414, 78);
            this.txtTien.MaxLength = 12;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(131, 20);
            this.txtTien.TabIndex = 100;
            this.txtTien.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Image = global::SamLop.Properties.Resources._1397802639_Refresh;
            this.btnReset.Location = new System.Drawing.Point(214, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 28);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 97;
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
            this.dateDen.Location = new System.Drawing.Point(388, 40);
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
            this.dateDen.TabIndex = 96;
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
            this.dateTu.Location = new System.Drawing.Point(225, 40);
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
            this.dateTu.TabIndex = 95;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(320, 40);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(62, 23);
            this.labelX11.TabIndex = 93;
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
            this.labelX10.Location = new System.Drawing.Point(157, 40);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(62, 23);
            this.labelX10.TabIndex = 92;
            this.labelX10.Text = "Từ ngày:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 303);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(782, 303);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenKhachHang,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.SoTK,
            this.NganHang,
            this.MaST});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(804, 426, 216, 183);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID
            // 
            this.ID.Caption = "Số CMTND";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
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
            // MaST
            // 
            this.MaST.Caption = "Mã số thuế";
            this.MaST.FieldName = "MaST";
            this.MaST.Name = "MaST";
            this.MaST.Visible = true;
            this.MaST.VisibleIndex = 7;
            // 
            // frmDoichieunokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDoichieunokhachhang";
            this.Load += new System.EventHandler(this.frmDoichieunokhachhang_Load);
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
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDen;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTu;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTien;
        private DevExpress.XtraEditors.SimpleButton butMaKH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comMaKH;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn SoTK;
        private DevExpress.XtraGrid.Columns.GridColumn NganHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaST;
        private DevComponents.DotNetBar.ButtonX butPrint;
    }
}