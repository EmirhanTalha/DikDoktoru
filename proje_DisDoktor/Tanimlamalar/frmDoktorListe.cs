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

namespace proje_DisDoktor.Tanimlamalar
{
	public partial class frmDoktorListe : DevExpress.XtraEditors.XtraForm
	{


		public frmDoktorListe()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();
		private void btnEkle_Click(object sender, EventArgs e)
		{
			frmDoktorDetay frmDoktorDetay = new frmDoktorDetay("-1");
			if (frmDoktorDetay.ShowDialog() == DialogResult.OK)
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

				using (var cmd = new SqlCommand(@"Delete From Doktor Where DoktorID=@DoktorID", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@DoktorID", SqlDbType.Int).Value = gVListe.GetFocusedRowCellValue("DoktorID").ToString();
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
			frmDoktorDetay frmDoktorDetay = new frmDoktorDetay(gVListe.GetFocusedRowCellDisplayText("DoktorID"));
			if (frmDoktorDetay.ShowDialog() == DialogResult.OK)
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

		}

		private void frmDoktorListe_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"Select DoktorID, Ad,Soyad From Doktor", cs.csBaglanti.BaglantiGetir()))
				{

					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gVListe.Columns["DoktorID"].Visible = false;
				//kolonun uzunluğunu, hücrenin içindeki veri kadar uzatır.
				gVListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
	}
}