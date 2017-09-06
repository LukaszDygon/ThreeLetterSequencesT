using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThreeLetterSequencesT
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputFile = @"C:\Users\LUD\Documents\Training\ThreeLetterSequencesT\ThreeLetterSequencesT\text\SampleText.txt";
            //Regex regexMatcher = new Regex();
            int counter = 0;
            String text = System.IO.File.ReadAllText(inputFile);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 't' && text[i + 1] == 'r' && text[i + 2] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter.ToString());
            Console.ReadKey();
        }
    }
}
