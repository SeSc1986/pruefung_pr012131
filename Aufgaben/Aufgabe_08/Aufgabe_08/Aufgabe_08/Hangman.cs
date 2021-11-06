using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    class Hangman
    {
        //geklaut von https://www.pax-an.org/2016/05/super-galgenmannchen-worter.html
        private string[] woerter = { "HEIZÖLRÜCKSTOSSABDÄMPFUNG", "DONAUDAMPFSCHIFFFAHRTSKAPITÄNSGESELLTSCHAFTSMÜTZENHALTERUNG",
            "TYP", "LOKOMOTIVDAMPFKESSELDRUCKVENTILVERSCHLUSSKLAPPE", "KIRSCHKERNWEITSPUCKWETTBEWERB",
            "RECYCLING", "WEIHNACHTSMANNSCHOKOLADENEINPACKPAPIER", "ATMOSPHÄRE ", "DESTINATIONSLEBENSZYKLUSMODELL", "ZYKLOP" ,
            "ZYKLON", "GYMNASTIK", "RHYTHMUS", "DESOXYRIBONUKLEINSÄURE", "METAPHER ", "UNIVERSALINDIKATORPAPIERSCHNIPSELCHEN", "ARBEITSUNFÄHIGKEITSBESCHEINIGUNG ",
            "HUNDEHAFTPFLICHTVERSICHERUNG" };

        private int versucheUebrig;

        // geklaut von https://stackoverflow.com/questions/314466/generating-an-array-of-letters-in-the-alphabet
        private static readonly char[] germanAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÄÖÜ".ToCharArray();


        Dictionary<char, bool> buchstabeIstErraten;

        private string wort;

        char[] wortAsCharraray ;

        public string Wort { get => wort; set => wort = value; }

        public static char[] GermanAlphabet => germanAlphabet;

        public int VersucheUebrig { get => versucheUebrig; set => versucheUebrig = value; }
        public char[] WortAsCharraray { get => wortAsCharraray; set => wortAsCharraray = value; }
        public Dictionary<char, bool> BuchstabeIstErraten { get => buchstabeIstErraten; set => buchstabeIstErraten = value; }

        public Hangman()
        {
            VersucheUebrig = 10;
            BuchstabeIstErraten = new Dictionary<char, bool> { };
            foreach (char letter in germanAlphabet)
            {
                BuchstabeIstErraten.Add(letter, false);
            }


            wort = Zufallsowrt();
            WortAsCharraray = wort.ToCharArray();
        }

        private string Zufallsowrt()
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
                if (BuchstabeIstErraten[letter])
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

            foreach (char letter in wortAsCharraray)
            {
                if (!BuchstabeIstErraten[letter])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

    }
}
