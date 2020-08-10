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
	public partial class frmIslemDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmIslemDetay(string IslemID)
		{
			InitializeComponent();
			_IslemID = IslemID;
		}
		string _IslemID = "-1";
		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				decimal ucret = 0;

				if (String.IsNullOrWhiteSpace(txtIslemTanim.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtIslemTanim.Focus();
					return;
				}
				if (decimal.TryParse(txtUcret.Text, out ucret) ==false)
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtUcret.Focus();
					return;
				}
				

				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				if (_IslemID == "-1")
				{
					cmd.CommandText = @"Insert Into Islem values(@IslemTanim, @Ucret)";
				}
				else
				{
					cmd.CommandText = @"Update Islem SET 
					IslemTanim=@IslemTanim, Ucret=@Ucret Where IslemID=@IslemID";
					cmd.Parameters.Add("@IslemID", SqlDbType.Int).Value = _IslemID;
				}
				cmd.Parameters.Add("@IslemTanim", SqlDbType.NVarChar).Value = txtIslemTanim.Text;
				cmd.Parameters.Add("@Ucret", SqlDbType.Decimal).Value = ucret;
			

				cmd.ExecuteNonQuery();
				XtraMessageBox.Show("Kaydetme işlemi başarılı");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void frmIslemDetay_Load(object sender, EventArgs e)
		{
			try
			{
				if (_IslemID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"Select IslemTanim, Ucret From Islem Where IslemID=@IslemID",
					cs.csBaglanti.BaglantiGetir()))
					{
						cmd.Parameters.Add("@IslemID", SqlDbType.Int).Value = _IslemID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								txtIslemTanim.Text = dr["IslemTanim"].ToString();
								txtUcret.Text = dr["Ucret"].ToString();								
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