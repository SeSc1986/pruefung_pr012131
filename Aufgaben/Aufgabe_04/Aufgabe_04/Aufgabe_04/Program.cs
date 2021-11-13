using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zeit für Lotto! :");

            NeuesSpiel();
       }

        private static void NeuesSpiel()
        {
            Lotto lotto6aus49 = new Lotto(6, 49);
            List<int> ziehung = lotto6aus49.GezogeneZahlen;
            Console.WriteLine();
            AusgabeDerZiehung(ziehung);
            Console.WriteLine();
            Console.WriteLine("Drücken sie 'Enter' für ein neues Spiel, alle anderen Eingaben beenden das Programm.");
            Console.WriteLine();
            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.Enter)
            {
                NeuesSpiel();
            } else
            {
            Environment.Exit(0);
            }
        }

        private static void AusgabeDerZiehung(List<int> ziehung)
        {
            ziehung.Sort();
            StringBuilder sb = new StringBuilder();

            foreach (var zahjl in ziehung)
            {
                sb.Append(zahjl.ToString() + " ");
            }

            string ergebis = sb.ToString();
            Console.WriteLine("Gezogen wurden die Zahlen : " + ergebis);
        }
    }
}
