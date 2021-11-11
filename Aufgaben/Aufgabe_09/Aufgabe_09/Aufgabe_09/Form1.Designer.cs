
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
            this.labelDisplayRomanToArabic = new System.Windows.Forms.Label();
            this.labelDisplayArabicToRoman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBRomanInput
            // 
            this.tBRomanInput.Location = new System.Drawing.Point(47, 30);
            this.tBRomanInput.Name = "tBRomanInput";
            this.tBRomanInput.Size = new System.Drawing.Size(100, 20);
            this.tBRomanInput.TabIndex = 0;
            // 
            // tBArabicInput
            // 
            this.tBArabicInput.Location = new System.Drawing.Point(47, 72);
            this.tBArabicInput.Name = "tBArabicInput";
            this.tBArabicInput.Size = new System.Drawing.Size(100, 20);
            this.tBArabicInput.TabIndex = 1;
            // 
            // buttonConvertRtoA
            // 
            this.buttonConvertRtoA.Location = new System.Drawing.Point(168, 27);
            this.buttonConvertRtoA.Name = "buttonConvertRtoA";
            this.buttonConvertRtoA.Size = new System.Drawing.Size(123, 23);
            this.buttonConvertRtoA.TabIndex = 2;
            this.buttonConvertRtoA.Text = "buttonConvertRtoA";
            this.buttonConvertRtoA.UseVisualStyleBackColor = true;
            this.buttonConvertRtoA.Click += new System.EventHandler(this.buttonConvertRtoA_Click);
            // 
            // buttonConvertAtoR
            // 
            this.buttonConvertAtoR.Location = new System.Drawing.Point(168, 72);
            this.buttonConvertAtoR.Name = "buttonConvertAtoR";
            this.buttonConvertAtoR.Size = new System.Drawing.Size(123, 23);
            this.buttonConvertAtoR.TabIndex = 3;
            this.buttonConvertAtoR.Text = "buttonConvertAtoR";
            this.buttonConvertAtoR.UseVisualStyleBackColor = true;
            this.buttonConvertAtoR.Click += new System.EventHandler(this.buttonConvertAtoR_Click);
            // 
            // labelDisplayRomanToArabic
            // 
            this.labelDisplayRomanToArabic.AutoSize = true;
            this.labelDisplayRomanToArabic.Location = new System.Drawing.Point(397, 28);
            this.labelDisplayRomanToArabic.Name = "labelDisplayRomanToArabic";
            this.labelDisplayRomanToArabic.Size = new System.Drawing.Size(0, 13);
            this.labelDisplayRomanToArabic.TabIndex = 5;
            // 
            // labelDisplayArabicToRoman
            // 
            this.labelDisplayArabicToRoman.AutoSize = true;
            this.labelDisplayArabicToRoman.Location = new System.Drawing.Point(297, 75);
            this.labelDisplayArabicToRoman.Name = "labelDisplayArabicToRoman";
            this.labelDisplayArabicToRoman.Size = new System.Drawing.Size(47, 13);
            this.labelDisplayArabicToRoman.TabIndex = 7;
            this.labelDisplayArabicToRoman.Text = "ROMAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 125);
            this.Controls.Add(this.labelDisplayArabicToRoman);
            this.Controls.Add(this.labelDisplayRomanToArabic);
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
        private System.Windows.Forms.Label labelDisplayRomanToArabic;
        private System.Windows.Forms.Label labelDisplayArabicToRoman;
    }
}

