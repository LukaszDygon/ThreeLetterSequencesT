using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLetterSequencesT
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Enter the string:");
            String userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 't' && userInput[i + 1] == 'r' && userInput[i + 2] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter.ToString());
            Console.ReadKey();
        }
    }
}
