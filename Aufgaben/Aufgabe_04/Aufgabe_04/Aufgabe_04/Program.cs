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

            Lotto lotto6aus49 = new Lotto(6, 49);
            List<int> ziehung = lotto6aus49.GezogeneZahlen;
            AusgabeDerZiehung(ziehung);

            Console.WriteLine("Das Drücken einer beliebigen Taste beendet das Programm");
            Console.ReadKey();
            Environment.Exit(0);
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
