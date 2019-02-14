using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using Exercício1.Source.Services;

namespace Exercício1.Presenters
{
    public class QualificacaoPresenter : Presenter<IQualificacaoPJ>
    {
        private IWordService wordService;

        public QualificacaoPresenter(IQualificacaoPJ view) : base(view)
        {
            View.btnOkClick += Ok_Clicked;
            wordService = WordService.Instance;
        }

        private void Ok_Clicked(object sender, EventArgs e) =>
            wordService.qualficacaoService(View.contatoPJ, View.contatoPF);
    }
}
