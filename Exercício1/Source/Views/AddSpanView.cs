using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercício1.Source.Views;
using WinFormsMvp.Forms;
using WinFormsMvp;

namespace Exercício1
{
    public partial class AddSpan : MvpForm, IAddSpanView
    {
        public event EventHandler SpanOkClicked;

        public AddSpan()
        {
            InitializeComponent();
        }
        
        private void buttonSpanOK_Click(object sender, EventArgs e)
        {
            SpanOkClicked(sender, e);
            Close();
        }

        private void buttonCancelSpan_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string spanText
        {
            get
            {
                return this.textBoxSpan.Text;
            }
        }
    }
}
