using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercício1.Source.Views;
using WinFormsMvp.Forms;

namespace Exercício1.Source.Views
{
    public partial class FindPanel : MvpUserControl,  IFindPanel
    {
        public string findWhatText => findBox.Text;
        public string replaceText => replaceBox.Text;
        public bool caseSensitive => checkBoxCase.Checked;

        public bool setButtons {
            set {
                findNext.Enabled = value;
                replace.Enabled = value;
                replaceAll.Enabled = value;
            }
        }

        public bool setReplaceButtons
        {
            set
            {
                replace.Enabled = value;
                replaceAll.Enabled = value;
            }
        }

        public FindPanel()
        {
            InitializeComponent();
        }

        public event EventHandler evFindNext;
        public event EventHandler evReplace;
        public event EventHandler evReplaceAll;
        public event EventHandler evfindBox_TextChanged;
        public event EventHandler evReplaceBox_TextChanged;

        private void findNext_Click(object sender, EventArgs e) => 
            evFindNext(sender, e);

        private void replaceAll_Click(object sender, EventArgs e) => 
            evReplaceAll(sender, e);

        private void replace_Click(object sender, EventArgs e) => 
            evReplace(sender, e);
    }
}
