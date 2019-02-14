using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp.Forms;
using Exercício1.Source.Views;

namespace Exercício1
{
    public partial class QualificacaoForm : MvpForm, IQualificacaoPJ
    {
        public QualificacaoForm()
        {
            InitializeComponent();
        }
        
        public string contatoPJ =>  textBoxPJ.Text;
        public string contatoPF => textBoxPF.Text;
        public event EventHandler btnOkClick;

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonQualOK_Click(object sender, EventArgs e)
        {
            btnOkClick(sender, e);
            Close();
        }
    }
}
