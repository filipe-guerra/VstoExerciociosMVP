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
    public class InserirTabelaPresenter : Presenter<IInserirTabela>
    {
        public InserirTabelaPresenter(IInserirTabela view) : base(view)
        {
            View.okClicked += insTabela;
        }

        private void insTabela(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            Word.Range rg = Globals.ThisAddIn.Application.Selection.Range;
            var tab = doc.Tables.Add(rg, View.linhas, View.colunas);

            try
            {
                tab.set_Style("Tabela com grade");
            }
            catch (System.Runtime.InteropServices.COMException f)
            {
                tab.set_Style("Table Grid 8");
                Console.WriteLine(f);
            }
        }
    }
}
