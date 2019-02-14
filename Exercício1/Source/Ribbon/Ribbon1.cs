using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using System;
using Exercício1.Presenters;
using Exercício1.Source.Views;
using WinFormsMvp;

namespace Exercício1
{
    public partial class Ribbon1
    {
        static private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            FindPanel myUserControl = new FindPanel();
            myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(myUserControl, "Find and Replace");
            myCustomTaskPane.Width = 320;
            Globals.ThisAddIn.Application.DocumentChange += Application_DocumentChange;
        }

        private void Application_DocumentChange()
        {
            if (Globals.ThisAddIn.Application.Documents.Count != 0)
            {
                var vstoDoc = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
                vstoDoc.SelectionChange += VstoDoc_SelectionChange;
            }
        }

        private void VstoDoc_SelectionChange(object sender, SelectionEventArgs e)
        {
            var selecao = Globals.ThisAddIn.Application.Selection;
            if (selecao.Range.Text != null && selecao.Range.Text != "")
            {
                invertCase.Enabled = true;
                addSpan.Enabled = true;
            }
            else
            {
                invertCase.Enabled = false;
                addSpan.Enabled = false;
            }
        }

        private void btnSave_as_PDF_Click(object sender, RibbonControlEventArgs e)
        {
            SaveAsPDFView spdf = new SaveAsPDFView(); 
        }

        private void AddImage_Click(object sender, RibbonControlEventArgs e)
        {
            AddImage addim = new AddImage();
        }

        private void insTabela_Click(object sender, RibbonControlEventArgs e)
        {
            InserirTabelaView insT = new InserirTabelaView();
            insT.ShowDialog();
        }

        private void invertCase_Click(object sender, RibbonControlEventArgs e)
        {
            InvertCase ivc = new InvertCase();
        }

        private void findReplace_Click(object sender, RibbonControlEventArgs e)
        {
            myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
        }

        private void addSpan_Click(object sender, RibbonControlEventArgs e)
        {
            AddSpan addsp = new AddSpan();
            addsp.ShowDialog();
        }

        private void addField_Click(object sender, RibbonControlEventArgs e)
        {
            AddField addfd = new AddField();
            addfd.ShowDialog();
        }

        private void qualificacaoPJ_Click(object sender, RibbonControlEventArgs e)
        {
            QualificacaoForm addql = new QualificacaoForm();
            addql.ShowDialog();
        }

        private void InsertXML_Click(object sender, RibbonControlEventArgs e)
        {
            //RibbonPresenter.inserirXML(); 
        }
    }
}
