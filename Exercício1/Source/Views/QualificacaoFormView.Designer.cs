namespace Exercício1
{
    partial class QualificacaoForm
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
            this.textBoxPJ = new System.Windows.Forms.TextBox();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQualOK = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPJ
            // 
            this.textBoxPJ.Location = new System.Drawing.Point(60, 78);
            this.textBoxPJ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPJ.Name = "textBoxPJ";
            this.textBoxPJ.Size = new System.Drawing.Size(205, 22);
            this.textBoxPJ.TabIndex = 0;
            this.textBoxPJ.Text = "contatoPJ";
            // 
            // textBoxPF
            // 
            this.textBoxPF.Location = new System.Drawing.Point(60, 145);
            this.textBoxPF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(205, 22);
            this.textBoxPF.TabIndex = 1;
            this.textBoxPF.Text = "contatoPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Contato PJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Contato PF";
            // 
            // buttonQualOK
            // 
            this.buttonQualOK.Location = new System.Drawing.Point(167, 197);
            this.buttonQualOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQualOK.Name = "buttonQualOK";
            this.buttonQualOK.Size = new System.Drawing.Size(100, 28);
            this.buttonQualOK.TabIndex = 4;
            this.buttonQualOK.Text = "OK";
            this.buttonQualOK.UseVisualStyleBackColor = true;
            this.buttonQualOK.Click += new System.EventHandler(this.buttonQualOK_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(59, 197);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // QualificacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 272);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.buttonQualOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPF);
            this.Controls.Add(this.textBoxPJ);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QualificacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qualificação com Representante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPJ;
        private System.Windows.Forms.TextBox textBoxPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQualOK;
        private System.Windows.Forms.Button cancelBtn;
    }
}