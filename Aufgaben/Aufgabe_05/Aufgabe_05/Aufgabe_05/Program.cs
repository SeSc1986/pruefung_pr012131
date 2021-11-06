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
            Console.WriteLine("Wir zeichnen eine gleichschenkliges Dreieck.");
            Console.WriteLine("Bitte geben sie die gewünschte Höhe des Dreiecks ein");


            string hoeheAlsString = Console.ReadLine();

            //#TODO Fehleingabe behandeln
            int hoehe = Int32.Parse(hoeheAlsString);




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

            Console.ReadKey();
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
