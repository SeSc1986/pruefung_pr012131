using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_03
{
    class Program
    {

        static int anzahlVokale = 0, anzahlKonsonanten = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Erstellen Sie ein Programm, das eine Zeichenkette einliest und dann die Anzahl der Vokale sowie die Anzahl der Konsonanten in der Zeichenkette ermittelt." +
                " Als Konsonant dürfen dabei alle Zeichen gezählt werden, die kein Vokal sind – also zum Beispiel auch Zahlen und Sonderzeichen.");

            Run();
        }

        private static void Run()
        {
            string input = Console.ReadLine();

            Auswerten(input);
        }

        private static void Auswerten(string input)
        {

            if (input.Length == 0)
            {
                Console.WriteLine("Keine Zeichenkette eingeben.!");
                Run();
            }
            char[] buchstaben = input.ToCharArray();



            foreach (char buchstabe in buchstaben)
            {
                switch (buchstabe)
                {
                    case 'a':
                        anzahlVokale++;
                        break;
                    case 'e':
                        anzahlVokale++;
                        break;
                    case 'i':
                        anzahlVokale++;
                        break;
                    case 'o':
                        anzahlVokale++;
                        break;
                    case 'u':
                        anzahlVokale++;
                        break;
                    case 'A':
                        anzahlVokale++;
                        break;
                    case 'E':
                        anzahlVokale++;
                        break;
                    case 'I':
                        anzahlVokale++;
                        break;
                    case 'O':
                        anzahlVokale++;
                        break;
                    case 'U':
                        anzahlVokale++;
                        break;
                    default:
                        anzahlKonsonanten++;
                        break;
                }
            }



            Console.WriteLine("Die eingegebene Zeichenkette enthält " + anzahlVokale.ToString() + " und " + anzahlKonsonanten.ToString() + " sonstige " +
                "Zeichen");

            Console.WriteLine("Das Drücken einer beliebigen Taste beendet das Programm");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
