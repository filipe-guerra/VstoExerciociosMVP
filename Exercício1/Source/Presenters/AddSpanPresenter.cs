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
    public class AddSpanPresenter : Presenter<IAddSpanView>
    {
        private IWordService wordService;

        public AddSpanPresenter(IAddSpanView view) : base(view)
        {
            View.SpanOkClicked += SpanOk_Clicked;
            wordService = WordService.Instance;
        }

        private void SpanOk_Clicked(object sender, EventArgs e) =>
            wordService.addSpanService(View.spanText);
    }
}
