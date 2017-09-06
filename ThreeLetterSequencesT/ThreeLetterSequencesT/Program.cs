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
            string regexTLS = @"\w\w\w";
            string regexString = "tra";
            //Regex regexMatcher = new Regex(regexString, RegexOptions.IgnoreCase);
            int counterTLS, counterString;
            String text = System.IO.File.ReadAllText(inputFile);

            counterTLS = Regex.Matches(text, regexTLS, RegexOptions.IgnoreCase).Count;
            counterString = Regex.Matches(text, regexString, RegexOptions.IgnoreCase).Count;

            Console.WriteLine("{0} TLS found",  counterTLS.ToString());
            Console.WriteLine("{0} String matches found",  counterString.ToString());
            Console.ReadKey();
        }
    }
}
