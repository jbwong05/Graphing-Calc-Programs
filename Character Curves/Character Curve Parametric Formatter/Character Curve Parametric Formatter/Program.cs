﻿using System;
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
        [STAThread]
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
            Process.Start("notepad.exe",equations);
            Console.WriteLine("Press any key to continue and format parametric equations...");
            Console.ReadKey();
            NotepadCloser closer = new NotepadCloser();
            closer.close();
            string text = File.ReadAllText(equations);
            string xParametric = text.Substring(5, text.IndexOf("\r\n") - 4);
            xParametric = xParametric.Trim();
            string yParametric = text.Substring(text.IndexOf("Y(T)") + 5);
            yParametric = yParametric.Trim();
            xParametric = format(xParametric);
            yParametric = format(yParametric);
            Console.WriteLine("Equations Successfully Formatted");
            System.Windows.Forms.Clipboard.SetText(xParametric);
            Console.WriteLine("X(t) stored in clipboard");
            Console.WriteLine("Press Ctrl + V to paste");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            System.Windows.Forms.Clipboard.SetText(yParametric);
            Console.WriteLine("Y(t) stored in clipboard");
            Console.WriteLine("Press Ctrl + V to paste");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            using (StreamWriter sw = File.AppendText(equations))
            {
                sw.WriteLine("\r\n");
                sw.WriteLine("Final X(T): " + xParametric);
                sw.WriteLine("\r\n");
                sw.WriteLine("Final Y(T): " + yParametric);
            }
            Process.Start("notepad.exe",equations);
        }

        static string format(string text)
        {
            int n;
            string formattedText = "";
            while(text.IndexOf(" ") != -1)
            {
                formattedText += text.Substring(0, text.IndexOf(" "));
                text = text.Substring(text.IndexOf(" ")+1);
                /*if (text.Substring(0, 1) == "s")
                {
                    formattedText += "*";
                }*/
            }
            text = formattedText + text;
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
                    formattedText += text.Substring(0, firstBracket+1) + "(" + text.Substring(firstBracket+1, temp - firstBracket);
                }
                text = text.Substring(temp + 1);
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
            //return formattedText + text;
        }
    }
}
