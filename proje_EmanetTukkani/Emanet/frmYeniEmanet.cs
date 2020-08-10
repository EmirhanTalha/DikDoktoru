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
using DevExpress.XtraEditors.DXErrorProvider;

namespace proje_EmanetTukkani.Emanet
{
	public partial class frmYeniEmanet : DevExpress.XtraEditors.XtraForm
	{
		public frmYeniEmanet(string EmanetID)
		{
			InitializeComponent();
			_EmanetID = EmanetID;
		}
		string _EmanetID = "-1";

		private void frmYeniEmanet_Load(object sender, EventArgs e)
		{
			try
			{
				#region lkpEmanetTuruDolduruluyor ;)
				using (SqlDataAdapter da = new SqlDataAdapter(@"Select EmanetTurID, TurTanim From EmanetTur", CsDosyası.csBaglanti.BaglantiGetir()))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);
					lkpEmanetTuru.Properties.DataSource = dt;
					lkpEmanetTuru.Properties.PopulateColumns();
					lkpEmanetTuru.Properties.ValueMember = "EmanetTurID";
					lkpEmanetTuru.Properties.DisplayMember = "TurTanim";

					lkpEmanetTuru.Properties.Columns["EmanetTurID"].Visible = false;
					lkpEmanetTuru.Properties.Columns["TurTanim"].Caption = "Eşya Türü Tanımı";
					lkpEmanetTuru.EditValue = -1;
				}
				#endregion

				#region TAŞINACAK REGİON
				//if (_EmanetID!="-1")
				//{
				//	using (SqlCommand cmd=new SqlCommand(@"SELECT dbo.Emanet.EmanetID, dbo.Emanetci.EmanetciID, dbo.Emanetci.TCNo, dbo.Emanetci.Ad, dbo.Emanetci.Soyad, dbo.Emanetci.TelefonNumarasi, dbo.EmanetTur.TurID, dbo.EmanetTur.TurTanim, dbo.Emanet.EmanetTanim, dbo.Emanet.EmanetAdet, dbo.Emanet.EmanetBoyut, dbo.Emanet.DolapSayisi, dbo.Emanet.RafSayisi, dbo.Emanet.SureBaslangic, dbo.Emanet.SureBitis, dbo.Emanet.GecenSure, dbo.Emanet.Ucret, dbo.Emanet.Durum FROM dbo.Emanet CROSS JOIN dbo.Emanetci CROSS JOIN dbo.EmanetTur WHERE (dbo.Emanet.EmanetID = @EmanetID)", CsDosyası.csBaglanti.BaglantiGetir()))
				//	{
				//		cmd.Parameters.Add("@EmanetID", SqlDbType.Int).Value = _EmanetID;
				//		using (SqlDataReader dr=cmd.ExecuteReader(CommandBehavior.SingleResult))
				//		{
				//			if (dr.Read())
				//			{
				//				txtTCKimlikNo.Text = dr["TCNO"].ToString();
				//				txtAd.Text = dr["Ad"].ToString();
				//				txtSoyad.Text = dr["Soyad"].ToString();
				//				txtTelefonNumarasi.Text = dr["TelefonNumarasi"].ToString();

				//				lkpEmanetTuru.EditValue = (int)dr["TurID"];
				//				txtEmanetTanim.Text = dr["EmanetTanim"].ToString();

				//				txtAdet.Text = dr["EmanetAdet"].ToString();
				//				txtDesi.Text = dr["EmanetBoyut"].ToString();
				//				txtAgirlik.Text = dr["EmanetBoyut"].ToString();

				//				txtDolapSayisi.Text = dr["DolapSayisi"].ToString();
				//				txtRafSayisi.Text = dr["RafSayisi"].ToString();

				//				deBaslangicSaati.DateTime = (DateTime)dr["SureBaslangic"];
				//			}
				//		}
				//	}
				//}
				#endregion
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
		int en, boy, yuksek, adet, desi, agir, dolap, raf;
		decimal cevap = 0;

		private void lkpEmanetTuru_EditValueChanged(object sender, EventArgs e)
		{
			if (lkpEmanetTuru.Text == "Çuval")
			{
				lkpEmanetTuru.BackColor = Color.White;
				txtEn.Enabled = false; txtEn.Text = "";
				txtYukseklik.Enabled = false; txtYukseklik.Text = "";
				txtBoy.Enabled = false; txtBoy.Text = "";
				txtDolapSayisi.Enabled = false; txtDolapSayisi.Text = "";
				txtEmanetTanim.Focus();
			}

			if (lkpEmanetTuru.Text == "Bavul")
			{
				lkpEmanetTuru.BackColor = Color.White;
				txtEn.Enabled = false; txtEn.Text = "";
				txtYukseklik.Enabled = false; txtYukseklik.Text = "";
				txtBoy.Enabled = false; txtBoy.Text = "";
				txtDolapSayisi.Enabled = false;
				txtEmanetTanim.Focus();
			}

			if (lkpEmanetTuru.Text == "Valiz")
			{
				txtEn.Enabled = true;
				txtYukseklik.Enabled = true;
				txtBoy.Enabled = true;				
				txtDolapSayisi.Enabled = true;
				txtEmanetTanim.Focus();
			}

			if (lkpEmanetTuru.Text == "Çanta")
			{
				txtEn.Enabled = true;
				txtYukseklik.Enabled = true;
				txtBoy.Enabled = true;
				txtDolapSayisi.Enabled = true;
				txtEmanetTanim.Focus();
			}

			if (lkpEmanetTuru.Text == "Torba(Poşet)")
			{
				txtEn.Enabled = true;
				txtYukseklik.Enabled = true;
				txtBoy.Enabled = true;
				txtDolapSayisi.Enabled = true;
				txtEmanetTanim.Focus();
			}

			if (lkpEmanetTuru.Text == "Değerli Eşya")
			{
				txtEn.Enabled = false;
				txtYukseklik.Enabled = false;
				txtBoy.Enabled = false;
				txtDolapSayisi.Enabled = false;
				txtEmanetTanim.Focus();
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				//dxErrorProvider1.ClearErrors(); HATA VERDİĞİ İÇİN KAPALI
				#region BOŞ ALAN KONTROLLERİ				
				if (string.IsNullOrWhiteSpace(txtTCKimlikNo.Text))
				{
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					txtTCKimlikNo.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtTelefonNumarasi.Text))
				{
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					txtTelefonNumarasi.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtAd.Text))
				{
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					txtAd.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtSoyad.Text))
				{
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					txtSoyad.Focus();
					return;
				}

				if ((int)lkpEmanetTuru.EditValue == -1)
				{
					//dxErrorProvider1.SetError(lkpEmanetTuru, "Boş geçilemez");
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					lkpEmanetTuru.Focus();
					lkpEmanetTuru.BackColor = Color.Red;
					return;
				}

				if (string.IsNullOrWhiteSpace(txtEmanetTanim.Text))
				{
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					txtEmanetTanim.Focus();
					return;
				}

				if (txtEn.Enabled = true && string.IsNullOrWhiteSpace(txtSoyad.Text))
				{
					XtraMessageBox.Show("Bu Alan Boş Geçilemez.");
					txtEn.Focus();
					return;
				}
				#endregion

				#region SORULACAK YER
				//int agirlik = Convert.ToInt32(txtAgirlik.Text), desi = 0;
				//desi = (Convert.ToInt32(txtEn.Text) * Convert.ToInt32(txtYukseklik.Text) * Convert.ToInt32(txtBoy.Text)) / 3000;
				//txtDesi.Text = desi.ToString();
				//if (agirlik > 7.5M || desi > 55)
				//{
				//	XtraMessageBox.Show("Lütfen emanete alınan ürünü raf bölümüne koyunuz!");
				//	txtRafSayisi.Focus();
				//	DAHA SONRA DÜZENLEME YAPILACAK
				//}
				#endregion

				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = CsDosyası.csBaglanti.BaglantiGetir();

				cmd.CommandText = "Insert into Emanet values(@EmanetTanim, @EmanetAdet, @EmanetBoyut, @DolapSayisi, @RafSayisi, @SureBaslangic, @Ucret, @Durum)";

				cmd.CommandText = "Insert into Emanetci Values(@TCNo, @Ad, @Soyad, @TelefonNumarasi)";

				cmd.CommandText = "Insert into EmanetTur values(@TurTanim)";

				//Eşya Bilgileri
				cmd.Parameters.Add("@EmanetTanim", SqlDbType.NVarChar).Value = txtEmanetTanim.Text;
				cmd.Parameters.Add("EmanetAdet", SqlDbType.Int).Value = txtAdet.Text;
				if (txtDesi.Text != "")
				{
					cmd.Parameters.Add("EmanetBoyut", SqlDbType.Int).Value = txtDesi.Text;
				}
				else
				{
					cmd.Parameters.Add("EmanetBoyut", SqlDbType.Int).Value = txtAgirlik.Text;
				}
				cmd.Parameters.Add("DolapSayisi", SqlDbType.Int).Value = txtDolapSayisi.Text;
				cmd.Parameters.Add("RafSayisi", SqlDbType.Int).Value = txtRafSayisi.Text;
				cmd.Parameters.Add("SureBaslangic", SqlDbType.DateTime).Value = deBaslangicSaati.DateTime.ToShortDateString();
				cmd.Parameters.Add("Ucret", SqlDbType.Int).Value = lblUcret.Text;
				cmd.Parameters.Add("Durum", SqlDbType.Bit).Value = 1;

				//Müşteri Bilgileri
				cmd.Parameters.Add("TCNo", SqlDbType.Int).Value = txtTCKimlikNo.Text;
				cmd.Parameters.Add("Ad", SqlDbType.NVarChar).Value = txtAd.Text;
				cmd.Parameters.Add("Soyad", SqlDbType.NVarChar).Value = txtSoyad.Text;
				cmd.Parameters.Add("TelefonNumarasi", SqlDbType.Int).Value = txtTelefonNumarasi.Text;

				//Tür
				cmd.Parameters.Add("TurTanim", SqlDbType.NVarChar).Value = lkpEmanetTuru.EditValue.ToString();

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.Close();
			//Cancel çeviri yapılacak
		}

		private void txtEn_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();		
		}

		private void txtBoy_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();
		}

		private void txtYukseklik_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();
		}

		private void txtAdet_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();
		}


		private void txtAgirlik_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();
		}

		private void txtDolapSayisi_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();
		}

		private void txtRafSayisi_EditValueChanged(object sender, EventArgs e)
		{
			Hesap();
		}

		public decimal Hesap()
		{
			if (txtEn.Enabled)
				int.TryParse(txtEn.Text, out en);			

			if (txtBoy.Enabled)
				int.TryParse(txtBoy.Text, out boy);

			if (txtYukseklik.Enabled)
				int.TryParse(txtYukseklik.Text, out yuksek);

			int.TryParse(txtAdet.Text, out adet);
			//Hesaplama Yapılacak adete göre

			if (txtAgirlik.Enabled)
				int.TryParse(txtAgirlik.Text, out agir);

			if (txtDolapSayisi.Enabled)
				int.TryParse(txtDolapSayisi.Text, out dolap);

			if (txtRafSayisi.Enabled)
				int.TryParse(txtRafSayisi.Text, out raf);
				
			//desi hesaplama
			desi = en * boy * yuksek / 3000;

			txtDesi.Text = desi.ToString();

			if (desi>55 && agir>7.5M)
			{
				txtDolapSayisi.Enabled = false;
				txtRafSayisi.Enabled = true;
			}
			else
			{
				txtDolapSayisi.Enabled = true;
				txtRafSayisi.Enabled = false;
			}

			




			return cevap;
		}

		private void lblUcret_TextChanged(object sender, EventArgs e)
		{
			lblUcret.Text = cevap.ToString();
		}
	}
}