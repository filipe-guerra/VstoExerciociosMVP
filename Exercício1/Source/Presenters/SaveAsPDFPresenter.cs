using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Exercício1.Presenters
{
    public class SaveAsPDFPresenter : Presenter<ISaveAsPDF>
    {
        public SaveAsPDFPresenter(ISaveAsPDF view) : base(view)
        {
            View.doIt += savePDF;
        }

        private void savePDF(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            try
            {
                doc.ExportAsFixedFormat(fullPath(), Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
            }
            catch (System.Runtime.InteropServices.COMException f)
            {
                MessageBox.Show("Verifique se seu arquivo está salvo em algum local válido!\n\n" + f.Message);
            }
        }

        private static string fullPath()
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            return sFullpath_pdf;
        }
    }
}
