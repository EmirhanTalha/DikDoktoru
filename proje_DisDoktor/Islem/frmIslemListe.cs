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

namespace proje_DisDoktor.Islem
{
	public partial class frmIslemListe : DevExpress.XtraEditors.XtraForm
	{
		public frmIslemListe()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();
		private void frmIslemListe_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"Select IslemID, IslemTanim, Ucret From Islem", cs.csBaglanti.BaglantiGetir()))
				{

					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gVListe.Columns["IslemID"].Visible = false;
				//kolonun uzunluğunu, hücrenin içindeki veri kadar uzatır.
				gVListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			Islem.frmIslemDetay frmIslemDetay = new frmIslemDetay("-1");
			if (frmIslemDetay.ShowDialog() == DialogResult.OK)
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

				using (var cmd = new SqlCommand(@"Delete From Islem Where IslemID=@IslemID", proje_DisDoktor.cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@IslemID", SqlDbType.Int).Value = gVListe.GetFocusedRowCellValue("IslemID").ToString();
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
			Islem.frmIslemDetay frmIslemDetay = new frmIslemDetay(gVListe.GetFocusedRowCellDisplayText("IslemID"));
			if (frmIslemDetay.ShowDialog() == DialogResult.OK)
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
	}
}