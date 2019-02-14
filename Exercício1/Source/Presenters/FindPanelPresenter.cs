using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using System.Windows.Forms;
using Exercício1.Source.Services;

namespace Exercício1.Presenters
{
    public class FindPanelPresenter : Presenter<IFindPanel>
    {
        private IWordService wordService;

        public FindPanelPresenter(IFindPanel view) : base(view)
        {
            View.evFindNext += findNext;
            View.evReplace += replace;
            View.evReplaceAll += replaceAll;
            View.evfindBox_TextChanged += findBox_TextChanged;
            View.evReplaceBox_TextChanged += replaceBox_TextChanged;
            wordService = WordService.Instance;
        }

        public void findNext(object sender, EventArgs e) => 
            wordService.findNextService(View.findWhatText, View.caseSensitive);

        public void replaceAll(object sender, EventArgs e) => 
            wordService.replaceAllService(View.findWhatText, View.replaceText, View.caseSensitive);

        public void replace(object sender, EventArgs e) => 
            wordService.replaceService(View.findWhatText, View.replaceText, View.caseSensitive);

        private void findBox_TextChanged(object sender, EventArgs e)
        {
            if (View.findWhatText.Length < 1)
            {
                View.setButtons = false;
            }
            else
            {
                View.setButtons = true;
            }
        }

        private void replaceBox_TextChanged(object sender, EventArgs e)
        {
            if (View.replaceText.Length < 1)
            {
                View.setReplaceButtons = false;
            }
            else
            {
                View.setReplaceButtons = true;
            }
        }

    }
}
