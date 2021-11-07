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
            throw new NotImplementedException();
        }

        public override string ConversionResult()
        {
            throw new NotImplementedException();
        }

        protected override bool ConversionSuccefull()
        {
            throw new NotImplementedException();
        }

        protected override bool InputIsValid()
        {
            throw new NotImplementedException();
        }

        protected override string Normalform()
        {
            throw new NotImplementedException();
        }
    }
}
