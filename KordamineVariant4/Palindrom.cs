using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KordamineVariant4
{
    internal class Palindrom
    {
        public void CheckPalindrome()
        {
            Console.Write("Sisestage sõna (palindrom): ");
            string input = Console.ReadLine().ToLower().Replace(" ", "");
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            // Проверяем, является ли строка палиндромом
            if (input == reversedInput)
            {
                Console.WriteLine($"String on palindroom: {input}");
            }
            else
            {
                Console.WriteLine($"String ei ole palindroom: {input}");
            }
        }
    }
}