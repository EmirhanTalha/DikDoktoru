namespace proje_DisDoktor
{
	partial class frmAnaForm
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
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.mbtnDoktor = new DevExpress.XtraBars.BarButtonItem();
			this.mbtnHasta = new DevExpress.XtraBars.BarButtonItem();
			this.btnIslemListesi = new DevExpress.XtraBars.BarButtonItem();
			this.btnUygulamaListesi = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.btnUygulamaRaporu1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnUygulamaRaporu2 = new DevExpress.XtraBars.BarButtonItem();
			this.btnUygulamaRaporu3 = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mbtnDoktor,
            this.mbtnHasta,
            this.btnIslemListesi,
            this.btnUygulamaListesi,
            this.barButtonItem5,
            this.btnUygulamaRaporu1,
            this.btnUygulamaRaporu2,
            this.btnUygulamaRaporu3});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 9;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
			this.ribbonControl1.Size = new System.Drawing.Size(727, 141);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			// 
			// mbtnDoktor
			// 
			this.mbtnDoktor.Caption = "Doktor Listesi";
			this.mbtnDoktor.Id = 1;
			this.mbtnDoktor.LargeWidth = 100;
			this.mbtnDoktor.Name = "mbtnDoktor";
			this.mbtnDoktor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.mbtnDoktor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbtnDoktor_ItemClick);
			// 
			// mbtnHasta
			// 
			this.mbtnHasta.Caption = "Hasta Listesi";
			this.mbtnHasta.Id = 2;
			this.mbtnHasta.LargeWidth = 100;
			this.mbtnHasta.Name = "mbtnHasta";
			this.mbtnHasta.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.mbtnHasta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbtnHasta_ItemClick);
			// 
			// btnIslemListesi
			// 
			this.btnIslemListesi.Caption = "İşlem Listesi";
			this.btnIslemListesi.Id = 3;
			this.btnIslemListesi.LargeWidth = 100;
			this.btnIslemListesi.Name = "btnIslemListesi";
			this.btnIslemListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnIslemListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIslemListesi_ItemClick);
			// 
			// btnUygulamaListesi
			// 
			this.btnUygulamaListesi.Caption = "Uygulama Listesi";
			this.btnUygulamaListesi.Id = 4;
			this.btnUygulamaListesi.LargeWidth = 100;
			this.btnUygulamaListesi.Name = "btnUygulamaListesi";
			this.btnUygulamaListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnUygulamaListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUygulamaListesi_ItemClick);
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "Uygulama Detay";
			this.barButtonItem5.Id = 5;
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// btnUygulamaRaporu1
			// 
			this.btnUygulamaRaporu1.Caption = "Uygulama Raporu 1";
			this.btnUygulamaRaporu1.Id = 6;
			this.btnUygulamaRaporu1.LargeWidth = 100;
			this.btnUygulamaRaporu1.Name = "btnUygulamaRaporu1";
			this.btnUygulamaRaporu1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnUygulamaRaporu1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUygulamaRaporu1_ItemClick);
			// 
			// btnUygulamaRaporu2
			// 
			this.btnUygulamaRaporu2.Caption = "Uygulama Raporu 2";
			this.btnUygulamaRaporu2.Id = 7;
			this.btnUygulamaRaporu2.LargeWidth = 100;
			this.btnUygulamaRaporu2.Name = "btnUygulamaRaporu2";
			this.btnUygulamaRaporu2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnUygulamaRaporu2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUygulamaRaporu2_ItemClick);
			// 
			// btnUygulamaRaporu3
			// 
			this.btnUygulamaRaporu3.Caption = "Uygulama Raporu 3";
			this.btnUygulamaRaporu3.Id = 8;
			this.btnUygulamaRaporu3.LargeWidth = 100;
			this.btnUygulamaRaporu3.Name = "btnUygulamaRaporu3";
			this.btnUygulamaRaporu3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnUygulamaRaporu3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUygulamaRaporu3_ItemClick);
			// 
			// ribbonPage3
			// 
			this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
			this.ribbonPage3.Name = "ribbonPage3";
			this.ribbonPage3.Text = "Uygulama";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.btnUygulamaListesi);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Tanımlamalar";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.mbtnDoktor);
			this.ribbonPageGroup1.ItemLinks.Add(this.mbtnHasta);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnIslemListesi);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Raporlar";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnUygulamaRaporu1);
			this.ribbonPageGroup2.ItemLinks.Add(this.btnUygulamaRaporu2);
			this.ribbonPageGroup2.ItemLinks.Add(this.btnUygulamaRaporu3);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 340);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(727, 27);
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.MdiParent = this;
			// 
			// frmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 367);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
			this.IsMdiContainer = true;
			this.Name = "frmAnaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ana Form";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAnaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem mbtnDoktor;
		private DevExpress.XtraBars.BarButtonItem mbtnHasta;
		private DevExpress.XtraBars.BarButtonItem btnIslemListesi;
		private DevExpress.XtraBars.BarButtonItem btnUygulamaListesi;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.BarButtonItem btnUygulamaRaporu1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem btnUygulamaRaporu2;
		private DevExpress.XtraBars.BarButtonItem btnUygulamaRaporu3;
	}
}