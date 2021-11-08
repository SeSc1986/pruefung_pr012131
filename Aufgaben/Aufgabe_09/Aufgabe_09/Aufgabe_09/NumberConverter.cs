using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    public abstract class NumberConverter
    {

        public const string CONVERSION_SUCCES = "Umwandlung erfolgreich.";
        protected string input;
        private string output;

        private int numberAsInt;

        protected string Output { get => output; set => output = value; }
        protected int NumberAsInt { get => numberAsInt; set => numberAsInt = value; }

        public NumberConverter(string input)
        {
            this.input = input;
        }




        protected abstract string Normalform();

        public abstract string ConversionResult();

        protected abstract bool ConversionSuccefull();

        protected abstract bool InputIsValid();

        public abstract string ConversionMessage();

    }
}
