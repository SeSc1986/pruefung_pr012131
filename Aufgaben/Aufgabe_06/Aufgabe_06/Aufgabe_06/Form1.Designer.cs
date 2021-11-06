
namespace Aufgabe_06
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
            this.labelLinks = new System.Windows.Forms.Label();
            this.labelRechts = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonChangeTexts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLinks
            // 
            this.labelLinks.AutoSize = true;
            this.labelLinks.Location = new System.Drawing.Point(78, 32);
            this.labelLinks.Name = "labelLinks";
            this.labelLinks.Size = new System.Drawing.Size(54, 13);
            this.labelLinks.TabIndex = 0;
            this.labelLinks.Text = "labelLinks";
            // 
            // labelRechts
            // 
            this.labelRechts.AutoSize = true;
            this.labelRechts.Location = new System.Drawing.Point(282, 32);
            this.labelRechts.Name = "labelRechts";
            this.labelRechts.Size = new System.Drawing.Size(63, 13);
            this.labelRechts.TabIndex = 1;
            this.labelRechts.Text = "labelRechts";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(387, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Schriftgröße groß";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // buttonChangeTexts
            // 
            this.buttonChangeTexts.Location = new System.Drawing.Point(81, 68);
            this.buttonChangeTexts.Name = "buttonChangeTexts";
            this.buttonChangeTexts.Size = new System.Drawing.Size(264, 23);
            this.buttonChangeTexts.TabIndex = 3;
            this.buttonChangeTexts.Text = "Texte tauschen";
            this.buttonChangeTexts.UseVisualStyleBackColor = true;
            this.buttonChangeTexts.Click += new System.EventHandler(this.buttonChangeTexts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 120);
            this.Controls.Add(this.buttonChangeTexts);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelRechts);
            this.Controls.Add(this.labelLinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLinks;
        private System.Windows.Forms.Label labelRechts;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonChangeTexts;
    }
}

