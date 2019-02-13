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

namespace Exercício1.Source.Views
{
    public partial class InserirTabelaView : MvpForm, IInserirTabela
    {
        public int linhas => Int32.Parse(comboBoxLinhas.Text);
        public int colunas => Int32.Parse(comboBoxColunas.Text);

        public InserirTabelaView()
        {
            InitializeComponent();
        }

        public event EventHandler okClicked;

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonQualOK_Click(object sender, EventArgs e)
        {
            okClicked(sender, e);
            Close();
        }
    }
}
