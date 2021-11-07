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

        protected string Output { get => output; set => output = value; }

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
