using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Exercício1
{
    class FindPanel
    {
        public static void findNext(string txt, bool caseSens)
        {
            Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;


            object findText = txt;
            selection.Find.ClearFormatting();
            selection.Find.Forward = true;
            selection.Find.MatchCase = caseSens;
            selection.Find.Execute(ref findText);

            if (!selection.Find.Found)
            {
                doc.Range(0, 0).Select();
                selection.Find.Execute(ref findText);
                if (!selection.Find.Found) { MessageBox.Show("Nenhuma ocorrência encontrada!");}
            }

         }

        public static void replaceAll(string txt, string rpl, bool caseSens)
        {
            Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;

            object findText = txt;
            selection.Find.ClearFormatting();
            selection.Find.Forward = true;
            selection.Find.MatchCase = caseSens;
            doc.Range(selecao.Start, selecao.Start).Select();
            //selection.Find.Text = txt;

            selection.Find.Execute(ref findText);
            if (selection.Find.Found)
            { selection.TypeText(rpl); }

            while (selection.Find.Found)
            {
                selection.Find.Execute(ref findText);
                if (selection.Find.Found) { selection.TypeText(rpl); }
            }

            if (!selection.Find.Found)
            {
                
                doc.Range(0, 0).Select();

                selection.Find.Execute(ref findText);
                if (selection.Find.Found)
                    { selection.TypeText(rpl); }

                while (selection.Find.Found)
                {
                    selection.Find.Execute(ref findText);
                    if (selection.Find.Found) { selection.TypeText(rpl); }
                }
            }
            
        }

        public static void replace(string txt, string rpl, bool caseSens)
        {
            Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;

            object findText = txt;
            selection.Find.ClearFormatting();
            selection.Find.Forward = true;
            selection.Find.MatchCase = caseSens;
            doc.Range(selecao.Start, selecao.Start).Select();
            //selection.Find.Text = txt;

            selection.Find.Execute(ref findText);
            if (selection.Find.Found)
            { selection.TypeText(rpl); }
            selection.Find.Execute(ref findText);
        }
    }
}
