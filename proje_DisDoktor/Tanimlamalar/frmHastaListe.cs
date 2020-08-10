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

namespace proje_DisDoktor.Tanimlamalar
{
	public partial class frmHastaListe : DevExpress.XtraEditors.XtraForm
	{
		public frmHastaListe()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();
		private void btnEkle_Click(object sender, EventArgs e)
		{
	  frmHastaDetay frmHastaDetay = new frmHastaDetay("-1");
			if (frmHastaDetay.ShowDialog() == DialogResult.OK)
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

				using (var cmd = new SqlCommand(@"Delete From Hasta Where HastaID=@HastaID", proje_DisDoktor.cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@HastaID", SqlDbType.Int).Value = gVListe.GetFocusedRowCellValue("HastaID").ToString();
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
			frmHastaDetay frmHastaDetay = new frmHastaDetay(gVListe.GetFocusedRowCellDisplayText("HastaID"));
			if (frmHastaDetay.ShowDialog() == DialogResult.OK)
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

		private void frmHastaListe_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"Select HastaID, Ad,Soyad,TCKimlikNo From Hasta",cs.csBaglanti.BaglantiGetir()))
				{

					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gVListe.Columns["HastaID"].Visible = false;
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