using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1.Source.Services
{
    interface IWordService
    {
        void addFieldService(string txt);
        void addImagemService();
        void addSpanService(string txt);
        void findNextService(string txt, bool caseSens);
        void replaceAllService(string find, string replace, bool caseSens);
        void replaceService(string find, string replace, bool caseSens);
        void inserirTabelaService(int lin, int col);
        void invertCaseService();
        void qualficacaoService(string cPJ, string cPF);
        string fullPathService();
        void savePDFService();
    }
}
