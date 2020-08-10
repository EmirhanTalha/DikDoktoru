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
using DevExpress.XtraEditors;

namespace proje_EmanetTukkani.Kullanici
{
	public partial class frmKullaniciListe : DevExpress.XtraEditors.XtraForm
	{
		public frmKullaniciListe()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		private void frmKullaniciListe_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand=new SqlCommand(@"SELECT KullaniciID, KullaniciAdSoyad, KullaniciKodu, KullaniciSifre, Aktif FROM dbo.Kullanici",CsDosyası.csBaglanti.BaglantiGetir()))
				{
					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gvListe.Columns["KullaniciID"].Visible = false;
				gvListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay("-1");
				if (frmKullaniciDetay.ShowDialog() == DialogResult.OK)
				{
					btnGuncelle_Click(null, null);
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvListe.FocusedRowHandle < 0) return;
				int seciliSatirNo = gvListe.FocusedRowHandle;

				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"Delete From Kullanici Where KullaniciID=@KullaniciID", CsDosyası.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("KullaniciID").ToString();
					cmd.ExecuteNonQuery();
				}
				btnGuncelle_Click(null, null);

				gvListe.FocusedRowHandle = seciliSatirNo - 1;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnDegistir_Click(object sender, EventArgs e)
		{
			int satir =gvListe.FocusedRowHandle;
			frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay(gvListe.GetFocusedRowCellDisplayText("KullaniciID"));
			if (frmKullaniciDetay.ShowDialog()==DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
				gvListe.FocusedRowHandle = satir;
			}

			//int satir = gvListe.FocusedRowHandle;
			//frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay(gvListe.GetFocusedRowCellDisplayText("KullaniciID"));
			//if (frmKullaniciDetay.ShowDialog() == DialogResult.OK)
			//{
			//	btnGuncelle_Click(null, null);
			//	gvListe.FocusedRowHandle = satir;
			//}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			dt.Clear();
			da.Fill(dt);
			//gvListe.BestFitColumns();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				CsDosyası.csExceleAktar a = new CsDosyası.csExceleAktar();
				a.ExceleAktar(gcListe);
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
	}
}