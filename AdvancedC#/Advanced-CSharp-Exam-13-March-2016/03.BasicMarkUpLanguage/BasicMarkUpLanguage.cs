using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.BasicMarkUpLanguage
{
    class BasicMarkUpLanguage
    {
        public static string cont = "content=\"";
        public static string val = "value=\"";
        public static int counter = 1;

        static void Main()
        {
            List<string> output = new List<string>();
            string[] newcom = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            string command = String.Join(" ", newcom);
            

            while (command != "<stop/>")
            {
                string content = GetContent(command);
                if (command.Contains("reverse"))
                {
                    var a = content.Reverse();
                    output.Add(counter + ". " + String.Join("", a));
                }
                if (command.Contains("inverse"))
                {
                    string outp = string.Empty;
                    foreach (char c in content)
                    {
                        if (Char.IsUpper(c))
                        {
                            outp += Char.ToLower(c);
                        }
                        else
                        {
                            outp += Char.ToUpper(c);
                        }
                    }
                    output.Add(counter + ". " + outp);
                }
                if (command.Contains("repeat"))
                {
                    int value = GetValue(command);
                    while (value > 0)
                    {
                        output.Add(counter + ". " + content);
                        counter++;
                        value--;
                    }
                }
                counter++;
                command = Console.ReadLine();
            }

            foreach (string o in output)
            {
                Console.WriteLine(o);
            }
        }

        private static int GetValue(string command)
        {
            int index = command.IndexOf(val) + val.Length;
            string rest = command.Substring(index, command.Length - index);
            string content = rest.Substring(0, rest.IndexOf("\""));
            return int.Parse(content);
        }

        private static string GetContent(string command)
        {
            int index = command.IndexOf(cont) + cont.Length;
            string rest = command.Substring(index, command.Length - index - 1);
            string content = rest.Substring(0, rest.IndexOf("\""));
            return content;
        }
    }
}
