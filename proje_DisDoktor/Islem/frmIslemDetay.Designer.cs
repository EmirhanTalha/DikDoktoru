namespace proje_DisDoktor.Islem
{
	partial class frmIslemDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIslemDetay));
			this.txtUcret = new DevExpress.XtraEditors.TextEdit();
			this.txtIslemTanim = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtUcret.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtIslemTanim.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUcret
			// 
			this.txtUcret.Location = new System.Drawing.Point(113, 48);
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(143, 20);
			this.txtUcret.TabIndex = 14;
			// 
			// txtIslemTanim
			// 
			this.txtIslemTanim.Location = new System.Drawing.Point(113, 22);
			this.txtIslemTanim.Name = "txtIslemTanim";
			this.txtIslemTanim.Size = new System.Drawing.Size(143, 20);
			this.txtIslemTanim.TabIndex = 13;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(106, 52);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(4, 13);
			this.labelControl7.TabIndex = 20;
			this.labelControl7.Text = ":";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(106, 26);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(4, 13);
			this.labelControl8.TabIndex = 19;
			this.labelControl8.Text = ":";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 52);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(26, 13);
			this.labelControl2.TabIndex = 17;
			this.labelControl2.Text = "Ücret";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(56, 13);
			this.labelControl1.TabIndex = 15;
			this.labelControl1.Text = "İşlem Tanım";
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(216, 84);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(40, 35);
			this.btnKaydet.TabIndex = 22;
			this.btnKaydet.Text = "simpleButton5";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
			this.btnIptal.Location = new System.Drawing.Point(176, 84);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(40, 35);
			this.btnIptal.TabIndex = 23;
			this.btnIptal.Text = "simpleButton4";
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// frmIslemDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 137);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.txtUcret);
			this.Controls.Add(this.txtIslemTanim);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmIslemDetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İşlem Detay";
			this.Load += new System.EventHandler(this.frmIslemDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtUcret.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtIslemTanim.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraEditors.TextEdit txtUcret;
		private DevExpress.XtraEditors.TextEdit txtIslemTanim;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
	}
}