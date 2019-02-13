namespace Exercício1.Source.Views
{
    partial class InserirTabelaView
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.buttonQualOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLinhas = new System.Windows.Forms.ComboBox();
            this.comboBoxColunas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(61, 134);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // buttonQualOK
            // 
            this.buttonQualOK.Location = new System.Drawing.Point(169, 134);
            this.buttonQualOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQualOK.Name = "buttonQualOK";
            this.buttonQualOK.Size = new System.Drawing.Size(100, 28);
            this.buttonQualOK.TabIndex = 10;
            this.buttonQualOK.Text = "OK";
            this.buttonQualOK.UseVisualStyleBackColor = true;
            this.buttonQualOK.Click += new System.EventHandler(this.buttonQualOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Colunas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Linhas";
            // 
            // comboBoxLinhas
            // 
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
            this.comboBoxLinhas.Location = new System.Drawing.Point(148, 39);
            this.comboBoxLinhas.Name = "comboBoxLinhas";
            this.comboBoxLinhas.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLinhas.TabIndex = 12;
            this.comboBoxLinhas.Text = "2";
            // 
            // comboBoxColunas
            // 
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
            this.comboBoxColunas.Location = new System.Drawing.Point(148, 84);
            this.comboBoxColunas.Name = "comboBoxColunas";
            this.comboBoxColunas.Size = new System.Drawing.Size(121, 24);
            this.comboBoxColunas.TabIndex = 13;
            this.comboBoxColunas.Text = "3";
            // 
            // InserirTabelaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.comboBoxColunas);
            this.Controls.Add(this.comboBoxLinhas);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.buttonQualOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InserirTabelaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserirTabelaView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button buttonQualOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLinhas;
        private System.Windows.Forms.ComboBox comboBoxColunas;
    }
}