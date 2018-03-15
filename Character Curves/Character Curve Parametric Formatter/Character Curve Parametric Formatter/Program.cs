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
                    sw.WriteLine("X(T): ");
                    sw.WriteLine("\r\n");
                    sw.WriteLine("Y(T): ");
                }
            }
            else
            {
                File.WriteAllText(equations, String.Empty);
                using (StreamWriter sw = File.AppendText(equations))
                {
                    sw.WriteLine("X(T): ");
                    sw.WriteLine("\r\n");
                    sw.WriteLine("Y(T): ");
                }
            }
            Console.WriteLine("Input Equations into Parametric Equations.txt");
            Console.WriteLine("Make sure to save text document");
            Process.Start(equations);
            Console.WriteLine("Press any key to continue and format parametric equations...");
            Console.ReadKey();
            string text = File.ReadAllText(equations);
            string xParametric = text.Substring(4, text.IndexOf("Y(T)") - 4);
            xParametric = xParametric.Trim();
            string yParametric = text.Substring(text.IndexOf("Y(T)") + 4);
            yParametric = yParametric.Trim();
            xParametric = format(xParametric);
            yParametric = format(yParametric);
            using (StreamWriter sw = File.AppendText(equations))
            {
                sw.WriteLine("\r\n");
                sw.WriteLine("Final X(T): " + xParametric);
                sw.WriteLine("\r\n");
                sw.WriteLine("Final Y(T): " + yParametric);
            }
            Console.WriteLine("Equations Successfully Formatted");
            Process.Start(equations);
        }

        static string format(string text)
        {
            int n;
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
            text = formattedText;
            formattedText = "";
            int temp = text.IndexOf("/");
            while (temp != -1)
            {
                int firstBracket = temp - 1;
                while(firstBracket >= 0 && int.TryParse(text.Substring(firstBracket,1), out n)){
                    firstBracket--;
                }
                if (firstBracket == -1)
                {
                    formattedText += "(" + text.Substring(0,temp+1); 
                }
                else
                {
                    formattedText += text.Substring(0, firstBracket+1) + "(" + text.Substring(firstBracket+1, temp - firstBracket + 1);
                }
                text = text.Substring(0, temp + 1);
                int secondBracket = 0;
                while(secondBracket<text.Length && int.TryParse(text.Substring(secondBracket,1), out n))
                {
                    secondBracket++;
                }
                if (secondBracket >= text.Length)
                {
                    formattedText += text + ")";
                }
                else
                {
                    formattedText += text.Substring(0, secondBracket) + ")";
                    text = text.Substring(secondBracket);
                }
                temp = text.IndexOf("/");
            }
            return (formattedText+text).Replace('t','T');
        }
    }
}
