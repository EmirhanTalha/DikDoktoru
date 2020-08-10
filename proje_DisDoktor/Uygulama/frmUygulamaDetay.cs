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
	public partial class frmUygulamaDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmUygulamaDetay(string UygulamaMasterID)
		{
			InitializeComponent();
			_UygulamaMasterID = UygulamaMasterID;
		}
		string _UygulamaMasterID = "-1";
		DataTable dtIslem = new DataTable();
		private void frmUygulamaDetay_Load(object sender, EventArgs e)
		{
			dtIslem.Columns.Add("IslemID", typeof(System.Int32));
			dtIslem.Columns.Add("IslemTanim", typeof(System.String));
			dtIslem.Columns.Add("Ucret", typeof(System.Decimal));

			gcIslem.DataSource = dtIslem;
			//Grid kolonlarının uzunluğunu, satırlarının içindeki veriyi en çok gösterebilecek şekilde ayarlar.
			gvIslem.BestFitColumns();

			deTarih.DateTime = DateTime.Now;

			#region lkpDoktor
			using (SqlDataAdapter da = new SqlDataAdapter(@"Select DoktorID, Ad+' '+ Soyad as AdSoyad From Doktor order by AdSoyad", cs.csBaglanti.BaglantiGetir()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				lkpDoktor.Properties.DataSource = dt;
				lkpDoktor.Properties.PopulateColumns();
				lkpDoktor.Properties.ValueMember = "DoktorID";
				lkpDoktor.Properties.DisplayMember = "AdSoyad";

				lkpDoktor.Properties.Columns["DoktorID"].Visible = false;
				lkpDoktor.Properties.Columns["AdSoyad"].Caption = @"Doktor";
				lkpDoktor.EditValue = -1;
			}
			#endregion
			#region lkpHasta
			using (SqlDataAdapter da = new SqlDataAdapter(@"Select HastaID, Ad+' '+ Soyad as AdSoyad From Hasta order by AdSoyad", cs.csBaglanti.BaglantiGetir()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				lkpHasta.Properties.DataSource = dt;
				lkpHasta.Properties.PopulateColumns();
				lkpHasta.Properties.ValueMember = "HastaID";
				lkpHasta.Properties.DisplayMember = "AdSoyad";

				lkpHasta.Properties.Columns["HastaID"].Visible = false;
				lkpHasta.Properties.Columns["AdSoyad"].Caption = @"Hasta";
				lkpHasta.EditValue = -1;
			}
			#endregion
			#region lkpIslem
			using (SqlDataAdapter da = new SqlDataAdapter(@"Select IslemID, IslemTanim+' ('+ CONVERT(NVARCHAR(50),Ucret)+')' AS Islem  From Islem order by IslemTanim", cs.csBaglanti.BaglantiGetir()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				lkpIslem.Properties.DataSource = dt;
				lkpIslem.Properties.PopulateColumns();
				lkpIslem.Properties.ValueMember = "IslemID";
				lkpIslem.Properties.DisplayMember = "Islem";

				lkpIslem.Properties.Columns["IslemID"].Visible = false;
				lkpIslem.Properties.Columns["Islem"].Caption = @"İşlem Tanım";
				lkpIslem.EditValue = -1;
			}
			#endregion


			if (_UygulamaMasterID != "-1")
			{
				using (SqlCommand cmd = new SqlCommand(@"SELECT UygulamaMasterID, Tarih, ToplamUcret, Aciklama, DoktorID, HastaID FROM dbo.UygulamaMaster WHERE (UygulamaMasterID = @UygulamaMasterID)",
				cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@UygulamaMasterID", SqlDbType.Int).Value = _UygulamaMasterID;
					using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
					{
						if (dr.Read())
						{
							txtToplamUcret.Text = dr["ToplamUcret"].ToString();
							lkpDoktor.EditValue = (int)dr["DoktorID"];
							lkpHasta.EditValue = (int)dr["HastaID"];
							deTarih.DateTime = (DateTime)dr["Tarih"];
							memoAciklama.Text = dr["Aciklama"].ToString();
						}
					}
				}

				using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT dbo.Islem.IslemID, dbo.Islem.IslemTanim, dbo.Islem.Ucret
FROM dbo.UygulamaDetay INNER JOIN dbo.Islem ON dbo.UygulamaDetay.IslemID = dbo.Islem.IslemID
WHERE (dbo.UygulamaDetay.UygulamaMasterID = @UygulamaMasterID)", cs.csBaglanti.BaglantiGetir()))
				{
					da.SelectCommand.Parameters.Add("@UygulamaMasterID", SqlDbType.Int).Value = _UygulamaMasterID;
					da.Fill(dtIslem);
				}

			}
		}

		private void lkpIslem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (e.Button.Index == 1)
			{
				if ((int)lkpIslem.EditValue < 0)
					return;

				DataRow satir = dtIslem.NewRow();
				satir["IslemID"] = lkpIslem.EditValue;
				satir["IslemTanim"] = lkpIslem.Text.Split('(')[0]; //Dolgu (150.00)
				satir["Ucret"] = lkpIslem.Text.Split('(')[1].Split(')')[0].Replace(".", ",");
				dtIslem.Rows.Add(satir);

				//Grid altındaki "Toplam Verisini" istediğimiz başka alana atabiliriz.
				txtToplamUcret.Text = gvIslem.Columns["Ucret"].SummaryItem.SummaryValue.ToString();
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				string yeniID = "-1";
				//SET @YeniID=SCOPE_IDENTITY() -> eklenen yeni satırın ID sini @YeniID değişkeninin içerisine atar

				if (_UygulamaMasterID == "-1")
				{
					cmd.CommandText = @"Insert Into UygulamaMaster(DoktorID, HastaID, Tarih, ToplamUcret, Aciklama) values(@DoktorID, @HastaID, @Tarih, @ToplamUcret, @Aciklama) SET @YeniID=SCOPE_IDENTITY()";

					cmd.Parameters.Add("@YeniID", SqlDbType.Int).Direction = ParameterDirection.Output;
				}
				else
				{
					cmd.CommandText = @"Update UygulamaMaster SET DoktorID=@DoktorID, HastaID=@HastaID, Tarih=@Tarih, ToplamUcret=@ToplamUcret, Aciklama=@Aciklama Where UygulamaMasterID=@UygulamaMasterID";
					cmd.Parameters.Add("@UygulamaMasterID", SqlDbType.Int).Value = _UygulamaMasterID;
				}

				cmd.Parameters.Add("@DoktorID", SqlDbType.Int).Value = lkpDoktor.EditValue.ToString();
				cmd.Parameters.Add("@HastaID", SqlDbType.Int).Value = lkpHasta.EditValue.ToString();
				cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = deTarih.DateTime;
				cmd.Parameters.Add("@ToplamUcret", SqlDbType.Decimal).Value = txtToplamUcret.Text;
				cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = memoAciklama.Text;

				cmd.ExecuteNonQuery();
				if (_UygulamaMasterID == "-1")
					yeniID = cmd.Parameters["@YeniID"].Value.ToString();

				cmd.Parameters.Clear();
				cmd.CommandText = "Delete From UygulamaDetay  Where UygulamaMasterID=@UygulamaMasterID";
				cmd.Parameters.Add("@UygulamaMasterID", SqlDbType.Int).Value = _UygulamaMasterID;
				cmd.ExecuteNonQuery();

				foreach (DataRow satir in dtIslem.AsEnumerable())
				{
					if (satir.RowState == DataRowState.Deleted)
					{
						MessageBox.Show("Silinen Satır İşlem Tanım: " + satir["IslemTanim", DataRowVersion.Original].ToString());
						continue;
					}
					cmd.Parameters.Clear();
					cmd.CommandText = @"Insert Into UygulamaDetay (UygulamaMasterID, IslemID) values(@UygulamaMasterID, @IslemID)";
					cmd.Parameters.Add("@UygulamaMasterID", SqlDbType.Int).Value = (_UygulamaMasterID == "-1") ? yeniID : _UygulamaMasterID;
					cmd.Parameters.Add("@IslemID", SqlDbType.Int).Value = satir["IslemID"].ToString();

					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Kaydetme işlemi başarılı");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void gcIslem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				gvIslem.DeleteRow(gvIslem.FocusedRowHandle);
				txtToplamUcret.Text = gvIslem.Columns["Ucret"].SummaryItem.SummaryValue.ToString();
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}