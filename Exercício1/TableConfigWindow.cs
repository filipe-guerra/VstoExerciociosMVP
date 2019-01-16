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
    public partial class TableConfigWindow : Form
    {

        public System.Windows.Forms.ComboBox.ObjectCollection Items { get; }

        public TableConfigWindow()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            RibbonPresenter.criarTabela(comboBoxLinhas.Text, comboBoxColunas.Text, this);
        }

        private void TableConfigWindow_Load(object sender, EventArgs e)
        {
            this.comboBoxLinhas.SelectedText = null;
            this.comboBoxLinhas.SelectedText = "3";

            this.comboBoxColunas.SelectedText = null;
            this.comboBoxColunas.SelectedText = "2";
        }
    }
}
