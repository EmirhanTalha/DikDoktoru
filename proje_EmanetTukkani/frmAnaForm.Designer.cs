namespace proje_EmanetTukkani
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.btnYeniEmanet = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnTeslimDurumu = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnKullanıcıListesi = new DevExpress.XtraBars.BarButtonItem();
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.lblGirisYapanKullanici = new DevExpress.XtraBars.BarStaticItem();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnYeniEmanetKayit = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Raporlar";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Emanet";
			// 
			// btnYeniEmanet
			// 
			this.btnYeniEmanet.Caption = "Yeni Emanet";
			this.btnYeniEmanet.Id = 1;
			this.btnYeniEmanet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniEmanet.ImageOptions.Image")));
			this.btnYeniEmanet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniEmanet.ImageOptions.LargeImage")));
			this.btnYeniEmanet.Name = "btnYeniEmanet";
			this.btnYeniEmanet.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnTeslimDurumu, true);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			// 
			// btnTeslimDurumu
			// 
			this.btnTeslimDurumu.Caption = "Emanet Teslim Durumu";
			this.btnTeslimDurumu.Id = 2;
			this.btnTeslimDurumu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimDurumu.ImageOptions.Image")));
			this.btnTeslimDurumu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTeslimDurumu.ImageOptions.LargeImage")));
			this.btnTeslimDurumu.Name = "btnTeslimDurumu";
			this.btnTeslimDurumu.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.btnTeslimDurumu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeslimDurumu_ItemClick);
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnKullanıcıListesi);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			// 
			// btnKullanıcıListesi
			// 
			this.btnKullanıcıListesi.Caption = "Kullanıcıların Listesi";
			this.btnKullanıcıListesi.Id = 3;
			this.btnKullanıcıListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıListesi.ImageOptions.Image")));
			this.btnKullanıcıListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıListesi.ImageOptions.LargeImage")));
			this.btnKullanıcıListesi.Name = "btnKullanıcıListesi";
			this.btnKullanıcıListesi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.btnKullanıcıListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullanıcıListesi_ItemClick);
			// 
			// ribbon
			// 
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnYeniEmanet,
            this.btnTeslimDurumu,
            this.btnKullanıcıListesi,
            this.lblGirisYapanKullanici,
            this.btnYeniEmanetKayit});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 7;
			this.ribbon.Name = "ribbon";
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
			this.ribbon.Size = new System.Drawing.Size(700, 143);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			// 
			// lblGirisYapanKullanici
			// 
			this.lblGirisYapanKullanici.Caption = "...";
			this.lblGirisYapanKullanici.Id = 4;
			this.lblGirisYapanKullanici.Name = "lblGirisYapanKullanici";
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.lblGirisYapanKullanici);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 420);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbon;
			this.ribbonStatusBar.Size = new System.Drawing.Size(700, 31);
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
			this.xtraTabbedMdiManager1.MdiParent = this;
			this.xtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.btnYeniEmanetKayit);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			// 
			// btnYeniEmanetKayit
			// 
			this.btnYeniEmanetKayit.Caption = "Yeni Emanet Kayıt";
			this.btnYeniEmanetKayit.Id = 6;
			this.btnYeniEmanetKayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
			this.btnYeniEmanetKayit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
			this.btnYeniEmanetKayit.Name = "btnYeniEmanetKayit";
			this.btnYeniEmanetKayit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniEmanetKayit_ItemClick);
			// 
			// frmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 451);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbon);
			this.IsMdiContainer = true;
			this.Name = "frmAnaForm";
			this.Ribbon = this.ribbon;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "Emanetçi Tükkanı";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAnaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.BarButtonItem btnYeniEmanet;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem btnTeslimDurumu;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.BarButtonItem btnKullanıcıListesi;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.BarStaticItem lblGirisYapanKullanici;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarButtonItem btnYeniEmanetKayit;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
	}
}