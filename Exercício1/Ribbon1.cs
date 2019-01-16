using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using System;

namespace Exercício1
{
    public partial class Ribbon1
    {
        private FindPanelPresenter myUserControl;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            myUserControl = new FindPanelPresenter();
            myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(myUserControl, "Find and Replace");
            myCustomTaskPane.Visible = false;
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
            RibbonPresenter.savePDF();
        }

        private void AddImage_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.addImage();
        }

        private void insTabela_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.inserirTabela();
        }

        private void invertCase_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.invertCase();
        }

        private void findReplace_Click(object sender, RibbonControlEventArgs e)
        {
            myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
        }

        private void addSpan_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.criarSpanForm();
        }

        private void addField_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.criarFieldForm();
        }

        private void qualificacaoPJ_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.criarQualificacaoForm();
        }

        private void InsertXML_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.inserirXML(); 
        }
    }
}
