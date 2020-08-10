namespace proje_DisDoktor.Uygulama
{
	partial class frmUygulamaDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUygulamaDetay));
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtToplamUcret = new DevExpress.XtraEditors.TextEdit();
			this.memoAciklama = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.deTarih = new DevExpress.XtraEditors.DateEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.lkpHasta = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.lkpDoktor = new DevExpress.XtraEditors.LookUpEdit();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.gcIslem = new DevExpress.XtraGrid.GridControl();
			this.gvIslem = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIslemID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIslemTanim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUcret = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.lkpIslem = new DevExpress.XtraEditors.LookUpEdit();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtToplamUcret.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpHasta.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpDoktor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcIslem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvIslem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpIslem.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.txtToplamUcret);
			this.groupControl1.Controls.Add(this.memoAciklama);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.deTarih);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.lkpHasta);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.lkpDoktor);
			this.groupControl1.Location = new System.Drawing.Point(1, 2);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(434, 139);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Uygulama Detay";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(18, 82);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(41, 13);
			this.labelControl5.TabIndex = 10;
			this.labelControl5.Text = "Açıklama";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(255, 58);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(63, 13);
			this.labelControl4.TabIndex = 9;
			this.labelControl4.Text = "Toplam Ücret";
			// 
			// txtToplamUcret
			// 
			this.txtToplamUcret.Enabled = false;
			this.txtToplamUcret.Location = new System.Drawing.Point(324, 55);
			this.txtToplamUcret.Name = "txtToplamUcret";
			this.txtToplamUcret.Size = new System.Drawing.Size(100, 20);
			this.txtToplamUcret.TabIndex = 3;
			// 
			// memoAciklama
			// 
			this.memoAciklama.Location = new System.Drawing.Point(74, 80);
			this.memoAciklama.Name = "memoAciklama";
			this.memoAciklama.Size = new System.Drawing.Size(350, 52);
			this.memoAciklama.TabIndex = 4;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(255, 31);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(24, 13);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Tarih";
			// 
			// deTarih
			// 
			this.deTarih.EditValue = null;
			this.deTarih.Location = new System.Drawing.Point(324, 28);
			this.deTarih.Name = "deTarih";
			this.deTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deTarih.Size = new System.Drawing.Size(100, 20);
			this.deTarih.TabIndex = 2;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(18, 58);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(28, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Hasta";
			// 
			// lkpHasta
			// 
			this.lkpHasta.Location = new System.Drawing.Point(74, 54);
			this.lkpHasta.Name = "lkpHasta";
			this.lkpHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lkpHasta.Size = new System.Drawing.Size(167, 20);
			this.lkpHasta.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(18, 32);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(32, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Doktor";
			// 
			// lkpDoktor
			// 
			this.lkpDoktor.Location = new System.Drawing.Point(74, 28);
			this.lkpDoktor.Name = "lkpDoktor";
			this.lkpDoktor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
			this.lkpDoktor.Size = new System.Drawing.Size(167, 20);
			this.lkpDoktor.TabIndex = 0;
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.gcIslem);
			this.groupControl2.Controls.Add(this.panelControl1);
			this.groupControl2.Location = new System.Drawing.Point(1, 147);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(434, 178);
			this.groupControl2.TabIndex = 1;
			this.groupControl2.Text = "İşlemler";
			// 
			// gcIslem
			// 
			this.gcIslem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcIslem.Location = new System.Drawing.Point(2, 52);
			this.gcIslem.MainView = this.gvIslem;
			this.gcIslem.Name = "gcIslem";
			this.gcIslem.Size = new System.Drawing.Size(430, 124);
			this.gcIslem.TabIndex = 1;
			this.gcIslem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIslem});
			this.gcIslem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcIslem_KeyDown);
			// 
			// gvIslem
			// 
			this.gvIslem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIslemID,
            this.colIslemTanim,
            this.colUcret});
			this.gvIslem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gvIslem.GridControl = this.gcIslem;
			this.gvIslem.Name = "gvIslem";
			this.gvIslem.OptionsBehavior.Editable = false;
			this.gvIslem.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvIslem.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.gvIslem.OptionsView.EnableAppearanceEvenRow = true;
			this.gvIslem.OptionsView.EnableAppearanceOddRow = true;
			this.gvIslem.OptionsView.ShowFooter = true;
			this.gvIslem.OptionsView.ShowGroupPanel = false;
			// 
			// colIslemID
			// 
			this.colIslemID.Caption = "IslemID";
			this.colIslemID.FieldName = "IslemID";
			this.colIslemID.Name = "colIslemID";
			// 
			// colIslemTanim
			// 
			this.colIslemTanim.Caption = "İşlem Tanım";
			this.colIslemTanim.FieldName = "IslemTanim";
			this.colIslemTanim.Name = "colIslemTanim";
			this.colIslemTanim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IslemTanim", "{0}")});
			this.colIslemTanim.Visible = true;
			this.colIslemTanim.VisibleIndex = 0;
			// 
			// colUcret
			// 
			this.colUcret.Caption = "Ücret";
			this.colUcret.FieldName = "Ucret";
			this.colUcret.Name = "colUcret";
			this.colUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ucret", "{0:0.##}")});
			this.colUcret.Visible = true;
			this.colUcret.VisibleIndex = 1;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.labelControl6);
			this.panelControl1.Controls.Add(this.lkpIslem);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(2, 20);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(430, 32);
			this.panelControl1.TabIndex = 0;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(5, 10);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(25, 13);
			this.labelControl6.TabIndex = 3;
			this.labelControl6.Text = "İşlem";
			// 
			// lkpIslem
			// 
			this.lkpIslem.Location = new System.Drawing.Point(36, 6);
			this.lkpIslem.Name = "lkpIslem";
			this.lkpIslem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
			this.lkpIslem.Size = new System.Drawing.Size(167, 20);
			this.lkpIslem.TabIndex = 0;
			this.lkpIslem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lkpIslem_ButtonClick);
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(395, 329);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(40, 35);
			this.btnKaydet.TabIndex = 2;
			this.btnKaydet.Text = "simpleButton5";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
			this.btnIptal.Location = new System.Drawing.Point(355, 329);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(40, 35);
			this.btnIptal.TabIndex = 3;
			this.btnIptal.Text = "simpleButton4";
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// frmUygulamaDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 370);
			this.ControlBox = false;
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUygulamaDetay";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uygulama Detayları";
			this.Load += new System.EventHandler(this.frmUygulamaDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtToplamUcret.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpHasta.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpDoktor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcIslem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvIslem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpIslem.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txtToplamUcret;
		private DevExpress.XtraEditors.MemoEdit memoAciklama;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.DateEdit deTarih;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LookUpEdit lkpHasta;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LookUpEdit lkpDoktor;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraGrid.GridControl gcIslem;
		private DevExpress.XtraGrid.Views.Grid.GridView gvIslem;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LookUpEdit lkpIslem;
		private DevExpress.XtraGrid.Columns.GridColumn colIslemID;
		private DevExpress.XtraGrid.Columns.GridColumn colIslemTanim;
		private DevExpress.XtraGrid.Columns.GridColumn colUcret;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
	}
}