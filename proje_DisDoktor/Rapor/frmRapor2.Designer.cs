namespace proje_DisDoktor.Rapor
{
	partial class frmRapor2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor2));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnRaporla);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(716, 39);
			this.panelControl1.TabIndex = 0;
			// 
			// gcListe
			// 
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 39);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.Size = new System.Drawing.Size(716, 420);
			this.gcListe.TabIndex = 1;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
			// 
			// gvListe
			// 
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.Name = "gvListe";
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
			// frmRapor2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 459);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmRapor2";
			this.Text = "frmRapor2";
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
	}
}