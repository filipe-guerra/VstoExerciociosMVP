using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Exercício1.Source.Services
{
    class WordService : IWordService
    {
        private static readonly Lazy<IWordService> instance =
            new Lazy<IWordService>(() => new WordService());

        public static IWordService Instance
        {
            get { return instance.Value; }
        }

        public void addFieldService(string txt)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            var selecao = doc.Application.Selection;

            selecao.Font.Subscript = 0;
            selecao.TypeText("{" + txt + "}");
        }

        public void addImagemService()
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Netlex\Google Drive\Minhas automatizações\Outros";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                //selecao.Select();
                doc.Select();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    doc.InlineShapes.AddPicture(openFileDialog.FileName);
                }
            }
        }

        public void addSpanService(string txt)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            var selecao = doc.Application.Selection;

            selecao.Font.Subscript = 0;
            selecao.InsertBefore("[");
            selecao.InsertAfter("]");
            doc.Range(doc.Application.Selection.Start + 1, doc.Application.Selection.Start + 1).Select();
            selecao.InsertBefore(txt);
            selecao.Font.Subscript = -1;
            doc.Range(selecao.Start - 1, selecao.Start - 1).Select();
        }

        public void findNextService(string txt, bool caseSens)
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
                if (!selection.Find.Found) { MessageBox.Show("Nenhuma ocorrência encontrada!"); }
            }
        }

        public void replaceAllService(string findtxt, string replacetxt, bool caseSens)
        {
            Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;

            object findText = findtxt;
            selection.Find.ClearFormatting();
            selection.Find.Forward = true;
            selection.Find.MatchCase = caseSens;
            doc.Range(selecao.Start, selecao.Start).Select();
            //selection.Find.Text = txt;

            selection.Find.Execute(ref findText);
            if (selection.Find.Found)
            { selection.TypeText(replacetxt); }

            while (selection.Find.Found)
            {
                selection.Find.Execute(ref findText);
                if (selection.Find.Found) { selection.TypeText(replacetxt); }
            }

            if (!selection.Find.Found)
            {

                doc.Range(0, 0).Select();

                selection.Find.Execute(ref findText);
                if (selection.Find.Found)
                { selection.TypeText(replacetxt); }

                while (selection.Find.Found)
                {
                    selection.Find.Execute(ref findText);
                    if (selection.Find.Found) { selection.TypeText(replacetxt); }
                }
            }
        }

        public void replaceService(string findtxt, string replacetxt, bool caseSens)
        {
            Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;

            object findText = findtxt;
            selection.Find.ClearFormatting();
            selection.Find.Forward = true;
            selection.Find.MatchCase = caseSens;
            doc.Range(selecao.Start, selecao.Start).Select();
            //selection.Find.Text = txt;

            selection.Find.Execute(ref findText);
            if (selection.Find.Found)
            { selection.TypeText(replacetxt); }
            selection.Find.Execute(ref findText);
        }

        public void inserirTabelaService(int lin, int col)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            Word.Range rg = Globals.ThisAddIn.Application.Selection.Range;
            var tab = doc.Tables.Add(rg, lin, col);

            try
            {
                tab.set_Style("Tabela com grade");
            }
            catch (System.Runtime.InteropServices.COMException f)
            {
                tab.set_Style("Table Grid 8");
                Console.WriteLine(f);
            }
        }

        public void invertCaseService()
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            int start = doc.Application.Selection.Start;
            int end = doc.Application.Selection.End;
            Word.Range rg = doc.Range(start, end);
            rg.Select();

            string aux = "";
            foreach (char c in rg.Application.Selection.Text)
            {
                if (c != '\r')
                {
                    if (Char.IsLower(c))
                    {
                        aux += Char.ToUpper(c);
                    }
                    else aux += Char.ToLower(c);
                }
            }
            doc.Application.Selection.TypeText(aux);
            doc.Range(start, end).Select();
        }

        public void savePDFService()
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            try
            {
                doc.ExportAsFixedFormat(fullPathService(), Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
            }
            catch (System.Runtime.InteropServices.COMException f)
            {
                MessageBox.Show("Verifique se seu arquivo está salvo em algum local válido!\n\n" + f.Message);
            }
        }

        public string fullPathService()
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            return sFullpath_pdf;
        }

        public void qualficacaoService(string cPJ, string cPF)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            var selecao = doc.Application.Selection;

            //Qualificacao PJ
            selecao.Font.Subscript = 0;
            selecao.Font.Bold = 1;
            selecao.TypeText(String.Format("{{{0}.RazaoSocial Formatar \"caixaalta\"}},", cPJ));
            selecao.Font.Bold = 0;
            selecao.TypeText(String.Format(" {{{0}.Tipo}}, inscrit[", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Genero = \"masculino\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("o][", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Genero = \"feminino\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("a] no CNPJ sob o n. {{{0}.CNPJ}}, sediad[", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Genero = \"masculino\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("o][", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Genero = \"feminino\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("a] na {{{0}.Logradouro}}, {{{0}.LogradouroNumeroComp}}[", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.LogradouroNumeroComp = \"n.\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format(" ]{{{0}.LogradouroNumero}}, [", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.LogradouroComplemento != \"\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("{{{0}.LogradouroComplemento}}, ]bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{{0}.Estado}}, {{{0}.Pais}}, [", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Pais = \"Brasil\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("CEP][", cPJ));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Pais != \"Brasil\"", cPJ));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("Código Postal]: {{{0}.CEP}}\n", cPJ));

            //Qualificacao PF com repetir
            selecao.Font.Subscript = 0;
            selecao.TypeText("[");
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("repetir numRep pontuacao \"; |; e |.\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.Font.Bold = 1;
            selecao.TypeText(String.Format("{{{0}.Nome Formatar \"caixaalta\"}},", cPF));
            selecao.Font.Bold = 0;
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format(" {{{0}.Nacionalidade}}, {{{0}.EstadoCivil}}, {{{0}.Profissao}}, portador[", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Sexo = \"feminino\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("a] d[", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.IdentidadeTipo = \"Passaporte\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("o][", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.IdentidadeTipo != \"Passaporte\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("a] {{{0}.IdentidadeTipo}} n. {{{0}.IdentidadeNumero}} – {{{0}.IdentidadeOrgaoEmissor Formatar \"caixaalta\"}}, inscrit[", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Sexo = \"masculino\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("o][", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Sexo = \"feminino\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("a] no CPF sob o n. {{{0}.CPF}}, residente e domiciliad[", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Sexo = \"masculino\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("o][", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Sexo = \"feminino\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("a] na {{{0}.Logradouro}}, {{{0}.LogradouroNumeroComp}}[", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.LogradouroNumeroComp = \"n.\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format(" ]{{{0}.LogradouroNumero}}, [", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.LogradouroComplemento != \"\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("{{{0}.LogradouroComplemento}}, ]bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{{0}.Estado}}, {{{0}.Pais}}, [", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Pais = \"Brasil\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("CEP][", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("{0}.Pais != \"Brasil\"", cPF));
            selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("Código Postal]: {{{0}.CEP}}{{sinal}}]", cPF));

            /*selecao.Font.Subscript = 0;
            selecao.TypeText(String.Format("", cPF));
            selecao.Font.Subscript = -1;
            selecao.TypeText(String.Format("", cPF));*/
        }
    }
}
