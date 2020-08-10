using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace proje_DisDoktor.Rapor
{
	public partial class frmRapor1 : DevExpress.XtraEditors.XtraForm
	{
		public frmRapor1()
		{
			InitializeComponent();
		}
		SqlDataAdapter daMaster = new SqlDataAdapter();
		SqlDataAdapter daDetail = new SqlDataAdapter();

		DataTable dtMaster = new DataTable();
		DataTable dtDetail = new DataTable();
		bool yenilemeIslemiBitti = false;
		private void frmRapor1_Load(object sender, EventArgs e)
		{
			try
			{
				DateTime baslangic = DateTime.Now;
				yenilemeIslemiBitti = true;
				using (daMaster.SelectCommand = new SqlCommand(@"SELECT dbo.UygulamaMaster.UygulamaMasterID,  dbo.UygulamaMaster.Tarih, dbo.Doktor.Ad + ' ' + dbo.Doktor.Soyad AS DoktorAdSoyad, dbo.Hasta.Ad + ' ' + dbo.Hasta.Soyad AS HastaAdSoyad, 
                         dbo.Hasta.TCKimlikNo, dbo.UygulamaMaster.ToplamUcret, dbo.UygulamaMaster.Aciklama
FROM            dbo.UygulamaMaster INNER JOIN
                         dbo.Doktor ON dbo.UygulamaMaster.DoktorID = dbo.Doktor.DoktorID INNER JOIN
                         dbo.Hasta ON dbo.UygulamaMaster.HastaID = dbo.Hasta.HastaID
ORDER BY dbo.UygulamaMaster.Tarih, DoktorAdSoyad, HastaAdSoyad", cs.csBaglanti.BaglantiGetir()))
				{
					dtMaster.Clear();
					daMaster.Fill(dtMaster);
					gcMaster.DataSource = dtMaster;
				}
				
				gvMaster.Columns["UygulamaMasterID"].Visible = false;
				DateTime bitis = DateTime.Now;
				MessageBox.Show(baslangic.ToString() + "\n" + bitis.ToString());
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void gvMaster_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			try
			{
				if (!yenilemeIslemiBitti) return;
				if (gvMaster.FocusedRowHandle < 0) return;
				using (daDetail.SelectCommand = new SqlCommand(@"SELECT        dbo.Islem.IslemTanim, dbo.Islem.Ucret
FROM            dbo.UygulamaDetay INNER JOIN
                         dbo.Islem ON dbo.UygulamaDetay.IslemID = dbo.Islem.IslemID
WHERE        (dbo.UygulamaDetay.UygulamaMasterID = @UygulamaMasterID)", cs.csBaglanti.BaglantiGetir()))
				{
					daDetail.SelectCommand.Parameters.Add("@UygulamaMasterID",SqlDbType.Int).Value= gvMaster.GetFocusedRowCellDisplayText("UygulamaMasterID");
					dtDetail.Clear();
					daDetail.Fill(dtDetail);
					gcDetail.DataSource = dtDetail;
				}
				
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
	
		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			
			yenilemeIslemiBitti = false;
			dtMaster.Clear();
			daMaster.Fill(dtMaster);			
			yenilemeIslemiBitti = true;
			gvMaster_FocusedRowChanged(null, null);
			
		}
	}
}