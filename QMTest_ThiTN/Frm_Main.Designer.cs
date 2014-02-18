namespace QMTest_ThiTN
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.gridControl_DanhSachCauHoi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl_Main = new DevExpress.XtraEditors.PanelControl();
            this.groupControl_CauHoi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl_HuongDan = new DevExpress.XtraEditors.LabelControl();
            this.panelControl_NoiDungCauHoi = new DevExpress.XtraEditors.PanelControl();
            this.btnLayCauHoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_CauHoi = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbNgayThi = new DevExpress.XtraEditors.LabelControl();
            this.lbThoiGianLamBai = new DevExpress.XtraEditors.LabelControl();
            this.lbSoCauHoi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lbMaSinhVien = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Main)).BeginInit();
            this.panelControl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CauHoi)).BeginInit();
            this.groupControl_CauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_NoiDungCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_DanhSachCauHoi
            // 
            this.gridControl_DanhSachCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DanhSachCauHoi.Location = new System.Drawing.Point(0, 0);
            this.gridControl_DanhSachCauHoi.MainView = this.gridView1;
            this.gridControl_DanhSachCauHoi.Name = "gridControl_DanhSachCauHoi";
            this.gridControl_DanhSachCauHoi.Size = new System.Drawing.Size(242, 484);
            this.gridControl_DanhSachCauHoi.TabIndex = 2;
            this.gridControl_DanhSachCauHoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl_DanhSachCauHoi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Câu hỏi";
            this.gridColumn1.FieldName = "IdCauHoi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.menuStrip1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(250, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(569, 23);
            this.panelControl2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("68082787-13fb-4d27-a2de-44fac9a624bf");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(250, 200);
            this.dockPanel1.Size = new System.Drawing.Size(250, 511);
            this.dockPanel1.Text = "Danh sách câu hỏi";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gridControl_DanhSachCauHoi);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(242, 484);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl_Main);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(250, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(569, 488);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl_Main
            // 
            this.panelControl_Main.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl_Main.Controls.Add(this.groupControl_CauHoi);
            this.panelControl_Main.Controls.Add(this.groupControl1);
            this.panelControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_Main.Location = new System.Drawing.Point(0, 0);
            this.panelControl_Main.Name = "panelControl_Main";
            this.panelControl_Main.Size = new System.Drawing.Size(569, 488);
            this.panelControl_Main.TabIndex = 1;
            // 
            // groupControl_CauHoi
            // 
            this.groupControl_CauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_CauHoi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl_CauHoi.Controls.Add(this.labelControl_HuongDan);
            this.groupControl_CauHoi.Controls.Add(this.panelControl_NoiDungCauHoi);
            this.groupControl_CauHoi.Controls.Add(this.btnLayCauHoi);
            this.groupControl_CauHoi.Controls.Add(this.labelControl_CauHoi);
            this.groupControl_CauHoi.Location = new System.Drawing.Point(6, 124);
            this.groupControl_CauHoi.Name = "groupControl_CauHoi";
            this.groupControl_CauHoi.Size = new System.Drawing.Size(560, 360);
            this.groupControl_CauHoi.TabIndex = 5;
            this.groupControl_CauHoi.Text = "Câu hỏi";
            // 
            // labelControl_HuongDan
            // 
            this.labelControl_HuongDan.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_HuongDan.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelControl_HuongDan.Location = new System.Drawing.Point(49, 24);
            this.labelControl_HuongDan.Name = "labelControl_HuongDan";
            this.labelControl_HuongDan.Size = new System.Drawing.Size(6, 23);
            this.labelControl_HuongDan.TabIndex = 3;
            this.labelControl_HuongDan.Text = ".";
            // 
            // panelControl_NoiDungCauHoi
            // 
            this.panelControl_NoiDungCauHoi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl_NoiDungCauHoi.Location = new System.Drawing.Point(119, 101);
            this.panelControl_NoiDungCauHoi.Name = "panelControl_NoiDungCauHoi";
            this.panelControl_NoiDungCauHoi.Size = new System.Drawing.Size(366, 209);
            this.panelControl_NoiDungCauHoi.TabIndex = 2;
            // 
            // btnLayCauHoi
            // 
            this.btnLayCauHoi.Location = new System.Drawing.Point(12, 284);
            this.btnLayCauHoi.Name = "btnLayCauHoi";
            this.btnLayCauHoi.Size = new System.Drawing.Size(79, 26);
            this.btnLayCauHoi.TabIndex = 1;
            this.btnLayCauHoi.Text = "Câu hỏi";
            this.btnLayCauHoi.Click += new System.EventHandler(this.btnLayCauHoi_Click);
            // 
            // labelControl_CauHoi
            // 
            this.labelControl_CauHoi.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CauHoi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl_CauHoi.Location = new System.Drawing.Point(121, 70);
            this.labelControl_CauHoi.Name = "labelControl_CauHoi";
            this.labelControl_CauHoi.Size = new System.Drawing.Size(6, 25);
            this.labelControl_CauHoi.TabIndex = 0;
            this.labelControl_CauHoi.Text = ".";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lbNgayThi);
            this.groupControl1.Controls.Add(this.lbThoiGianLamBai);
            this.groupControl1.Controls.Add(this.lbSoCauHoi);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lbMaSinhVien);
            this.groupControl1.Controls.Add(this.lbHoTen);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(560, 112);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin";
            // 
            // lbNgayThi
            // 
            this.lbNgayThi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThi.Location = new System.Drawing.Point(440, 55);
            this.lbNgayThi.Name = "lbNgayThi";
            this.lbNgayThi.Size = new System.Drawing.Size(76, 13);
            this.lbNgayThi.TabIndex = 0;
            this.lbNgayThi.Text = "labelControl1";
            // 
            // lbThoiGianLamBai
            // 
            this.lbThoiGianLamBai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianLamBai.Location = new System.Drawing.Point(326, 83);
            this.lbThoiGianLamBai.Name = "lbThoiGianLamBai";
            this.lbThoiGianLamBai.Size = new System.Drawing.Size(76, 13);
            this.lbThoiGianLamBai.TabIndex = 0;
            this.lbThoiGianLamBai.Text = "labelControl1";
            this.lbThoiGianLamBai.Visible = false;
            // 
            // lbSoCauHoi
            // 
            this.lbSoCauHoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoCauHoi.Location = new System.Drawing.Point(179, 83);
            this.lbSoCauHoi.Name = "lbSoCauHoi";
            this.lbSoCauHoi.Size = new System.Drawing.Size(76, 13);
            this.lbSoCauHoi.TabIndex = 0;
            this.lbSoCauHoi.Text = "labelControl1";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(440, 24);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(76, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "labelControl1";
            this.labelControl10.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(268, 55);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "labelControl1";
            this.labelControl8.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(268, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "labelControl1";
            this.labelControl6.Visible = false;
            // 
            // lbMaSinhVien
            // 
            this.lbMaSinhVien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSinhVien.Location = new System.Drawing.Point(97, 55);
            this.lbMaSinhVien.Name = "lbMaSinhVien";
            this.lbMaSinhVien.Size = new System.Drawing.Size(76, 13);
            this.lbMaSinhVien.TabIndex = 0;
            this.lbMaSinhVien.Text = "labelControl1";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(97, 24);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(76, 13);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "labelControl1";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(382, 55);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Ngày thi:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(268, 83);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(47, 13);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Thời gian:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(121, 83);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(39, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Số câu: ";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(382, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Môn thi:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(199, 55);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Lớp: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(199, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Ngày sinh: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã sinh viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ tên:";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 511);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống thi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Main)).EndInit();
            this.panelControl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CauHoi)).EndInit();
            this.groupControl_CauHoi.ResumeLayout(false);
            this.groupControl_CauHoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_NoiDungCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl_DanhSachCauHoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.PanelControl panelControl_Main;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbNgayThi;
        private DevExpress.XtraEditors.LabelControl lbThoiGianLamBai;
        private DevExpress.XtraEditors.LabelControl lbSoCauHoi;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbMaSinhVien;
        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl_CauHoi;
        private DevExpress.XtraEditors.LabelControl labelControl_HuongDan;
        private DevExpress.XtraEditors.PanelControl panelControl_NoiDungCauHoi;
        private DevExpress.XtraEditors.SimpleButton btnLayCauHoi;
        private DevExpress.XtraEditors.LabelControl labelControl_CauHoi;
    }
}