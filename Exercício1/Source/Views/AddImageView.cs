using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp.Forms;
using Exercício1.Source.Views;

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
    }
}
