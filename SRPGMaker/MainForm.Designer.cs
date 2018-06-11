namespace SRPGMaker
{
    partial class MainForm
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem8 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem9 = new DevExpress.XtraBars.BarSubItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barSubItem10 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem11 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem12 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barLinkContainerItem1,
            this.skinBarSubItem1,
            this.barSubItem5,
            this.barSubItem6,
            this.barSubItem7,
            this.barSubItem8,
            this.barSubItem9,
            this.skinBarSubItem2,
            this.barSubItem10,
            this.barSubItem11,
            this.barSubItem12});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 15;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem9)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1106, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 518);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1106, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1106, 60);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "文件&F";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "新建";
            this.barSubItem2.Id = 1;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "打开";
            this.barSubItem3.Id = 2;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "关闭";
            this.barSubItem4.Id = 3;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 4;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 5;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "编辑&E";
            this.barSubItem5.Id = 6;
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "视图&V";
            this.barSubItem6.Id = 7;
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "工具&T";
            this.barSubItem7.Id = 8;
            this.barSubItem7.Name = "barSubItem7";
            // 
            // barSubItem8
            // 
            this.barSubItem8.Caption = "设置&S";
            this.barSubItem8.Id = 9;
            this.barSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem2)});
            this.barSubItem8.Name = "barSubItem8";
            // 
            // barSubItem9
            // 
            this.barSubItem9.Caption = "帮助&H";
            this.barSubItem9.Id = 10;
            this.barSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem12)});
            this.barSubItem9.Name = "barSubItem9";
            // 
            // skinBarSubItem2
            // 
            this.skinBarSubItem2.Caption = "皮肤";
            this.skinBarSubItem2.Id = 11;
            this.skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // barSubItem10
            // 
            this.barSubItem10.Caption = "barSubItem10";
            this.barSubItem10.Id = 12;
            this.barSubItem10.Name = "barSubItem10";
            // 
            // barSubItem11
            // 
            this.barSubItem11.Caption = "查看帮助";
            this.barSubItem11.Id = 13;
            this.barSubItem11.Name = "barSubItem11";
            // 
            // barSubItem12
            // 
            this.barSubItem12.Caption = "关于SRPGMaker";
            this.barSubItem12.Id = 14;
            this.barSubItem12.Name = "barSubItem12";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 543);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SRPGMaker   v0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraBars.BarSubItem barSubItem8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem9;
        private DevExpress.XtraBars.BarSubItem barSubItem11;
        private DevExpress.XtraBars.BarSubItem barSubItem12;
        private DevExpress.XtraBars.BarSubItem barSubItem10;
    }
}

