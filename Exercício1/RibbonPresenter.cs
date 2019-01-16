using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using System;

namespace Exercício1
{
    class RibbonPresenter
    {
        static private Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
        static private Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
        static private AddSpan span;
        static private AddField addField;
        static private QualificacaoForm qualForm;

        private static string fullPath()
        {
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            return sFullpath_pdf;
        }

        public static void savePDF()
        {
            try {
                doc.ExportAsFixedFormat(fullPath(), Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
                }
            catch (System.Runtime.InteropServices.COMException e)
            {
                MessageBox.Show("Verifique se seu arquivo está salvo em algum local válido!\n\n" + e.Message);
            }
        }

        public static void addImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Netlex\Google Drive\Minhas automatizações\Outros";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                selecao.Select();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selecao.InlineShapes.AddPicture(openFileDialog.FileName);
                }
            }
        }

        public static void inserirTabela()
        {
            TableConfigWindow tableconf = new TableConfigWindow();
            tableconf.Show();
        }

        public static void criarTabela(string ln, string cl, TableConfigWindow tableconf)
        {
            int linha, coluna;
            Int32.TryParse(ln, out linha);
            Int32.TryParse(cl, out coluna);
            
            Word.Range rg = Globals.ThisAddIn.Application.Selection.Range;
            var tab = doc.Tables.Add(rg, linha, coluna);

            try
            {
                tab.set_Style("Tabela com grade");
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                tab.set_Style("Table Grid 8");
                Console.WriteLine(e);
            }

            tableconf.Close();
        }

        public static void invertCase()
        {
            int start = doc.Application.Selection.Start;
            int end = doc.Application.Selection.End;
            //Word.Range rg = doc.Range(start, end);
            selecao.Select();
            string aux ="";
            foreach (char c in selecao.Text)
            {
                if (Char.IsLetter(c))
                {
                    if (Char.IsLower(c))
                    {
                        aux = aux + Char.ToUpper(c);
                    }
                    else aux = aux + Char.ToLower(c);
                    
                }
                else aux = aux + c;
            }
            selecao.TypeText(aux);
            doc.Range(start, end).Select();
        }

        public static void criarSpanForm()
        {
            span = new AddSpan();
            span.Show();
        }

        private static void fecharSpan() { span.Close(); }

        public static void adicionarSpan(string span)
        {
            selecao.Font.Subscript = 0;
            selecao.InsertBefore("[");
            selecao.InsertAfter("]");
            doc.Range(doc.Application.Selection.Start + 1, doc.Application.Selection.Start + 1).Select();
            selecao.InsertBefore(span);
            selecao.Font.Subscript = -1;
            doc.Range(selecao.Start - 1, selecao.Start - 1).Select();
            fecharSpan();
        }

        public static void criarFieldForm()
        {
            addField = new AddField();
            addField.Show();
        }
        private static void fecharAddField() { addField.Close(); }

        public static void adicionarExpressao(string exp)
        {
            selecao.Font.Subscript = 0;
            selecao.TypeText("{" + exp + "}");
            fecharAddField();
        }

        public static void criarQualificacaoForm()
        {
            qualForm = new QualificacaoForm();
            qualForm.Show();
        }
        private static void fecharQualForm() { qualForm.Close(); }

        public static void adicionarQualificacao(string cPJ, string cPF)
        {
            fecharQualForm();

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

        public static void inserirXML()
        {
            string xmlString = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                                "<employees xmlns=\"http://schemas.microsoft.com/vsto/samples\">" +
                                    "<employee>" +
                                        "<name>Karina Leal</name>" +
                                        "<hireDate>1999-04-01</hireDate>" +
                                        "<title>Manager</title>" +
                                    "</employee>" +
                                "</employees>";

            doc.Range().InsertXML(xmlString);
        }
    }
}
