namespace Exercício1
{
    partial class FindPanelPresenter
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.findBox = new System.Windows.Forms.TextBox();
            this.findNext = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.replaceAll = new System.Windows.Forms.Button();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // findBox
            // 
            this.findBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.findBox.Location = new System.Drawing.Point(37, 63);
            this.findBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(228, 22);
            this.findBox.TabIndex = 0;
            this.findBox.Text = "Find what";
            this.findBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // findNext
            // 
            this.findNext.Location = new System.Drawing.Point(37, 95);
            this.findNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findNext.Name = "findNext";
            this.findNext.Size = new System.Drawing.Size(100, 28);
            this.findNext.TabIndex = 1;
            this.findNext.Text = "Find Next";
            this.findNext.UseVisualStyleBackColor = true;
            this.findNext.Click += new System.EventHandler(this.findNext_Click);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(37, 176);
            this.replace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(100, 28);
            this.replace.TabIndex = 2;
            this.replace.Text = "Replace";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // replaceAll
            // 
            this.replaceAll.Location = new System.Drawing.Point(167, 176);
            this.replaceAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replaceAll.Name = "replaceAll";
            this.replaceAll.Size = new System.Drawing.Size(100, 28);
            this.replaceAll.TabIndex = 3;
            this.replaceAll.Text = "Replace All";
            this.replaceAll.UseVisualStyleBackColor = true;
            this.replaceAll.Click += new System.EventHandler(this.replaceAll_Click);
            // 
            // replaceBox
            // 
            this.replaceBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.replaceBox.Location = new System.Drawing.Point(37, 144);
            this.replaceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(228, 22);
            this.replaceBox.TabIndex = 4;
            this.replaceBox.Text = "Replace";
            this.replaceBox.TextChanged += new System.EventHandler(this.replaceBox_TextChanged);
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(160, 100);
            this.checkBoxCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(121, 21);
            this.checkBoxCase.TabIndex = 5;
            this.checkBoxCase.Text = "Case sensitive";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // FindPanelPresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCase);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.replaceAll);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.findNext);
            this.Controls.Add(this.findBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FindPanelPresenter";
            this.Size = new System.Drawing.Size(311, 468);
            this.Load += new System.EventHandler(this.MyUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Button findNext;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button replaceAll;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.CheckBox checkBoxCase;
    }
}
