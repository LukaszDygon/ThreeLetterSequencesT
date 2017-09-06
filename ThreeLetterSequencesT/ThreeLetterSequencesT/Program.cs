using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThreeLetterSequencesT
{
    class TLSHelper
    {
        Dictionary<String, int> tlsCountDictionary;

        public TLSHelper() {
            this.tlsCountDictionary = new Dictionary<String, int>();
        }

        public void ConstructTLSCountDictionary(string inputFile)
        {
            string regexTLS = @"(\w(?=(\w\w)))";
            string text = System.IO.File.ReadAllText(inputFile);
            var matches = Regex.Matches(text, regexTLS, RegexOptions.IgnoreCase);

            foreach (Match m in matches)
            {
                string matchedTLS = string.Format("{0}{1}", m.Groups[1].ToString(), m.Groups[2].ToString()).ToLower();
                //Console.WriteLine(tls);
                if (this.tlsCountDictionary.ContainsKey(matchedTLS))
                {
                    this.tlsCountDictionary[matchedTLS]++;
                }
                else
                {
                    this.tlsCountDictionary[matchedTLS] = 1;
                }
            }
        }

        public void PrintTLSCount(string tls)
        {
            tls = tls.ToLower();
            try {
                Console.WriteLine("Count of {0}: {1}", tls, this.tlsCountDictionary[tls]);
            } catch (KeyNotFoundException e) {
                Console.WriteLine("No TLS matches found for {0}", tls);
            }
        }

        public void PrintTLSsWithCount(int numberOfOccurances)
        {
            var listOfHits = GetElementsWithCounts(numberOfOccurances);

            Console.WriteLine("TLSs with {0} occurances:", numberOfOccurances);
            foreach (string hit in listOfHits)
            {
                Console.WriteLine(hit);
            }
        }

        public void PrintTopResults(int numberOfResults)
        {
            var topResults = GetTopResults(numberOfResults);

            Console.WriteLine("Top {0} highest occuring results:", numberOfResults);
            foreach (var item in topResults.Take(numberOfResults))
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }

        public IEnumerable<KeyValuePair<string, int>> GetTopResults(int numberOfResults)
        {
            var tlsCountDictionaryCopy = new Dictionary<String, int>(this.tlsCountDictionary);
            return tlsCountDictionaryCopy.OrderByDescending(x => x.Value).Take(numberOfResults);
        }

        public List<string> GetElementsWithCounts(int count)
        {
            var matches = this.tlsCountDictionary.Where(kvp => kvp.Value == count).Select(kvp => kvp.Key);
            return matches.ToList();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"C:\Users\LUD\Documents\Training\ThreeLetterSequencesT\ThreeLetterSequencesT\text\SampleText.txt";
            string testString = "the";
            int numberOfOccurances = Int32.Parse(args[0]);

            var tlsHelper = new TLSHelper();
            tlsHelper.ConstructTLSCountDictionary(inputFile);

            tlsHelper.PrintTLSCount(testString);
            tlsHelper.PrintTopResults(10);
            tlsHelper.PrintTLSsWithCount(numberOfOccurances);

            Console.ReadKey();
        }
    }
}
