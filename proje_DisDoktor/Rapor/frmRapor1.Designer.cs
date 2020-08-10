namespace proje_DisDoktor.Rapor
{
	partial class frmRapor1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor1));
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
			this.gcMaster = new DevExpress.XtraGrid.GridControl();
			this.gvMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gcDetail = new DevExpress.XtraGrid.GridControl();
			this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcMaster)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMaster)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Horizontal = false;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 46);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.splitContainerControl1.Panel1.Controls.Add(this.gcMaster);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.splitContainerControl1.Panel2.Controls.Add(this.gcDetail);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(730, 454);
			this.splitContainerControl1.SplitterPosition = 213;
			this.splitContainerControl1.TabIndex = 0;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnYenile);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(730, 46);
			this.panelControl1.TabIndex = 1;
			// 
			// btnYenile
			// 
			this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.btnYenile.Location = new System.Drawing.Point(5, 5);
			this.btnYenile.Name = "btnYenile";
			this.btnYenile.Size = new System.Drawing.Size(118, 35);
			this.btnYenile.TabIndex = 0;
			this.btnYenile.Text = "Yenile";
			this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
			// 
			// gcMaster
			// 
			this.gcMaster.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcMaster.Location = new System.Drawing.Point(0, 0);
			this.gcMaster.MainView = this.gvMaster;
			this.gcMaster.Name = "gcMaster";
			this.gcMaster.Size = new System.Drawing.Size(726, 209);
			this.gcMaster.TabIndex = 0;
			this.gcMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaster});
			// 
			// gvMaster
			// 
			this.gvMaster.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvMaster.GridControl = this.gcMaster;
			this.gvMaster.Name = "gvMaster";
			this.gvMaster.OptionsBehavior.Editable = false;
			this.gvMaster.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvMaster.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.gvMaster.OptionsView.EnableAppearanceEvenRow = true;
			this.gvMaster.OptionsView.EnableAppearanceOddRow = true;
			this.gvMaster.OptionsView.ShowFooter = true;
			this.gvMaster.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMaster_FocusedRowChanged);
			// 
			// gcDetail
			// 
			this.gcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcDetail.Location = new System.Drawing.Point(0, 0);
			this.gcDetail.MainView = this.gvDetail;
			this.gcDetail.Name = "gcDetail";
			this.gcDetail.Size = new System.Drawing.Size(726, 232);
			this.gcDetail.TabIndex = 0;
			this.gcDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetail});
			// 
			// gvDetail
			// 
			this.gvDetail.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvDetail.GridControl = this.gcDetail;
			this.gvDetail.Name = "gvDetail";
			this.gvDetail.OptionsBehavior.Editable = false;
			this.gvDetail.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvDetail.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.gvDetail.OptionsView.ColumnAutoWidth = false;
			this.gvDetail.OptionsView.EnableAppearanceEvenRow = true;
			this.gvDetail.OptionsView.EnableAppearanceOddRow = true;
			this.gvDetail.OptionsView.ShowGroupPanel = false;
			// 
			// frmRapor1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 500);
			this.Controls.Add(this.splitContainerControl1);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmRapor1";
			this.Text = "frmRapor1";
			this.Load += new System.EventHandler(this.frmRapor1_Load);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcMaster)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMaster)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraGrid.GridControl gcMaster;
		private DevExpress.XtraGrid.Views.Grid.GridView gvMaster;
		private DevExpress.XtraGrid.GridControl gcDetail;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton btnYenile;
	}
}