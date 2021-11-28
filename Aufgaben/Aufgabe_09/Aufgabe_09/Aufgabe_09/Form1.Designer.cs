
namespace Aufgabe_09
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
            this.tBRomanInput = new System.Windows.Forms.TextBox();
            this.tBArabicInput = new System.Windows.Forms.TextBox();
            this.buttonConvertRtoA = new System.Windows.Forms.Button();
            this.buttonConvertAtoR = new System.Windows.Forms.Button();
            this.labelDisplayArabicToRoman = new System.Windows.Forms.Label();
            this.labelDisplayRomanToArabic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBRomanInput
            // 
            this.tBRomanInput.Location = new System.Drawing.Point(199, 31);
            this.tBRomanInput.Name = "tBRomanInput";
            this.tBRomanInput.Size = new System.Drawing.Size(100, 20);
            this.tBRomanInput.TabIndex = 0;
            // 
            // tBArabicInput
            // 
            this.tBArabicInput.Location = new System.Drawing.Point(199, 73);
            this.tBArabicInput.Name = "tBArabicInput";
            this.tBArabicInput.Size = new System.Drawing.Size(100, 20);
            this.tBArabicInput.TabIndex = 1;
            // 
            // buttonConvertRtoA
            // 
            this.buttonConvertRtoA.Location = new System.Drawing.Point(320, 31);
            this.buttonConvertRtoA.Name = "buttonConvertRtoA";
            this.buttonConvertRtoA.Size = new System.Drawing.Size(203, 23);
            this.buttonConvertRtoA.TabIndex = 2;
            this.buttonConvertRtoA.Text = "Konvertiere römisch nach arabisch";
            this.buttonConvertRtoA.UseVisualStyleBackColor = true;
            this.buttonConvertRtoA.Click += new System.EventHandler(this.buttonConvertRtoA_Click);
            // 
            // buttonConvertAtoR
            // 
            this.buttonConvertAtoR.Location = new System.Drawing.Point(320, 73);
            this.buttonConvertAtoR.Name = "buttonConvertAtoR";
            this.buttonConvertAtoR.Size = new System.Drawing.Size(203, 23);
            this.buttonConvertAtoR.TabIndex = 3;
            this.buttonConvertAtoR.Text = "Konvertiere arabisch nach rörmisch";
            this.buttonConvertAtoR.UseVisualStyleBackColor = true;
            this.buttonConvertAtoR.Click += new System.EventHandler(this.buttonConvertAtoR_Click);
            // 
            // labelDisplayArabicToRoman
            // 
            this.labelDisplayArabicToRoman.AutoSize = true;
            this.labelDisplayArabicToRoman.Location = new System.Drawing.Point(598, 73);
            this.labelDisplayArabicToRoman.Name = "labelDisplayArabicToRoman";
            this.labelDisplayArabicToRoman.Size = new System.Drawing.Size(47, 13);
            this.labelDisplayArabicToRoman.TabIndex = 7;
            this.labelDisplayArabicToRoman.Text = "ROMAN";
            // 
            // labelDisplayRomanToArabic
            // 
            this.labelDisplayRomanToArabic.AutoSize = true;
            this.labelDisplayRomanToArabic.Location = new System.Drawing.Point(598, 36);
            this.labelDisplayRomanToArabic.Name = "labelDisplayRomanToArabic";
            this.labelDisplayRomanToArabic.Size = new System.Drawing.Size(46, 13);
            this.labelDisplayRomanToArabic.TabIndex = 8;
            this.labelDisplayRomanToArabic.Text = "ARABIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eingabe römische Zahl ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Eingabe arabische Zahl ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ergebnis -> ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ergebnis ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 134);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDisplayRomanToArabic);
            this.Controls.Add(this.labelDisplayArabicToRoman);
            this.Controls.Add(this.buttonConvertAtoR);
            this.Controls.Add(this.buttonConvertRtoA);
            this.Controls.Add(this.tBArabicInput);
            this.Controls.Add(this.tBRomanInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBRomanInput;
        private System.Windows.Forms.TextBox tBArabicInput;
        private System.Windows.Forms.Button buttonConvertRtoA;
        private System.Windows.Forms.Button buttonConvertAtoR;
        private System.Windows.Forms.Label labelDisplayArabicToRoman;
        private System.Windows.Forms.Label labelDisplayRomanToArabic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

