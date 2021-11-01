using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_02
{
    class Program
    {
        private static int lastInput = 0;
        private static List<int> inputNumbers = new List<int>();

        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int>();

            Console.WriteLine("Dieses Programm liest solange Zahlen ein, bis das erste mal eine '0' eingegeben wird.\n" +
                        "Dann wird die Summe und der Mittelwert der bis dahin eingegeben Zahlen berechnet.");
            Console.WriteLine("Zahleneingabe >>>");


            ZahlenEingabe();
        

        }

        private static void ZahlenEingabe()
        {
            string input = Console.ReadLine();


            try
            {
                if (Int32.TryParse(input, out lastInput))
                {

                }
                else
                {
                    throw
                }
            }
            catch (Exception e)
            {
     
                Console.WriteLine("Bitte nur ganze Zahlen eingeben");
                ZahlenEingabe();
            }


            if (lastInput == 0)
            {

                string summe = inputNumbers.Sum().ToString();
                string durchschnitt = inputNumbers.Average().ToString();

                Console.WriteLine("Die Summe der eingegebenen Zahlen ist " + summe + " und der Durchschnitt beträgt " + durchschnitt + ".");

                Console.ReadLine();
            }
            else
            {
                inputNumbers.Add(lastInput);
                ZahlenEingabe();
            }
       }
    }
}
