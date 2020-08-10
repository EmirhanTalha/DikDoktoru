using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace proje_DisDoktor
{
	public partial class frmAnaForm : DevExpress.XtraEditors.XtraForm
	{
		public frmAnaForm()
		{
			InitializeComponent();
		}
		public void FormuAc(Form GelenForm)
		{
			try
			{
				bool Durum = false;
				foreach (var item in this.MdiChildren)
				{
					if (item.Name == GelenForm.Name)
					{
						Durum = true;
						item.Activate();
					}
				}
				if (Durum == false)
				{
					GelenForm.MdiParent = this;
					GelenForm.Show();
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "input teknoloji a.ş.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		

		private void mbtnDoktor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Tanimlamalar.frmDoktorListe frmDoktorListe = new Tanimlamalar.frmDoktorListe();
			FormuAc(frmDoktorListe);
		}

		private void mbtnHasta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Tanimlamalar.frmHastaListe frmHastaListe = new Tanimlamalar.frmHastaListe();
			FormuAc(frmHastaListe);
		}

		private void frmAnaForm_Load(object sender, EventArgs e)
		{
	
		}

		private void btnIslemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Islem.frmIslemListe frmIslemListe = new Islem.frmIslemListe();
			FormuAc(frmIslemListe);
		}

		private void btnUygulamaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Uygulama.frmUygulamaListesi frmUygulamaListesi = new Uygulama.frmUygulamaListesi();
			FormuAc(frmUygulamaListesi);
		}

		private void btnUygulamaRaporu3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Rapor.frmRapor3 frmRapor3 = new Rapor.frmRapor3();
			FormuAc(frmRapor3);
		}

		private void btnUygulamaRaporu1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Rapor.frmRapor1 frmRapor1 = new Rapor.frmRapor1();
			FormuAc(frmRapor1);
		}

		private void btnUygulamaRaporu2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Rapor.frmRapor2 frmRapor2 = new Rapor.frmRapor2();
			FormuAc(frmRapor2);
		}
	}
}