using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using Exercício1.Source.Views;
using Word = Microsoft.Office.Interop.Word;

namespace Exercício1.Presenters
{
    public class QualificacaoPresenter : Presenter<IQualificacaoPJ>
    {
        public QualificacaoPresenter(IQualificacaoPJ view) : base(view)
        {
            View.btnOkClick += Ok_Clicked;
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            var selecao = doc.Application.Selection;
            string cPJ = View.contatoPJ;
            string cPF = View.contatoPF;

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
