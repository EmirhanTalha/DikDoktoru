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

namespace proje_DisDoktor.Uygulama
{
	public partial class frmUygulamaListesi : DevExpress.XtraEditors.XtraForm
	{
		public frmUygulamaListesi()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		private void frmUygulamaListesi_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"SELECT  dbo.UygulamaMaster.UygulamaMasterID, dbo.Doktor.Ad + N' ' + dbo.Doktor.Soyad AS DoktorAdSoyad, 
                         dbo.Hasta.Ad + N' ' + dbo.Hasta.Soyad AS HastaAdSoyad, dbo.UygulamaMaster.Tarih, dbo.UygulamaMaster.ToplamUcret, dbo.UygulamaMaster.Aciklama
FROM            dbo.UygulamaMaster INNER JOIN
                         dbo.Hasta ON dbo.UygulamaMaster.HastaID = dbo.Hasta.HastaID INNER JOIN
                         dbo.Doktor ON dbo.UygulamaMaster.DoktorID = dbo.Doktor.DoktorID
ORDER BY dbo.UygulamaMaster.Tarih DESC", cs.csBaglanti.BaglantiGetir()))
				{
					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gVListe.Columns["UygulamaMasterID"].Visible = false;
				gVListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
		private void btnEkle_Click(object sender, EventArgs e)
		{
			Uygulama.frmUygulamaDetay frmUygulamaDetay = new frmUygulamaDetay("-1");
			if (frmUygulamaDetay.ShowDialog() == DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
			}
		}
		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gVListe.FocusedRowHandle < 0) return;
				int seciliSatirNo = gVListe.FocusedRowHandle;

				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"
				Delete From UygulamaMaster Where UygulamaMasterID=@UygulamaMasterID;
				Delete From UygulamaDetay Where UygulamaMasterID=@UygulamaMasterID
				", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@UygulamaMasterID", SqlDbType.Int).Value = gVListe.GetFocusedRowCellValue("UygulamaMasterID").ToString();
					cmd.ExecuteNonQuery();
				}

				btnGuncelle_Click(null, null);

				gVListe.FocusedRowHandle = seciliSatirNo - 1;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}
		private void btnDegistir_Click(object sender, EventArgs e)
		{
			int satir = gVListe.FocusedRowHandle;
			Uygulama.frmUygulamaDetay frmUygulamaDetay = new frmUygulamaDetay(gVListe.GetFocusedRowCellDisplayText("UygulamaMasterID"));
			if (frmUygulamaDetay.ShowDialog() == DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
				gVListe.FocusedRowHandle = satir;
			}
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			dt.Clear();
			da.Fill(dt);
		}
		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnExcel_Click(object sender, EventArgs e)
		{
			cs.csExceleAktar excel = new cs.csExceleAktar();
			excel.ExceleAktar(gcListe);
		}
	}
}