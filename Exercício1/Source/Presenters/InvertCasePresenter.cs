using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using Word = Microsoft.Office.Interop.Word;

namespace Exercício1.Presenters
{
    public class InvertCasePresenter : Presenter<IInvertCase>
    {
        public InvertCasePresenter(IInvertCase view) : base(view)
        {
            View.evInvert += inverter;
        }

        private void inverter(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            int start = doc.Application.Selection.Start;
            int end = doc.Application.Selection.End;
            Word.Range rg = doc.Range(start, end);
            rg.Select();

            string aux = "";
            foreach (char c in rg.Application.Selection.Text)
            {
                if (c != '\r')
                {
                    if (Char.IsLower(c))
                    {
                        aux += Char.ToUpper(c);
                    }
                    else aux += Char.ToLower(c);
                }
            }
            doc.Application.Selection.TypeText(aux);
            doc.Range(start, end).Select();
        }
    }
}
