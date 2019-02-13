using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp.Forms;

namespace Exercício1.Source.Views
{
    class InvertCase : MvpForm, IInvertCase
    {
        public InvertCase()
        {
            Visible = false;
            evInvert(null, EventArgs.Empty);
            Close();
        }

        public event EventHandler evInvert;
    }
}
