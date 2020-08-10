namespace proje_DisDoktor.Tanimlamalar
{
	partial class frmHastaDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaDetay));
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
			this.txtAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtTCKimlikNo = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.lblTCKimlikNo = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTCKimlikNo.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(218, 101);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(40, 35);
			this.btnKaydet.TabIndex = 30;
			this.btnKaydet.Text = "simpleButton5";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
			this.btnIptal.Location = new System.Drawing.Point(178, 101);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(40, 35);
			this.btnIptal.TabIndex = 31;
			this.btnIptal.Text = "simpleButton4";
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(115, 38);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(143, 20);
			this.txtSoyad.TabIndex = 25;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(115, 12);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(143, 20);
			this.txtAd.TabIndex = 24;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(108, 42);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(4, 13);
			this.labelControl7.TabIndex = 29;
			this.labelControl7.Text = ":";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(108, 16);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(4, 13);
			this.labelControl8.TabIndex = 28;
			this.labelControl8.Text = ":";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(14, 42);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(30, 13);
			this.labelControl2.TabIndex = 27;
			this.labelControl2.Text = "Soyad";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(14, 16);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(19, 13);
			this.labelControl1.TabIndex = 26;
			this.labelControl1.Text = " Ad ";
			// 
			// txtTCKimlikNo
			// 
			this.txtTCKimlikNo.Location = new System.Drawing.Point(115, 64);
			this.txtTCKimlikNo.Name = "txtTCKimlikNo";
			this.txtTCKimlikNo.Size = new System.Drawing.Size(143, 20);
			this.txtTCKimlikNo.TabIndex = 32;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(108, 68);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(4, 13);
			this.labelControl3.TabIndex = 34;
			this.labelControl3.Text = ":";
			// 
			// lblTCKimlikNo
			// 
			this.lblTCKimlikNo.Location = new System.Drawing.Point(14, 68);
			this.lblTCKimlikNo.Name = "lblTCKimlikNo";
			this.lblTCKimlikNo.Size = new System.Drawing.Size(57, 13);
			this.lblTCKimlikNo.TabIndex = 33;
			this.lblTCKimlikNo.Text = "TC Kimlik No";
			// 
			// frmHastaDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 155);
			this.Controls.Add(this.txtTCKimlikNo);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.lblTCKimlikNo);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHastaDetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasta  Detay";
			this.Load += new System.EventHandler(this.frmHastaDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTCKimlikNo.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
		private DevExpress.XtraEditors.TextEdit txtSoyad;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtTCKimlikNo;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl lblTCKimlikNo;
	}
}