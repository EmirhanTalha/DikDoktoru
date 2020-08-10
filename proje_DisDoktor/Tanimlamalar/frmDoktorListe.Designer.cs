namespace proje_DisDoktor.Tanimlamalar
{
	partial class frmDoktorListe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorListe));
			this.txtgvKullaniciSifre = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.gVListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDoktorID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.txtgvKullaniciSifre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gVListe)).BeginInit();
			this.SuspendLayout();
			// 
			// txtgvKullaniciSifre
			// 
			this.txtgvKullaniciSifre.AutoHeight = false;
			this.txtgvKullaniciSifre.Name = "txtgvKullaniciSifre";
			this.txtgvKullaniciSifre.PasswordChar = '*';
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(120, 4);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(40, 35);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "simpleButton6";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
			this.btnExcel.Location = new System.Drawing.Point(200, 4);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(40, 35);
			this.btnExcel.TabIndex = 5;
			this.btnExcel.Text = "simpleButton5";
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(160, 4);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(40, 35);
			this.btnKapat.TabIndex = 4;
			this.btnKapat.Text = "simpleButton4";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnDegistir
			// 
			this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
			this.btnDegistir.Location = new System.Drawing.Point(80, 4);
			this.btnDegistir.Name = "btnDegistir";
			this.btnDegistir.Size = new System.Drawing.Size(40, 35);
			this.btnDegistir.TabIndex = 2;
			this.btnDegistir.Text = "simpleButton3";
			this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
			// 
			// btnSil
			// 
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(40, 4);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(40, 35);
			this.btnSil.TabIndex = 1;
			this.btnSil.Text = "simpleButton2";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
			this.btnEkle.Location = new System.Drawing.Point(0, 4);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(40, 35);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "simpleButton1";
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnGuncelle);
			this.panelControl1.Controls.Add(this.btnExcel);
			this.panelControl1.Controls.Add(this.btnKapat);
			this.panelControl1.Controls.Add(this.btnDegistir);
			this.panelControl1.Controls.Add(this.btnSil);
			this.panelControl1.Controls.Add(this.btnEkle);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(0, 441);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(756, 42);
			this.panelControl1.TabIndex = 1;
			// 
			// gcListe
			// 
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 0);
			this.gcListe.MainView = this.gVListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.Size = new System.Drawing.Size(756, 441);
			this.gcListe.TabIndex = 2;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVListe});
			// 
			// gVListe
			// 
			this.gVListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDoktorID,
            this.colAd,
            this.colSoyad});
			this.gVListe.GridControl = this.gcListe;
			this.gVListe.Name = "gVListe";
			// 
			// colDoktorID
			// 
			this.colDoktorID.Caption = "DoktorID";
			this.colDoktorID.FieldName = "DoktorID";
			this.colDoktorID.Name = "colDoktorID";
			this.colDoktorID.Visible = true;
			this.colDoktorID.VisibleIndex = 0;
			// 
			// colAd
			// 
			this.colAd.Caption = "Ad";
			this.colAd.FieldName = "Ad";
			this.colAd.Name = "colAd";
			this.colAd.Visible = true;
			this.colAd.VisibleIndex = 1;
			// 
			// colSoyad
			// 
			this.colSoyad.Caption = "Soyad";
			this.colSoyad.FieldName = "Soyad";
			this.colSoyad.Name = "colSoyad";
			this.colSoyad.Visible = true;
			this.colSoyad.VisibleIndex = 2;
			// 
			// frmDoktorListe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 483);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDoktorListe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doktor Liste";
			this.Load += new System.EventHandler(this.frmDoktorListe_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtgvKullaniciSifre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gVListe)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtgvKullaniciSifre;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnExcel;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnDegistir;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private DevExpress.XtraEditors.SimpleButton btnEkle;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl gcListe;
		private DevExpress.XtraGrid.Views.Grid.GridView gVListe;
		private DevExpress.XtraGrid.Columns.GridColumn colDoktorID;
		private DevExpress.XtraGrid.Columns.GridColumn colAd;
		private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
	}
}