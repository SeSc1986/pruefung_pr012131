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
            Console.WriteLine("Dieses Programm liest eine Zeichenkette ein und bestimmt dann die Anzahl der Vokale {a,e,i,o,u,ä,ö,ü,A,E,I,O,U,Ä,Ö,Ü}, sowie die Anzahl der Konsonanten in der Zeichenkette." +
                " Als Konsonant zählen dabei alle Zeichen, die kein Vokal sind – also zum Beispiel auch Zahlen und Sonderzeichen.");
            Console.WriteLine("Eingabe Zeichenekette>>>>");

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
                    case 'ä':
                        anzahlVokale++;
                        break;
                    case 'ö':
                        anzahlVokale++;
                        break;
                    case 'ü':
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
                    case 'Ä':
                        anzahlVokale++;
                        break;
                    case 'Ö':
                        anzahlVokale++;
                        break;
                    case 'Ü':
                        anzahlVokale++;
                        break;
                    default:
                        anzahlKonsonanten++;
                        break;
                }
            }



            Console.WriteLine("Die eingegebene Zeichenkette enthält " + anzahlVokale.ToString() + " Vokale und " + anzahlKonsonanten.ToString() + " Konsonanten (bzw. sonstige) " +
                "Zeichen");

            Console.WriteLine("Das Drücken einer beliebigen Taste beendet das Programm");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
