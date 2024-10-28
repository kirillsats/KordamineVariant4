using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineVariant4
{
    internal class Sorteerimne
    {
        public void SortString()
        {
            Console.Write("Sisestage sõna (sorteerimine): ");
            string input = Console.ReadLine();

            // Разворачиваем строку
            string reversedInput = new string(input.Reverse().ToArray());

            Console.WriteLine($"Tagurpidi algne sõna: {reversedInput}");
            
        }
    }
}