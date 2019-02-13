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
    public class AddSpanPresenter : Presenter<IAddSpanView>
    {
        public AddSpanPresenter(IAddSpanView view) : base(view)
        {
            View.SpanOkClicked += SpanOk_Clicked;
        }

        private void SpanOk_Clicked(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            var selecao = doc.Application.Selection;

            selecao.Font.Subscript = 0;
            selecao.InsertBefore("[");
            selecao.InsertAfter("]");
            doc.Range(doc.Application.Selection.Start + 1, doc.Application.Selection.Start + 1).Select();
            selecao.InsertBefore(View.spanText);
            selecao.Font.Subscript = -1;
            doc.Range(selecao.Start - 1, selecao.Start - 1).Select();
        }
    }
}
