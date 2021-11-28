using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_01
{
    class Program
    {
        Dictionary<int, bool> intIsPrime = new Dictionary<int, bool>();


        static void Main(string[] args)
        {
            Console.WriteLine("Drücken Sie eine beliebige Taste um alle Primzahlen unter 1000 anzeigen zu lassen.");
            Console.WriteLine();
            Console.ReadKey(true);

            string primesBelow1000 = SiebDesEratosthenes(1000);
            Console.WriteLine("Primzahlen zwischen 1 und 1000: "+ Environment.NewLine + primesBelow1000);
            Console.WriteLine();
            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Program zu beenden.");
            Console.ReadKey(true);
            Environment.Exit(0);
        }


        //Liefert einen String der die Primzahle kleiner als n aufsteigend enthält, getrennt druch ein Leerzeichen.
        private static string SiebDesEratosthenes(int n)
        {
            int maxCheck = (int)Math.Ceiling(Math.Sqrt(n));
            Dictionary<int, bool> intIsPrime = new Dictionary<int, bool>();

            for (int i = 1; i < n + 1; i++)
            {
                intIsPrime.Add(i, true);
            }

            intIsPrime[1] = false;

            for (int i = 1; i < maxCheck; i++)
            {
                if (intIsPrime[i])
                {
                    int j = 2 * i;

                    while (j <= n)
                    {
                        intIsPrime[j] = false;
                        j = j + i;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < n + 1; i++)
            {
                if (intIsPrime[i])
                {
                    sb.Append(i.ToString() + " ");
                }
            }

            return sb.ToString();
        }
    }
}
