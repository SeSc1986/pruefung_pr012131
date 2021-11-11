using System;
using System.Windows.Forms;

namespace Aufgabe_09
{
    public partial class Form1 : Form
    {
        private RomanConverter rc = new RomanConverter();

        public Form1()
        {
            InitializeComponent();
            labelDisplayArabicToRoman.Text = String.Empty;
        }

        private void buttonConvertRtoA_Click(object sender, EventArgs e)
        {
            int result = rc.ConvertRomanToInt(tBRomanInput.Text);

            if (result > 0)
            {
                labelDisplayRomanToArabic.Text = result.ToString();
            }
            else
            {
                labelDisplayRomanToArabic.Text = RomanConverter.NOVALIDROMAN;
            }
        }

        private void buttonConvertAtoR_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tBArabicInput.Text, out int input))
            {
                labelDisplayArabicToRoman.Text = rc.ConvertIntToRoman(input);
            }
            else
            {
                labelDisplayArabicToRoman.Text = RomanConverter.NOVALIDINTEGER;
            }
        }
    }
}
