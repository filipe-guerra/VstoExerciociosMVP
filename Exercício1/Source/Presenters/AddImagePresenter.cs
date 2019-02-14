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
    public class AddImagePresenter : Presenter<IAddImage>
    {
        private IWordService wordService;

        public AddImagePresenter(IAddImage view) : base(view)
        {
            View.imageAdd += adicionarImagem;
            wordService = WordService.Instance;
        }

        private void adicionarImagem(object sender, EventArgs e)
        {
            string path = View.openDialogAddImage();
            if (path.Length > 0)
            {
                wordService.addImagemService(path);
            }
        }
    }
}
