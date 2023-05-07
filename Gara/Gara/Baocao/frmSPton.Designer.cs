namespace SamLop.Baocao
{
    partial class frmSPton
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
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.comNhom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_SanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongxuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Giaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(952, 180);
            this.panel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnReset);
            this.groupPanel2.Controls.Add(this.butint);
            this.groupPanel2.Controls.Add(this.buttonX4);
            this.groupPanel2.Controls.Add(this.comNhom);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(952, 180);
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
            this.groupPanel2.Text = "Tìm kiếm nhóm sản phẩm";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Image = global::SamLop.Properties.Resources._1397802639_Refresh;
            this.btnReset.Location = new System.Drawing.Point(406, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 28);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 89;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // butint
            // 
            this.butint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butint.Image = global::SamLop.Properties.Resources.print;
            this.butint.Location = new System.Drawing.Point(522, 81);
            this.butint.Name = "butint";
            this.butint.Size = new System.Drawing.Size(93, 28);
            this.butint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butint.TabIndex = 88;
            this.butint.Text = "In ấn";
            this.butint.Click += new System.EventHandler(this.butint_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Image = global::SamLop.Properties.Resources.binoculars_1281;
            this.buttonX4.Location = new System.Drawing.Point(546, 25);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(87, 28);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 76;
            this.buttonX4.Text = "Thực hiện";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // comNhom
            // 
            this.comNhom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comNhom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comNhom.DisplayMember = "Text";
            this.comNhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comNhom.FormattingEnabled = true;
            this.comNhom.ItemHeight = 14;
            this.comNhom.Location = new System.Drawing.Point(385, 33);
            this.comNhom.Name = "comNhom";
            this.comNhom.Size = new System.Drawing.Size(141, 20);
            this.comNhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comNhom.TabIndex = 66;
            this.comNhom.ValueMember = "Ten";
            this.comNhom.Click += new System.EventHandler(this.comNhom_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(308, 30);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(71, 23);
            this.labelX4.TabIndex = 65;
            this.labelX4.Text = "Tên nhóm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 238);
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
            this.gridControl1.Size = new System.Drawing.Size(952, 238);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_SanPham,
            this.TenSanPham,
            this.Ten,
            this.tongnhap,
            this.tongxuat,
            this.TONKHO,
            this.Giaban});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(804, 426, 216, 183);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID_SanPham
            // 
            this.ID_SanPham.Caption = "Mã sản phẩm";
            this.ID_SanPham.FieldName = "ID_SanPham";
            this.ID_SanPham.Name = "ID_SanPham";
            this.ID_SanPham.Visible = true;
            this.ID_SanPham.VisibleIndex = 0;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            // 
            // Ten
            // 
            this.Ten.Caption = "Nhóm sản phẩm";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 2;
            // 
            // tongnhap
            // 
            this.tongnhap.Caption = "Tổng nhập";
            this.tongnhap.FieldName = "tongnhap";
            this.tongnhap.Name = "tongnhap";
            this.tongnhap.Visible = true;
            this.tongnhap.VisibleIndex = 3;
            // 
            // tongxuat
            // 
            this.tongxuat.Caption = "Đã bán";
            this.tongxuat.FieldName = "tongxuat";
            this.tongxuat.Name = "tongxuat";
            this.tongxuat.Visible = true;
            this.tongxuat.VisibleIndex = 4;
            // 
            // TONKHO
            // 
            this.TONKHO.Caption = "Tồn kho";
            this.TONKHO.FieldName = "TONKHO";
            this.TONKHO.Name = "TONKHO";
            this.TONKHO.Visible = true;
            this.TONKHO.VisibleIndex = 5;
            // 
            // Giaban
            // 
            this.Giaban.Caption = "Giá bán";
            this.Giaban.FieldName = "Giaban";
            this.Giaban.Name = "Giaban";
            this.Giaban.Visible = true;
            this.Giaban.VisibleIndex = 6;
            // 
            // frmSPton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSPton";
            this.Load += new System.EventHandler(this.frmSPton_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comNhom;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_SanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn tongnhap;
        private DevExpress.XtraGrid.Columns.GridColumn tongxuat;
        private DevExpress.XtraGrid.Columns.GridColumn TONKHO;
        private DevExpress.XtraGrid.Columns.GridColumn Giaban;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX butint;
    }
}