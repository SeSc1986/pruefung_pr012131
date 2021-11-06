using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_06
{
    public partial class Form1 : Form
    {

        Font fontLinks;
        Font fontRechts;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChangeTexts_Click(object sender, EventArgs e)
        {
            var textLinks = labelLinks.Text;
            var textRechts = labelRechts.Text;
            labelLinks.Text = textRechts;
            labelRechts.Text = textLinks;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SupersizeMe();
            }
            else
            {
                ResizeMe();
            }
        }

        private void ResizeMe()
        {
            labelLinks.Font = new Font(labelLinks.Font.Name, fontLinks.Size);
            labelRechts.Font = new Font(labelRechts.Font.Name, fontRechts.Size);
        }

        private void SupersizeMe()
        {
            fontLinks = labelLinks.Font;
            fontRechts = labelRechts.Font;

            labelLinks.Font = new Font(labelLinks.Font.Name, 2 * labelLinks.Font.Size);
            labelRechts.Font = new Font(labelRechts.Font.Name, 2 * labelRechts.Font.Size);
        }
    }
}
