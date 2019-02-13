using System;
using WinFormsMvp.Forms;
using Exercício1.Source.Views;

namespace Exercício1
{
    public partial class AddField : MvpForm, IAddFieldView
    {
        string IAddFieldView.returnText => textBoxExpressao.Text;

        public event EventHandler BtnOkClicked;

        public AddField()
        {
            InitializeComponent();
        }

        private void buttonCancelField_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFieldOK_Click(object sender, EventArgs e)
        {
            BtnOkClicked(sender, e);
            Close();
        }
    }

    
}
