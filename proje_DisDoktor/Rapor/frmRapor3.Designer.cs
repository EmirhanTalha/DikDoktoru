namespace proje_DisDoktor.Rapor
{
	partial class frmRapor3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor3));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDoktorAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHastaAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIslemTanim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUcret = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnGrupIslemi = new DevExpress.XtraEditors.SimpleButton();
			this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnGrupIslemi);
			this.panelControl1.Controls.Add(this.btnRaporla);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(599, 39);
			this.panelControl1.TabIndex = 2;
			// 
			// btnRaporla
			// 
			this.btnRaporla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporla.ImageOptions.Image")));
			this.btnRaporla.Location = new System.Drawing.Point(5, 4);
			this.btnRaporla.Name = "btnRaporla";
			this.btnRaporla.Size = new System.Drawing.Size(89, 30);
			this.btnRaporla.TabIndex = 0;
			this.btnRaporla.Text = "Raporla";
			this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
			// 
			// gcListe
			// 
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 39);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.Size = new System.Drawing.Size(599, 358);
			this.gcListe.TabIndex = 3;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
			// 
			// gvListe
			// 
			this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDoktorAdSoyad,
            this.colHastaAdSoyad,
            this.colIslemTanim,
            this.colUcret,
            this.colTarih});
			this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.GroupCount = 3;
			this.gvListe.Name = "gvListe";
			this.gvListe.OptionsBehavior.Editable = false;
			this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvListe.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.gvListe.OptionsView.ColumnAutoWidth = false;
			this.gvListe.OptionsView.EnableAppearanceEvenRow = true;
			this.gvListe.OptionsView.EnableAppearanceOddRow = true;
			this.gvListe.OptionsView.ShowGroupPanel = false;
			this.gvListe.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDoktorAdSoyad, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHastaAdSoyad, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTarih, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colDoktorAdSoyad
			// 
			this.colDoktorAdSoyad.Caption = "Doktor Ad Soyad";
			this.colDoktorAdSoyad.FieldName = "DoktorAdSoyad";
			this.colDoktorAdSoyad.Name = "colDoktorAdSoyad";
			this.colDoktorAdSoyad.Visible = true;
			this.colDoktorAdSoyad.VisibleIndex = 0;
			this.colDoktorAdSoyad.Width = 101;
			// 
			// colHastaAdSoyad
			// 
			this.colHastaAdSoyad.Caption = "Hasta Ad Soyad";
			this.colHastaAdSoyad.FieldName = "HastaAdSoyad";
			this.colHastaAdSoyad.Name = "colHastaAdSoyad";
			this.colHastaAdSoyad.Visible = true;
			this.colHastaAdSoyad.VisibleIndex = 2;
			this.colHastaAdSoyad.Width = 97;
			// 
			// colIslemTanim
			// 
			this.colIslemTanim.Caption = "İşlem Tanım";
			this.colIslemTanim.FieldName = "IslemTanim";
			this.colIslemTanim.Name = "colIslemTanim";
			this.colIslemTanim.Visible = true;
			this.colIslemTanim.VisibleIndex = 0;
			this.colIslemTanim.Width = 202;
			// 
			// colUcret
			// 
			this.colUcret.Caption = "Ücret";
			this.colUcret.FieldName = "Ucret";
			this.colUcret.Name = "colUcret";
			this.colUcret.Visible = true;
			this.colUcret.VisibleIndex = 1;
			this.colUcret.Width = 114;
			// 
			// btnGrupIslemi
			// 
			this.btnGrupIslemi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.btnGrupIslemi.Location = new System.Drawing.Point(100, 4);
			this.btnGrupIslemi.Name = "btnGrupIslemi";
			this.btnGrupIslemi.Size = new System.Drawing.Size(122, 30);
			this.btnGrupIslemi.TabIndex = 1;
			this.btnGrupIslemi.Text = "Tüm Grupları Aç";
			this.btnGrupIslemi.Click += new System.EventHandler(this.btnGrupIslemi_Click);
			// 
			// colTarih
			// 
			this.colTarih.Caption = "Tarih";
			this.colTarih.FieldName = "Tarih";
			this.colTarih.Name = "colTarih";
			this.colTarih.Visible = true;
			this.colTarih.VisibleIndex = 0;
			this.colTarih.Width = 165;
			// 
			// frmRapor3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 397);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmRapor3";
			this.Text = "frmRapor3";
			this.Load += new System.EventHandler(this.frmRapor3_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton btnRaporla;
		private DevExpress.XtraGrid.GridControl gcListe;
		private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
		private DevExpress.XtraGrid.Columns.GridColumn colDoktorAdSoyad;
		private DevExpress.XtraGrid.Columns.GridColumn colHastaAdSoyad;
		private DevExpress.XtraGrid.Columns.GridColumn colIslemTanim;
		private DevExpress.XtraGrid.Columns.GridColumn colUcret;
		private DevExpress.XtraEditors.SimpleButton btnGrupIslemi;
		private DevExpress.XtraGrid.Columns.GridColumn colTarih;
	}
}