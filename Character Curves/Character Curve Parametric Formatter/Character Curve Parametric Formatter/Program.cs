using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Character_Curve_Parametric_Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string equations = @"Parametric Equations.txt";
            if (!File.Exists(equations))
            {
                using (StreamWriter sw = File.CreateText(equations))
                {
                    sw.WriteLine("X1T: ");
                    sw.WriteLine("\r\n");
                    sw.WriteLine("Y1T: ");
                }
            }
            Console.WriteLine("Input Equations into Parametric Equations.txt");
            Console.WriteLine("Make sure to save text document");
            Process.Start(equations);
            Console.WriteLine("Press any key to continue and format parametric equations...");
            Console.ReadKey();
            string text = File.ReadAllText(equations);
            string xParametric = text.Substring(4, text.IndexOf("Y1T") - 4);
            xParametric = xParametric.Trim();
            string yParametric = text.Substring(text.IndexOf("Y1T") + 4);
            yParametric = yParametric.Trim();
            xParametric = format(xParametric);
            yParametric = format(yParametric);
            using (StreamWriter sw = File.AppendText(equations))
            {
                sw.WriteLine("\r\n");
                sw.WriteLine("Final X1T: " + xParametric);
                sw.WriteLine("\r\n");
                sw.WriteLine("Final Y1T: " + yParametric);
            }
            Console.WriteLine("Equations Successfully Formatted");
            Process.Start(equations);
        }

        static string format(string text)
        {
            string formattedText = "";
            while(text.IndexOf(" ") != -1)
            {
                formattedText += text.Substring(0, text.IndexOf(" "));
                text = text.Substring(text.IndexOf(" ")+1);
                if (text.Substring(0, 1) == "s")
                {
                    formattedText += "*";
                }
            }
            return (formattedText+text).Replace('t','T');
        }
    }
}
