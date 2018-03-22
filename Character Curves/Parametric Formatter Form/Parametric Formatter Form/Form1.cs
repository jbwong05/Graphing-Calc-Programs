using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametric_Formatter_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Clipboard.SetText(FormatEquation(textBox1.Text));
            }
        }

        private string FormatEquation(string originalEquation)
        {
            int n;
            string formattedEquation = "";
            while (originalEquation.IndexOf(" ") != -1)
            {
                formattedEquation += originalEquation.Substring(0, originalEquation.IndexOf(" "));
                originalEquation = originalEquation.Substring(originalEquation.IndexOf(" ") + 1);
                /*if (text.Substring(0, 1) == "s")
                {
                    formattedText += "*";
                }*/
            }
            originalEquation = formattedEquation + originalEquation;
            formattedEquation = "";
            int temp = originalEquation.IndexOf("/");
            while (temp != -1)
            {
                int firstBracket = temp - 1;
                while (firstBracket >= 0 && int.TryParse(originalEquation.Substring(firstBracket, 1), out n))
                {
                    firstBracket--;
                }
                if (firstBracket == -1)
                {
                    formattedEquation += "(" + originalEquation.Substring(0, temp + 1);
                }
                else
                {
                    formattedEquation += originalEquation.Substring(0, firstBracket + 1) + "(" + originalEquation.Substring(firstBracket + 1, temp - firstBracket);
                }
                originalEquation = originalEquation.Substring(temp + 1);
                int secondBracket = 0;
                while (secondBracket < originalEquation.Length && int.TryParse(originalEquation.Substring(secondBracket, 1), out n))
                {
                    secondBracket++;
                }
                if (secondBracket >= originalEquation.Length)
                {
                    formattedEquation += originalEquation + ")";
                }
                else
                {
                    formattedEquation += originalEquation.Substring(0, secondBracket) + ")";
                    originalEquation = originalEquation.Substring(secondBracket);
                }
                temp = originalEquation.IndexOf("/");
            }
            return (formattedEquation + originalEquation).Replace('t', 'T');
        }
    }
}
