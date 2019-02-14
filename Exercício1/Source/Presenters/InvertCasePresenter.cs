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
    public class InvertCasePresenter : Presenter<IInvertCase>
    {
        private IWordService wordService;

        public InvertCasePresenter(IInvertCase view) : base(view)
        {
            View.evInvert += inverter;
            wordService = WordService.Instance;
        }

        private void inverter(object sender, EventArgs e) =>
            wordService.invertCaseService();
    }
}
