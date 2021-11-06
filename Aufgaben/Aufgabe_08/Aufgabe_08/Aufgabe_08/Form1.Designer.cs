
namespace Aufgabe_08
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAlphabet = new System.Windows.Forms.ListBox();
            this.labelTrysLeft = new System.Windows.Forms.Label();
            this.labelWort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAlphabet
            // 
            this.listBoxAlphabet.FormattingEnabled = true;
            this.listBoxAlphabet.Location = new System.Drawing.Point(610, 33);
            this.listBoxAlphabet.Name = "listBoxAlphabet";
            this.listBoxAlphabet.Size = new System.Drawing.Size(87, 407);
            this.listBoxAlphabet.TabIndex = 0;
            this.listBoxAlphabet.Click += new System.EventHandler(this.listBoxAlphabet_Click);
            // 
            // labelTrysLeft
            // 
            this.labelTrysLeft.AutoSize = true;
            this.labelTrysLeft.Location = new System.Drawing.Point(180, 221);
            this.labelTrysLeft.Name = "labelTrysLeft";
            this.labelTrysLeft.Size = new System.Drawing.Size(52, 13);
            this.labelTrysLeft.TabIndex = 1;
            this.labelTrysLeft.Text = "Versuche";
            // 
            // labelWort
            // 
            this.labelWort.AutoSize = true;
            this.labelWort.Location = new System.Drawing.Point(36, 49);
            this.labelWort.Name = "labelWort";
            this.labelWort.Size = new System.Drawing.Size(30, 13);
            this.labelWort.TabIndex = 2;
            this.labelWort.Text = "Wort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWort);
            this.Controls.Add(this.labelTrysLeft);
            this.Controls.Add(this.listBoxAlphabet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlphabet;
        private System.Windows.Forms.Label labelTrysLeft;
        private System.Windows.Forms.Label labelWort;
    }
}

