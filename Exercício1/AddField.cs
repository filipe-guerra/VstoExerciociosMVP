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
    public partial class AddField : Form
    {
        public AddField()
        {
            InitializeComponent();
        }

        private void buttonCancelSpan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpanOK_Click(object sender, EventArgs e)
        {
            RibbonPresenter.adicionarExpressao(textBoxExpressao.Text);
        }
    }
}
