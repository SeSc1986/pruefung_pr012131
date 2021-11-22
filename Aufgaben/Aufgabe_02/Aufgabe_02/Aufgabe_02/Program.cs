using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_02
{
    class Program
    {
        private static decimal lastInput = 0;
        private static List<decimal> inputNumbers = new List<decimal>();

        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm liest solange Zahlen ein, bis das erste mal die Zahl \"0\" eingegeben wird.\n" +
                        "Dann wird die Summe und der Mittelwert der bis dahin eingegeben Zahlen berechnet. " +
                        "Akzeptiert als Eingabe werden ganze Zahlen  (\"1\",\"-12\", \"123\") sowie Zahlen in Dezimalschreibweise mit Dezimalpunkt oder Komma (\"1,0\", \"1.5\").");
            Console.WriteLine("Zahleneingabe >>>");

            ZahlenEingabe();

        }

        private static void ZahlenEingabe()
        {
            string input = Console.ReadLine();

            input = input.Replace(".", ",");


            if (decimal.TryParse(input, out lastInput))
            {
                if (lastInput == 0)
                {
                    if (inputNumbers.Count == 0)
                    {
                        Console.WriteLine("Sie müssen mindestens eine Zahl ungleich \'0\' eingeben.");
                        ZahlenEingabe();
                    }
                    else
                    {
                    string summe = inputNumbers.Sum().ToString();
                    string durchschnitt = inputNumbers.Average().ToString();

                    Console.WriteLine("Die Summe der eingegebenen Zahlen ist " + summe + " und der Durchschnitt beträgt " + durchschnitt + ".");

                    Console.WriteLine("Das Drücken einer beliebigen Taste beendet das Programm");
                    Console.ReadKey();
                    Environment.Exit(0);
                    }
                }
                else
                {
                    inputNumbers.Add(lastInput);
                    ZahlenEingabe();
                }
            }
            else
            {
                Console.WriteLine("Bitte nur Zahlen eingeben");
                ZahlenEingabe();
            }
        }
    }
}
