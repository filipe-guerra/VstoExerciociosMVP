namespace Exercício1
{
    partial class AddSpan
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
            this.buttonSpanOK = new System.Windows.Forms.Button();
            this.textBoxSpan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSpanOK
            // 
            this.buttonSpanOK.Location = new System.Drawing.Point(164, 107);
            this.buttonSpanOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSpanOK.Name = "buttonSpanOK";
            this.buttonSpanOK.Size = new System.Drawing.Size(100, 28);
            this.buttonSpanOK.TabIndex = 0;
            this.buttonSpanOK.Text = "OK";
            this.buttonSpanOK.UseVisualStyleBackColor = true;
            this.buttonSpanOK.Click += new System.EventHandler(this.buttonSpanOK_Click);
            // 
            // textBoxSpan
            // 
            this.textBoxSpan.Location = new System.Drawing.Point(47, 66);
            this.textBoxSpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSpan.Name = "textBoxSpan";
            this.textBoxSpan.Size = new System.Drawing.Size(216, 22);
            this.textBoxSpan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Span:";
            // 
            // buttonCancelSpan
            // 
            this.buttonCancelSpan.Location = new System.Drawing.Point(47, 107);
            this.buttonCancelSpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSpan.Name = "buttonCancelSpan";
            this.buttonCancelSpan.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSpan.TabIndex = 4;
            this.buttonCancelSpan.Text = "Cancelar";
            this.buttonCancelSpan.UseVisualStyleBackColor = true;
            this.buttonCancelSpan.Click += new System.EventHandler(this.buttonCancelSpan_Click);
            // 
            // AddSpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 180);
            this.Controls.Add(this.buttonCancelSpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpan);
            this.Controls.Add(this.buttonSpanOK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSpan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Span";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpanOK;
        private System.Windows.Forms.TextBox textBoxSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelSpan;
    }
}