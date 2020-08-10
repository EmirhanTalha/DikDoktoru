using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_DisDoktor.cs
{
	public class csBaglanti
	{
		static SqlConnection baglanti;
		public static SqlConnection BaglantiGetir()
		{
			if (baglanti == null)
				baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);

			if (baglanti.State == ConnectionState.Closed)
				baglanti.Open();

			return baglanti;
		}
	}
}
