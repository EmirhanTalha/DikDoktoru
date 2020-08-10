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
	public partial class frmRapor2 : DevExpress.XtraEditors.XtraForm
	{
		public frmRapor2()
		{
			InitializeComponent();
		}
		DataTable dtDoktor = new DataTable();
		DataTable dtHasta= new DataTable();
		DataTable dtUygulamaMaster = new DataTable();
		DataTable dtUygulamaDetail = new DataTable();

		SqlDataAdapter daDoktor = new SqlDataAdapter();
		SqlDataAdapter daHasta = new SqlDataAdapter();
		SqlDataAdapter daUygulamaMaster = new SqlDataAdapter();
		SqlDataAdapter daUygulamaDetail = new SqlDataAdapter();

		DataSet dsIslem = new DataSet();
		private void btnRaporla_Click(object sender, EventArgs e)
		{
			try
			{
				daDoktor = new SqlDataAdapter(@"SELECT DoktorID, Ad, Soyad FROM dbo.Doktor", cs.csBaglanti.BaglantiGetir());
				daDoktor.Fill(dtDoktor);

				daHasta = new SqlDataAdapter(@"SELECT        dbo.UygulamaMaster.DoktorID, dbo.UygulamaMaster.HastaID, dbo.Hasta.Ad, dbo.Hasta.Soyad, dbo.Hasta.TCKimlikNo
FROM            dbo.UygulamaDetay INNER JOIN
                         dbo.Islem ON dbo.UygulamaDetay.IslemID = dbo.Islem.IslemID INNER JOIN
                         dbo.UygulamaMaster ON dbo.UygulamaDetay.UygulamaMasterID = dbo.UygulamaMaster.UygulamaMasterID INNER JOIN
                         dbo.Hasta ON dbo.UygulamaMaster.HastaID = dbo.Hasta.HastaID", cs.csBaglanti.BaglantiGetir());
				daHasta.Fill(dtHasta);

				daUygulamaMaster = new SqlDataAdapter(@"SELECT UygulamaMasterID, DoktorID, HastaID, Tarih, ToplamUcret, Aciklama FROM dbo.UygulamaMaster", cs.csBaglanti.BaglantiGetir());
				daUygulamaMaster.Fill(dtUygulamaMaster);

				daUygulamaDetail = new SqlDataAdapter(@"SELECT  dbo.UygulamaDetay.UygulamaDetayID, dbo.UygulamaDetay.UygulamaMasterID, dbo.Islem.IslemTanim, dbo.Islem.Ucret FROM dbo.UygulamaDetay INNER JOIN dbo.Islem ON dbo.UygulamaDetay.IslemID = dbo.Islem.IslemID", cs.csBaglanti.BaglantiGetir());
				daUygulamaDetail.Fill(dtUygulamaDetail);

				daDoktor.Fill(dsIslem, "Doktor");
				daHasta.Fill(dsIslem, "Hasta");
				daUygulamaMaster.Fill(dsIslem, "UygulamaMaster");

				//dsIslem.Tables.Add(dtDoktor);
				//dsIslem.Tables.Add(dtHasta);
				//dsIslem.Tables.Add(dtUygulamaMaster);
				//dsIslem.Tables.Add(dtUygulamaDetail);

				DataRelation drlDoktorHasta = new DataRelation("DoktorHasta",
						 dsIslem.Tables["Doktor"].Columns["DoktorID"], dsIslem.Tables["Hasta"].Columns["DoktorID"]);
				DataRelation drlHastaUygulamaMaster = new DataRelation("HastaUygulamaMaster",
				dsIslem.Tables["Doktor"].Columns["DoktorID"], dsIslem.Tables["UygulamaMaster"].Columns["DoktorID"]);


				dsIslem.Relations.Add(drlDoktorHasta);
				dsIslem.Relations.Add(drlHastaUygulamaMaster);
				gcListe.DataSource = dsIslem;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}
	}
}