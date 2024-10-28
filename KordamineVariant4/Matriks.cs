using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineVariant4
{
    internal class Matriks
    {
        public void Matrix()
        {
            int n = 0;

            while (true) // Цикл будет выполняться до тех пор, пока не введено корректное значение
            {
                Console.Write("Sisestage maatriksi suurus (n x n): ");
                string input = Console.ReadLine();

                // Разделяем строку по символу 'x' и обрабатываем пробелы
                string[] dimensions = input.ToLower().Trim().Split('x');

                // Проверяем, что ввод корректный
                if (dimensions.Length != 2 ||
                    !int.TryParse(dimensions[0].Trim(), out n) ||
                    !int.TryParse(dimensions[1].Trim(), out int m) ||
                    n != m) // Убедимся, что матрица квадратная
                {
                    Console.WriteLine("Sisestage korrektne maatriksi suurus (nt 3 x 3).");
                }
                else
                {
                    break; // Ввод корректный, выходим из цикла
                }
            }

            int[,] matrix = new int[n, n];

            Console.WriteLine("Sisestage maatriksi elemendid:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            // Вывод количества положительных и отрицательных чисел
            int positiveCount = 0, negativeCount = 0;
            foreach (var item in matrix)
            {
                if (item > 0) positiveCount++;
                else if (item < 0) negativeCount++;
            }

            Console.WriteLine($"Põhilised: {positiveCount}, Negatiivsed: {negativeCount}");
            Console.WriteLine("Null elementide koordinaadid:");

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] == 0)
                        Console.WriteLine($"({i + 1}, {j + 1})");
        }
    }
}