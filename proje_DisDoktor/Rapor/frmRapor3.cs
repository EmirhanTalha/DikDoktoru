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
using System.Data.SqlClient;

namespace proje_DisDoktor.Rapor
{
	public partial class frmRapor3 : DevExpress.XtraEditors.XtraForm
	{
		public frmRapor3()
		{
			InitializeComponent();
		}
		DataTable dt = new DataTable();

		SqlDataAdapter da = new SqlDataAdapter();
		private void frmRapor3_Load(object sender, EventArgs e)
		{
			
		}

		private void btnRaporla_Click(object sender, EventArgs e)
		{
			try
			{
				da = new SqlDataAdapter(@"SELECT        dbo.Doktor.Ad + ' ' + dbo.Doktor.Soyad AS DoktorAdSoyad, dbo.Hasta.Ad + ' ' + dbo.Hasta.Soyad AS HastaAdSoyad, dbo.Hasta.TCKimlikNo, 
                         dbo.UygulamaMaster.Tarih, dbo.UygulamaMaster.ToplamUcret, dbo.UygulamaMaster.Aciklama, dbo.Islem.IslemTanim, dbo.Islem.Ucret
FROM            dbo.UygulamaMaster INNER JOIN
                         dbo.UygulamaDetay ON dbo.UygulamaMaster.UygulamaMasterID = dbo.UygulamaDetay.UygulamaMasterID INNER JOIN
                         dbo.Hasta ON dbo.UygulamaMaster.HastaID = dbo.Hasta.HastaID INNER JOIN
                         dbo.Islem ON dbo.UygulamaDetay.IslemID = dbo.Islem.IslemID INNER JOIN
                         dbo.Doktor ON dbo.UygulamaMaster.DoktorID = dbo.Doktor.DoktorID", cs.csBaglanti.BaglantiGetir());
				da.Fill(dt);

				gcListe.DataSource = dt;
				gvListe.Columns["IslemTanim"].Width = 250;
				gvListe.Columns["Ucret"].Width = 150;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnGrupIslemi_Click(object sender, EventArgs e)
		{
			if (btnGrupIslemi.Text == "Tüm Grupları Kapat")
			{
				btnGrupIslemi.Text = "Tüm Grupları Aç";
				gvListe.CollapseAllGroups();
			}
			else
			{
				btnGrupIslemi.Text = "Tüm Grupları Kapat";
				gvListe.ExpandAllGroups();
			}
		}
	}
}