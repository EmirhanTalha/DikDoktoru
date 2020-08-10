using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace proje_EmanetTukkani
{
	public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
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

		private void frmAnaForm_Load(object sender, EventArgs e)
		{
			lblGirisYapanKullanici.Caption = "Kullanıcı: " + CsDosyası.csKullanici.KullaniciAdSoyad + " | Veritabanı: " + CsDosyası.csBaglanti.BaglantiGetir().DataSource + "\\" + CsDosyası.csBaglanti.BaglantiGetir().Database;
		}		

		private void btnTeslimDurumu_ItemClick(object sender, ItemClickEventArgs e)
		{
			Emanet.frmEmanetler frmEmanetler = new Emanet.frmEmanetler();
			FormuAc(frmEmanetler);
		}

		private void btnKullanıcıListesi_ItemClick(object sender, ItemClickEventArgs e)
		{
			Kullanici.frmKullaniciListe frmKullaniciListe = new Kullanici.frmKullaniciListe();
			FormuAc(frmKullaniciListe);
		}

		private void btnYeniEmanetKayit_ItemClick(object sender, ItemClickEventArgs e)
		{
			Emanet.frmYeniEmanet frmYeniEmanet = new Emanet.frmYeniEmanet("-1");
			if (frmYeniEmanet.ShowDialog() == DialogResult.OK)
			{
				btnTeslimDurumu_ItemClick(null, null);
			}
		}
	}
}