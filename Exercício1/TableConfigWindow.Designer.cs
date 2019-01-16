namespace Exercício1
{
    partial class TableConfigWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLinhas = new System.Windows.Forms.ComboBox();
            this.comboBoxColunas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLinhas
            // 
            this.comboBoxLinhas.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxLinhas.FormatString = "N0";
            this.comboBoxLinhas.FormattingEnabled = true;
            this.comboBoxLinhas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxLinhas.Location = new System.Drawing.Point(140, 46);
            this.comboBoxLinhas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLinhas.Name = "comboBoxLinhas";
            this.comboBoxLinhas.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLinhas.TabIndex = 0;
            // 
            // comboBoxColunas
            // 
            this.comboBoxColunas.FormatString = "N0";
            this.comboBoxColunas.FormattingEnabled = true;
            this.comboBoxColunas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxColunas.Location = new System.Drawing.Point(140, 105);
            this.comboBoxColunas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxColunas.Name = "comboBoxColunas";
            this.comboBoxColunas.Size = new System.Drawing.Size(160, 24);
            this.comboBoxColunas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linhas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colunas";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(201, 170);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // TableConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 239);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColunas);
            this.Controls.Add(this.comboBoxLinhas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TableConfigWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Tabela";
            this.Load += new System.EventHandler(this.TableConfigWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLinhas;
        private System.Windows.Forms.ComboBox comboBoxColunas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
    }
}