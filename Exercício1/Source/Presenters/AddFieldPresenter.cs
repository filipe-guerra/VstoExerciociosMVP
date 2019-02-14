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
    public class AddFieldPresenter : Presenter<IAddFieldView>
    {
        private IWordService wordService;

        public AddFieldPresenter(IAddFieldView view) : base(view)
        {
            View.BtnOkClicked += Ok_Clicked;
            wordService = WordService.Instance;
        }

        private void Ok_Clicked(object sender, EventArgs e) =>
            wordService.addFieldService(View.returnText);
    }
}
