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
	public partial class frmHastaDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmHastaDetay(string HastaID)
		{
			InitializeComponent();
			_HastaID = HastaID;
		}
		string _HastaID = "-1";
		private void frmHastaDetay_Load(object sender, EventArgs e)
		{
			try
			{
				if (_HastaID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"Select Ad, Soyad, TCKimlikNo From Hasta Where HastaID=@HastaID",
					cs.csBaglanti.BaglantiGetir()))
					{
						cmd.Parameters.Add("@HastaID", SqlDbType.Int).Value = _HastaID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								txtAd.Text = dr["Ad"].ToString();
								txtSoyad.Text = dr["Soyad"].ToString();
								txtTCKimlikNo.Text = dr["TCKimlikNo"].ToString();

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
				if (String.IsNullOrWhiteSpace(txtTCKimlikNo.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtTCKimlikNo.Focus();
					return;
				}


				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				if (_HastaID == "-1")
				{
					cmd.CommandText = @"Insert Into Hasta values(@Ad, @Soyad, @TCKimlikNo)";
				}
				else
				{
					cmd.CommandText = @"Update Hasta SET 
					Ad=@Ad, Soyad=@Soyad,TCKimlikNo=@TCKimlikNo Where HastaID=@HastaID";
					cmd.Parameters.Add("@HastaID", SqlDbType.Int).Value = _HastaID;
				}
				cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = txtAd.Text;
				cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = txtSoyad.Text;
				cmd.Parameters.Add("@TCKimlikNo", SqlDbType.NVarChar).Value = txtTCKimlikNo.Text;

				cmd.ExecuteNonQuery();
				XtraMessageBox.Show("Kaydetme işlemi başarılı");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}