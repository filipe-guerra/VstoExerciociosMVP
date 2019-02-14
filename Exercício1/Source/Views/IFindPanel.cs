using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace Exercício1.Source.Views
{
    public interface IFindPanel : IView
    {
        event EventHandler evFindNext;
        event EventHandler evReplace;
        event EventHandler evReplaceAll;
        event EventHandler evfindBox_TextChanged;
        event EventHandler evReplaceBox_TextChanged;

        string findWhatText { get; }
        string replaceText { get; }
        bool caseSensitive { get; }
        bool setButtons { set; }
        bool setReplaceButtons { set; }
        void messageBox(string f);
    }
}
