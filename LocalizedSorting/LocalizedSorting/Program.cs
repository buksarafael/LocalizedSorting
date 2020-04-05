using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LocalizedSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> persoane = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader("input.txt"))
            {

                while (sr.Peek() > 0)
                {
                    line = sr.ReadLine();
                    line = line.ToLower();
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    line = ti.ToTitleCase(line);
                    persoane.Add(line);

                }

            }
            persoane.Sort();
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                foreach (string pers in persoane)
                {
                    sw.WriteLine(pers);
                }
            }


            Console.WriteLine(File.ReadAllText("output.txt"));


        }
    }
}
