using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Exercício1.Presenters
{
    public class AddImagePresenter : Presenter<IAddImage>
    {
        public AddImagePresenter(IAddImage view) : base(view)
        {
            View.imageAdd += adicionarImagem;
        }

        private void adicionarImagem(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Netlex\Google Drive\Minhas automatizações\Outros";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                //selecao.Select();
                doc.Select();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    doc.InlineShapes.AddPicture(openFileDialog.FileName);
                }
            }
        }
    }
}
