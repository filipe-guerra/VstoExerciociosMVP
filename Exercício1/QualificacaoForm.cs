using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício1
{
    public partial class QualificacaoForm : Form
    {
        public QualificacaoForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonQualOK_Click(object sender, EventArgs e)
        {
            RibbonPresenter.adicionarQualificacao(textBoxPJ.Text, textBoxPF.Text);
        }
    }
}
