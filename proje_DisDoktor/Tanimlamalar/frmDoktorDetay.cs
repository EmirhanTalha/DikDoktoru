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
	public partial class frmDoktorDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmDoktorDetay(string DoktorID)
		{
			InitializeComponent();
			_DoktorID = DoktorID;
		}
		string _DoktorID = "-1";
		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrWhiteSpace(txtAd.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtAd.Focus();
					return;
				}
				if (String.IsNullOrWhiteSpace(txtSoyad.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtSoyad.Focus();
					return;
				}
				

				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				if (_DoktorID == "-1")
				{
					cmd.CommandText = @"Insert Into Doktor values(@Ad, @Soyad)";
				}
				else
				{
					cmd.CommandText = @"Update Doktor SET 
					Ad=@Ad, Soyad=@Soyad Where DoktorID=@DoktorID";
					cmd.Parameters.Add("@DoktorID", SqlDbType.Int).Value = _DoktorID;
				}
				cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = txtAd.Text;
				cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = txtSoyad.Text;
			

				cmd.ExecuteNonQuery();
				XtraMessageBox.Show("Kaydetme işlemi başarılı");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void frmDoktorDetay_Load(object sender, EventArgs e)
		{
			try
			{
				if (_DoktorID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"Select Ad, Soyad From Doktor Where DoktorID=@DoktorID",
					cs.csBaglanti.BaglantiGetir()))
					{
						cmd.Parameters.Add("@DoktorID", SqlDbType.Int).Value = _DoktorID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								txtAd.Text = dr["Ad"].ToString();
								txtSoyad.Text = dr["Soyad"].ToString();
								
							}
						}
					}
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
	}
}