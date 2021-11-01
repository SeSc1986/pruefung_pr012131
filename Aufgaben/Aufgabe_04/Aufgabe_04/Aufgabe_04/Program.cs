using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_04
{
    class Program
    {

        public static List<int> lottozahlen = new List<int>();

        static void Main(string[] args)
        {

            Console.WriteLine("Zeit für Lotto! :");

            List<int> lottozahlen1 = new List<int>();

            for (int i = 1; i <= 49; i++)
            {
                lottozahlen1.Add(i);
            }


            lottozahlen1 = Shuffle(lottozahlen1);


            for (int i = 0; i < 49; i++)
            {
                lottozahlen.Add(lottozahlen1[i]);
            }



            List<int> ziehung = Lotto();

            StringBuilder sb = new StringBuilder();


            foreach (var zahjl in ziehung)
            {
                sb.Append(zahjl.ToString() + " ");
            }

            string ergebis = sb.ToString();


            Console.WriteLine("Gezogen wurden die Zahlen : " + ergebis);


            Console.WriteLine("Das Drücken einer beliebigen Taste beendet das Programm");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static List<int> Lotto()
        {
            List<int> interimswerte = new List<int>();



            for (int i = 0; i < 6; i++)
            {
                interimswerte = Einzelziehung(interimswerte);
            }

            return interimswerte;
        }

        private static List<int> Einzelziehung(List<int> interimswerte)
        {
            Random zufall = new Random(DateTime.Now.Millisecond);
            int zufallszahl = zufall.Next(1, lottozahlen.Count);
            interimswerte.Add(lottozahlen[zufallszahl - 1]);
            lottozahlen.RemoveAt(zufallszahl - 1);
            return interimswerte;
        }




        // Fisher-Yates shuffle:  see https://stackoverflow.com/questions/273313/randomize-a-listt
        public static List<int> Shuffle(List<int> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }





}
