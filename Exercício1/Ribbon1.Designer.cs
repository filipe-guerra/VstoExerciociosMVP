namespace Exercício1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnSave_as_PDF = this.Factory.CreateRibbonButton();
            this.AddImage = this.Factory.CreateRibbonButton();
            this.insTabela = this.Factory.CreateRibbonButton();
            this.invertCase = this.Factory.CreateRibbonButton();
            this.findReplace = this.Factory.CreateRibbonButton();
            this.InsertXML = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.addField = this.Factory.CreateRibbonButton();
            this.addSpan = this.Factory.CreateRibbonButton();
            this.qualificacaoPJ = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSave_as_PDF);
            this.group1.Items.Add(this.AddImage);
            this.group1.Items.Add(this.insTabela);
            this.group1.Items.Add(this.invertCase);
            this.group1.Items.Add(this.findReplace);
            this.group1.Items.Add(this.InsertXML);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // btnSave_as_PDF
            // 
            this.btnSave_as_PDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSave_as_PDF.Label = "Save as PDF";
            this.btnSave_as_PDF.Name = "btnSave_as_PDF";
            this.btnSave_as_PDF.OfficeImageId = "FileSaveAsPdfOrXps";
            this.btnSave_as_PDF.ShowImage = true;
            this.btnSave_as_PDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSave_as_PDF_Click);
            // 
            // AddImage
            // 
            this.AddImage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AddImage.Label = "Add Image";
            this.AddImage.Name = "AddImage";
            this.AddImage.OfficeImageId = "PictureInsertFromFile";
            this.AddImage.ShowImage = true;
            this.AddImage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddImage_Click);
            // 
            // insTabela
            // 
            this.insTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.insTabela.Label = "Inserir Tabela";
            this.insTabela.Name = "insTabela";
            this.insTabela.OfficeImageId = "TableInsertDialogWord";
            this.insTabela.ShowImage = true;
            this.insTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insTabela_Click);
            // 
            // invertCase
            // 
            this.invertCase.Enabled = false;
            this.invertCase.Label = "Inverter Case";
            this.invertCase.Name = "invertCase";
            this.invertCase.OfficeImageId = "ChangeCase";
            this.invertCase.ShowImage = true;
            this.invertCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.invertCase_Click);
            // 
            // findReplace
            // 
            this.findReplace.Label = "Find and Replace";
            this.findReplace.Name = "findReplace";
            this.findReplace.OfficeImageId = "FindDialog";
            this.findReplace.ShowImage = true;
            this.findReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.findReplace_Click);
            // 
            // InsertXML
            // 
            this.InsertXML.Label = "Insert XML";
            this.InsertXML.Name = "InsertXML";
            this.InsertXML.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InsertXML_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.addField);
            this.group2.Items.Add(this.addSpan);
            this.group2.Items.Add(this.qualificacaoPJ);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // addField
            // 
            this.addField.Label = "Add Field";
            this.addField.Name = "addField";
            this.addField.OfficeImageId = "KeepBackgroundRemoval";
            this.addField.ShowImage = true;
            this.addField.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.addField_Click);
            // 
            // addSpan
            // 
            this.addSpan.Enabled = false;
            this.addSpan.Label = "Add Span";
            this.addSpan.Name = "addSpan";
            this.addSpan.OfficeImageId = "KeepBackgroundRemoval";
            this.addSpan.ShowImage = true;
            this.addSpan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.addSpan_Click);
            // 
            // qualificacaoPJ
            // 
            this.qualificacaoPJ.Label = "Qualificação PJ";
            this.qualificacaoPJ.Name = "qualificacaoPJ";
            this.qualificacaoPJ.OfficeImageId = "KeepBackgroundRemoval";
            this.qualificacaoPJ.ShowImage = true;
            this.qualificacaoPJ.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.qualificacaoPJ_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSave_as_PDF;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddImage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insTabela;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton invertCase;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton findReplace;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton addField;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton addSpan;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton qualificacaoPJ;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InsertXML;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
