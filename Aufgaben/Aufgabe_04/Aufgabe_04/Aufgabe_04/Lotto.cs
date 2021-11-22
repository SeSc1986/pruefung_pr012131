using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Aufgabe_04
{
   

    class Lotto
    {

        private static List<int> lottozahlen = new List<int>();

        public List<int> GezogeneZahlen { get; set; } = new List<int>();

        // I may not be used
        private Lotto() { }


        public Lotto(int anzahlDerGezogenenZahlen, int bascet)
        {
            InitializeBasket(bascet);
            GezogeneZahlen = Ziehung(anzahlDerGezogenenZahlen);
        }


        private static void InitializeBasket(int anzahlZahlen)
        {
            lottozahlen.Clear();

            for (int i = 1; i <= anzahlZahlen; i++)
            {
                lottozahlen.Add(i);
            }
        }


        public static List<int> Ziehung(int anzahlDerGezogenenZahlen)
        {
            List<int> interimswerte = new List<int>();

            for (int i = 0; i < anzahlDerGezogenenZahlen; i++)
            {
                interimswerte = Einzelziehung(interimswerte);
            }

            return interimswerte;
        }

        private static List<int> Einzelziehung(List<int> interimswerte)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] box = new byte[4];
            provider.GetBytes(box);
            int starkeZufallszahl = BitConverter.ToInt32(box, 0);

            Random zufall = new Random(starkeZufallszahl);
            int zufallszahl = zufall.Next(1, lottozahlen.Count);
            interimswerte.Add(lottozahlen[zufallszahl - 1]);
            lottozahlen.RemoveAt(zufallszahl - 1);
            return interimswerte;
        }

    }
}
