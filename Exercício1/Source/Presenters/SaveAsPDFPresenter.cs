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
    public class SaveAsPDFPresenter : Presenter<ISaveAsPDF>
    {
        private IWordService wordService;

        public SaveAsPDFPresenter(ISaveAsPDF view) : base(view)
        {
            View.doIt += savePDF;
            wordService = WordService.Instance;
        }

        private void savePDF(object sender, EventArgs e) =>
            wordService.savePDFService();
    }
}
