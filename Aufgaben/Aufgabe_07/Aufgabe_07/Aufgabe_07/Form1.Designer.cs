
namespace Aufgabe_07
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelHits = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.buttonCatch = new System.Windows.Forms.Button();
            this.timerCatcher = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTimeLeft);
            this.groupBox1.Controls.Add(this.labelHits);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 686);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1560, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(146, 20);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(118, 13);
            this.labelTimeLeft.TabIndex = 2;
            this.labelTimeLeft.Text = "Zeit verbleibend : 120 s";
            // 
            // labelHits
            // 
            this.labelHits.AutoSize = true;
            this.labelHits.Location = new System.Drawing.Point(87, 20);
            this.labelHits.Name = "labelHits";
            this.labelHits.Size = new System.Drawing.Size(53, 13);
            this.labelHits.TabIndex = 1;
            this.labelHits.Text = "Treffer : 0";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 15);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Enabled = true;
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // buttonCatch
            // 
            this.buttonCatch.Enabled = false;
            this.buttonCatch.Location = new System.Drawing.Point(335, 524);
            this.buttonCatch.Name = "buttonCatch";
            this.buttonCatch.Size = new System.Drawing.Size(117, 43);
            this.buttonCatch.TabIndex = 1;
            this.buttonCatch.Text = "Fang Mich";
            this.buttonCatch.UseVisualStyleBackColor = true;
            this.buttonCatch.Visible = false;
            this.buttonCatch.Click += new System.EventHandler(this.buttonCatch_Click);
            // 
            // timerCatcher
            // 
            this.timerCatcher.Interval = 1500;
            this.timerCatcher.Tick += new System.EventHandler(this.timerCatcher_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.buttonCatch);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1600, 800);
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelHits;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.Button buttonCatch;
        private System.Windows.Forms.Timer timerCatcher;
    }
}

