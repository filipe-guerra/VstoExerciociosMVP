using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp.Forms;
using Exercício1.Source.Views;
using System.Windows.Forms;

namespace Exercício1
{
    class AddImage : MvpForm, IAddImage
    {
        public AddImage()
        {
            Visible = false;
            imageAdd(null, EventArgs.Empty);
            Close();
        }

        public event EventHandler imageAdd;

        public string openDialogAddImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Netlex\Google Drive\Minhas automatizações\Outros";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                //selecao.Select();


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else return "";
            }
        }
    }
}
