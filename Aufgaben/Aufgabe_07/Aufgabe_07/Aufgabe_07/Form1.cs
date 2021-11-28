using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Aufgabe_07
{
    public partial class Form1 : Form
    {
        private int timeLeft = 120;
        private bool isCatched = false;
        private int hits;
        private int xMax = 1400;
        private int yMax = 700;

        public Form1()
        {
            InitializeComponent();
            timerTimeLeft.Stop();
            timerCatcher.Stop();
        }

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTimeLeft.Text = "Zeit verbleibend: " + timeLeft.ToString() + "s";

            if (timeLeft <= 0)
            {

                GameEnd();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonCatch.Enabled = true;
            timerTimeLeft.Stop();
            timerCatcher.Stop();

            timeLeft = 120;
            hits = 0;

            buttonCatch.Visible = true;

            ResetCatchButton();
            timerTimeLeft.Start();
            timerCatcher.Start();

            labelTimeLeft.Text = "Zeit verbleibend: " + timeLeft.ToString() + " s";
        }

        private void buttonCatch_Click(object sender, EventArgs e)
        {
            if (!isCatched)
            {
                isCatched = true;
                hits++;
                labelHits.Text = "Treffer: " + hits.ToString();
                buttonCatch.BackColor = Color.Red;
                buttonCatch.Text = "Gefangen!";
                if (hits == 10)
                {
                    GameEnd();
                }
            }
        }

        private void GameEnd()
        {
            timerTimeLeft.Stop();
            timerCatcher.Stop();
            string message = "ERROR";
            if (hits >= 10)
            {
                message = "Herzlichen Glückwunsch";
            }
            else if (timeLeft <= 0)
            {
                message = "Herzlichen Glückwunsch";
            }
            MessageBox.Show(message, "Spielende", MessageBoxButtons.OK);
            this.Close();
        }

        private void timerCatcher_Tick(object sender, EventArgs e)
        {
            ResetCatchButton();
        }

        private void ResetCatchButton()
        {
            Random zufall = new Random();

            int xPosition = zufall.Next(0, xMax);
            int yPosition = zufall.Next(0, yMax);

            buttonCatch.Location = new Point(xPosition, yPosition);
            isCatched = false;
            buttonCatch.BackColor = Color.Green;
            buttonCatch.Text = "Catch me if you can!";
        }
    }
}
