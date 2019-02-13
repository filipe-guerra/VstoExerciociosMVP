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
    public class AddFieldPresenter : Presenter<IAddFieldView>
    {
        public AddFieldPresenter(IAddFieldView view) : base(view)
        {
            View.BtnOkClicked += Ok_Clicked;
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            var selecao = doc.Application.Selection;

            selecao.Font.Subscript = 0;
            selecao.TypeText("{" + View.returnText + "}");
        }
    }
}
