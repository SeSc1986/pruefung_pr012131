using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_08
{
    class Hangman
    {
        //geklaut von https://www.pax-an.org/2016/05/super-galgenmannchen-worter.html
        private string[] woerter = { "Heizölrückstoßabdämpfung", "Donaudampfschifffahrtskapitänsgeselltschaftsmützenhalterung",
            "Typ", "Lokomotivdampfkesseldruckventilverschlussklappe", "Kirschkernweitspuckwettbewerb",
            "Recycling", "Weihnachtsmannschokoladeneinpackpapier", "Atmosphäre", "Destinationslebenszyklusmodell", "Zyklop" ,
            "Zyklon", "Gymnastik", "Rhythmus", "Desoxyribonukleinsäure", "Metapher ", "Universalindikatorpapierschnipselchen", "Arbeitsunfähigkeitsbescheinigung ",
            "Hundehaftpflichtversicherung" };

        // geklaut von https://stackoverflow.com/questions/314466/generating-an-array-of-letters-in-the-alphabet
        private static readonly char[] germanAlphabet = "abcdefghijklmnopqrstuvwxyzäöüß".ToCharArray();

        public string Wort { get; set; }

        public static char[] GermanAlphabet => germanAlphabet;

        public int VersucheUebrig { get; set; }
        public char[] WortAsCharraray { get; set; }
        public Dictionary<char, bool> BuchstabeIstErraten { get; set; }

        public Hangman()
        {
            VersucheUebrig = 10;
            BuchstabeIstErraten = new Dictionary<char, bool> { };
            foreach (char letter in germanAlphabet)
            {
                BuchstabeIstErraten.Add(letter, false);
            }

            Wort = Zufallswort();
            WortAsCharraray = Wort.ToCharArray();
        }

        private string Zufallswort()
        {
            Random zufall = new Random(DateTime.Now.Millisecond);
            int maxInt = woerter.Length;
            int zufallszahl = zufall.Next(maxInt);

            return woerter[zufallszahl];
        }

        public string DisplayWort()
        {
            StringBuilder sb = new StringBuilder();

            foreach (char letter in WortAsCharraray)
            {
                if (BuchstabeIstErraten[letter.ToString().ToLower()[0]])
                {
                    sb.Append(letter);
                }
                else
                {
                    sb.Append("*");
                }
            }

            return sb.ToString();
        }

        public bool Sieg()
        {
            bool result = true;

            foreach (char letter in WortAsCharraray)
            {
                if (!BuchstabeIstErraten[letter.ToString().ToLower()[0]])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
