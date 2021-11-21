using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aufgabe_09
{
    public class RomanConverter
    {
        public const string NOVALIDINTEGER = "Bitte eine Zahl zwischen 1 und 3999 eingeben.";
        public const string NOVALIDROMAN = "Keine zulässige römische Zahl.";

        public string ConvertIntToRoman(int inputArabic)
        {

            if (inputArabic < 1 || inputArabic >= 4000)
            {
                return NOVALIDINTEGER;
            }


            int tausender = inputArabic / 1000;
            int hunderter = (inputArabic - 1000 * tausender) / 100;
            int zehner = (inputArabic - 1000 * tausender - 100 * hunderter) / 10;
            int einer = inputArabic % 10;

            StringBuilder sb = new StringBuilder();

            AppendSymbol(tausender, sb, "M");

            sb.Append(StringPart(hunderter, "C", "D", "M"));
            sb.Append(StringPart(zehner, "X", "L", "C"));
            sb.Append(StringPart(einer, "I", "V", "X"));



            return sb.ToString(); ;
        }


        private static void AppendSymbol(int count, StringBuilder sb, string symbol)
        {
            for (int i = 0; i < count; i++)
            {
                sb.Append(symbol);
            }
        }


        private string StringPart(int value, string wertEinfach, string wertFuenfach, string wertZehnfach)
        {
            StringBuilder sb = new StringBuilder();

            switch (value)
            {
                case 1:
                case 2:
                case 3:
                    AppendSymbol(value, sb, wertEinfach);
                    break;
                case 4:
                    AppendSymbol(1, sb, wertEinfach);
                    AppendSymbol(1, sb, wertFuenfach);
                    break;
                case 5:
                    AppendSymbol(1, sb, wertFuenfach);
                    break;
                case 6:
                case 7:
                case 8:
                    AppendSymbol(1, sb, wertFuenfach);
                    AppendSymbol(value - 5, sb, wertEinfach);
                    break;
                case 9:
                    AppendSymbol(1, sb, wertEinfach);
                    AppendSymbol(1, sb, wertZehnfach);
                    break;
            }
            return sb.ToString();
        }


        public int ConvertRomanToInt(string inputRoman)
        {
            int result = 0;
            RomanValues romanValues = new RomanValues();
            Dictionary<char, int> rnv = romanValues.romanNumberValue;

            char[] ziffern = inputRoman.ToCharArray();

            for (int i = 0; i < ziffern.Length; i++)
            {
                if ( i != ziffern.Length -1 && rnv[ziffern[i + 1]] > rnv[ziffern[i]]  )
                {
                    result = result + rnv[ziffern[i + 1]] - rnv[ziffern[i]];
                    i++;
                }
                else
                {
                    result = result + rnv[ziffern[i]];
                }
            }

            if (ConvertIntToRoman(result) == inputRoman)
            {
            return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
