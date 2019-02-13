using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp.Forms;
using Exercício1.Source.Views;

namespace Exercício1
{
    class SaveAsPDFView : MvpForm, ISaveAsPDF
    {
        public SaveAsPDFView()
        {
            Visible = false;
            doIt(null, EventArgs.Empty);
            Close();
        }
        public event EventHandler doIt;
    }
}
