using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wir zeichnen ein gleichschenkliges Dreieck.");
            Console.WriteLine();

            Party();

            Console.WriteLine(Environment.NewLine + "Das Drücken einer beliebigen Taste beendet das Program.");
            Console.ReadKey();
        }

        private static void Party()
        {
            Console.WriteLine("Bitte geben Sie die gewünschte Höhe des Dreiecks als natürliche Zahl ein und bestätigen Sie die Eingabe durch \"Enter\".");

            string hoeheAlsString = Console.ReadLine();

            if (Int32.TryParse(hoeheAlsString, out int hoehe))
            {
                if (hoehe < 1)
                {
                    Console.WriteLine("Zahlen kleiner \"1\" sind nicht zulässig!");
                    Party();
                }
                ZeichneDreieck(hoehe);
            }
            else
            {
                Party();
            }
        }

        private static void ZeichneDreieck(int hoehe)
        {
            for (int i = 1; i <= hoehe; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < LeerzeichenblockInZeile(i, hoehe); j++)
                {
                    sb.Append(" ");
                }

                for (int j = 0; j < AnzahlSterneInZeile(i); j++)
                {
                    sb.Append("*");
                }

                for (int j = 0; j < LeerzeichenblockInZeile(i, hoehe); j++)
                {
                    sb.Append(" ");
                }

                string stringzeile = sb.ToString();

                Console.WriteLine(stringzeile);
            }
        }

        static int AnzahlSterneInZeile(int i)
        {
            return 2 * i - 1;
        }

        static int LeerzeichenblockInZeile(int i, int hoehe)
        {
            return hoehe - i;
        }
    }
}
