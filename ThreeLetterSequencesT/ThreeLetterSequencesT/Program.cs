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
        public void PrintResults(int counterTLS, int counterString)
        {
            Console.WriteLine("{0} TLS found", counterTLS.ToString());
            Console.WriteLine("{0} String matches found", counterString.ToString());
        }

        public void TLSFinder(String inputFile, String regexString)
        {
            
            string regexTLS = @"\w\w\w";
            int counterTLS, counterString;

            String text = System.IO.File.ReadAllText(inputFile);

            counterTLS = Regex.Matches(text, regexTLS, RegexOptions.IgnoreCase).Count;
            counterString = Regex.Matches(text, regexString, RegexOptions.IgnoreCase).Count;

            PrintResults(counterTLS, counterString);

            Console.ReadKey();
        }

        

        static void Main(string[] args)
        {
            String inputFile = @"C:\Users\LUD\Documents\Training\ThreeLetterSequencesT\ThreeLetterSequencesT\text\SampleText.txt";
            string regexString = "tra";
            Program test = new Program();
            test.TLSFinder(inputFile, regexString);
        }
    }
}
