using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    public class ArabicToRomanConverter : NumberConverter
    {
        public const string CONVERSION_FAILED_NaI = "Eingabe war keine arabische ganze Zahl.";

        public ArabicToRomanConverter(string input) : base(input)
        {

        }

        public override string ConversionMessage()
        {
            string message;


            if (ConversionSuccefull())
            {
                message = NumberConverter.CONVERSION_SUCCES;
            }
            else
            {
                message = CONVERSION_FAILED_NaI;
            }

            return message;
        }

        public override string ConversionResult()
        {
            if (ConversionSuccefull()) 
            { return Normalform(); }
            else { return "NaI"; }
        }

        protected override bool ConversionSuccefull()
        {
            return InputIsValid();
        }

        protected override bool InputIsValid()
        {
            bool success = int.TryParse(input, out int output);

            if (success)
            {
                if (output <= 0)
                {
                    success = false;
                } else if (1 <= output && output < 4000 )
                {
                    NumberAsInt = output ;
                } else if (output >= 4000)
                {
                    success = false;
                }
            }
            return success;
        }

        protected override string Normalform()
        {
            int tausender = NumberAsInt / 1000;
            int hunderter = (NumberAsInt - 1000*tausender) / 100;
            int zehner = (NumberAsInt - 1000 * tausender - 100*hunderter) / 10;
            int einer = NumberAsInt % 10;

            StringBuilder sb = new StringBuilder();

            
            AppendSymbol(tausender, sb, "M");

            sb.Append(StringPart(hunderter, "C", "D", "M"));
            sb.Append(StringPart(zehner, "X", "L", "C"));
            sb.Append(StringPart(einer, "I", "V", "X"));

            return sb.ToString();
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
                    AppendSymbol(value-5, sb, wertEinfach);
                    break;
                case 9:
                    AppendSymbol(1, sb, wertEinfach);
                    AppendSymbol(1, sb, wertZehnfach);
                    break;
            }
            return sb.ToString();
        }


    }
}
