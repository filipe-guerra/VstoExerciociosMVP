using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using Word = Microsoft.Office.Interop.Word;
using Exercício1.Source.Services;

namespace Exercício1.Presenters
{
    public class InserirTabelaPresenter : Presenter<IInserirTabela>
    {
        private IWordService wordService;

        public InserirTabelaPresenter(IInserirTabela view) : base(view)
        {
            View.okClicked += insTabela;
            wordService = WordService.Instance;
        }

        private void insTabela(object sender, EventArgs e) =>
            wordService.inserirTabelaService(View.linhas, View.colunas);
    }
}
