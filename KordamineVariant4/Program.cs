using System;

namespace KordamineVariant4
{
    class Program
    {
        static void Main()
        {
            // Проверка на палиндром
            Palindrom palindromeChecker = new Palindrom();
            palindromeChecker.CheckPalindrome();

            // Анализ матрицы
            Matriks matrixAnalyzer = new Matriks();
            matrixAnalyzer.Matrix();

            // Сортировка строки
            Sorteerimne stringSorter = new Sorteerimne();
            stringSorter.SortString();
        }
    }
}