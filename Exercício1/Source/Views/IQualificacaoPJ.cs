using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace Exercício1.Source.Views
{
    public interface IQualificacaoPJ : IView
    {
        event EventHandler btnOkClick;
        
        string contatoPJ { get; }
        string contatoPF { get; }
    }
}
