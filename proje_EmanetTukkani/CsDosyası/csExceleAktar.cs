using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_EmanetTukkani.CsDosyası
{
	class csExceleAktar
	{
		SaveFileDialog sfdKaydet = new SaveFileDialog();
		public void ExceleAktar(DevExpress.XtraGrid.GridControl _GelenGrid)
		{
			try
			{
				sfdKaydet.Filter = "Excel Files |*.xls";
				if (sfdKaydet.ShowDialog() == DialogResult.OK)
				{
					DevExpress.XtraPrinting.XlsExportOptions a = new DevExpress.XtraPrinting.XlsExportOptions();
					a.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile;
					a.ShowGridLines = true;
					a.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
					a.ExportHyperlinks = true;
					a.Suppress256ColumnsWarning = true;
					a.Suppress65536RowsWarning = true;

					_GelenGrid.ExportToXls(sfdKaydet.FileName, a);

					if (XtraMessageBox.Show("Kaydetme Başarılı.\nKaydedilen Dosya Açılsın mı?", "Erdal Bakkal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
						System.Diagnostics.Process.Start(sfdKaydet.FileName);
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
	}
}
