using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_08
{
    public partial class Form1 : Form
    {

        Hangman hangman;

        public Form1()
        {
            InitializeComponent();
            InitHangman();
        }

        private void InitHangman()
        {
            hangman = new Hangman();

            RefreshDisplayedTexts();


            listBoxAlphabet.Items.Clear();

            foreach (char letter in Hangman.GermanAlphabet)
            {
                listBoxAlphabet.Items.Add(letter);
            }
        }

        private void RefreshDisplayedTexts()
        {
            labelTrysLeft.Text = "Sie haben noch " + hangman.VersucheUebrig + " Versuche übrig";
            labelWort.Text = hangman.DisplayWort();
        }

        private void listBoxAlphabet_Click(object sender, EventArgs e)
        {
            if (listBoxAlphabet.SelectedItem != null)
            {
                char ausgwählterBuchstabe = (char)listBoxAlphabet.SelectedItem;
                bool erfolg = false;

                foreach (char letter in hangman.WortAsCharraray)
                {
                    if (ausgwählterBuchstabe == letter)
                    {
                        hangman.BuchstabeIstErraten.Remove(letter);
                        hangman.BuchstabeIstErraten.Add(letter, true);
                        erfolg = true;
                        break;
                    }
                }

                if (!erfolg)
                {
                    hangman.VersucheUebrig--;
                }

                if (hangman.Sieg())
                {
                    MessageBox.Show("SIEG!");
                    NeuesSpiel();
                }
                else if (hangman.VersucheUebrig == 0)
                {
                    MessageBox.Show("Verloren!");
                    NeuesSpiel();
                }
                else
                {
                    listBoxAlphabet.Items.RemoveAt(listBoxAlphabet.SelectedIndex);
                    RefreshDisplayedTexts();
                }
            }
        }

        private void NeuesSpiel()
        {
            DialogResult dr = MessageBox.Show("Neues Spiel Starten?", "Neues Spiel", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                InitHangman();
            }
            else
            {
                this.Close();
            }


        }

    }
}
