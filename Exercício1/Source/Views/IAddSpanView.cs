﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace Exercício1.Source.Views
{
    public interface IAddSpanView : IView
    {
        event EventHandler SpanOkClicked;
        string spanText { get; }
    }
}
