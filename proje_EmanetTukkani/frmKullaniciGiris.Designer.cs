namespace proje_EmanetTukkani
{
	partial class frmKullaniciGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGiris));
			this.txtKullaniciKodu = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
			this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKullaniciKodu
			// 
			this.txtKullaniciKodu.Location = new System.Drawing.Point(280, 68);
			this.txtKullaniciKodu.Name = "txtKullaniciKodu";
			this.txtKullaniciKodu.Size = new System.Drawing.Size(149, 20);
			this.txtKullaniciKodu.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(212, 71);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(64, 13);
			this.labelControl1.TabIndex = 4;
			this.labelControl1.Text = "Kullanıcı Kodu";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(212, 97);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(62, 13);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "Kullanıcı Şifre";
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.Location = new System.Drawing.Point(280, 94);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Size = new System.Drawing.Size(149, 20);
			this.txtKullaniciSifre.TabIndex = 1;
			// 
			// btnİptal
			// 
			this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
			this.btnİptal.Location = new System.Drawing.Point(281, 120);
			this.btnİptal.Name = "btnİptal";
			this.btnİptal.Size = new System.Drawing.Size(70, 23);
			this.btnİptal.TabIndex = 3;
			this.btnİptal.Text = "İptal";
			this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureEdit1.EditValue = global::proje_EmanetTukkani.Properties.Resources.emntemnyt1;
			this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
			this.pictureEdit1.Size = new System.Drawing.Size(188, 179);
			this.pictureEdit1.TabIndex = 6;
			// 
			// btnGiris
			// 
			this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
			this.btnGiris.Location = new System.Drawing.Point(359, 120);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(70, 23);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// frmKullaniciGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 201);
			this.Controls.Add(this.btnİptal);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.txtKullaniciSifre);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.txtKullaniciKodu);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKullaniciGiris";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcı Giriş";
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtKullaniciKodu;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.SimpleButton btnİptal;
	}
}