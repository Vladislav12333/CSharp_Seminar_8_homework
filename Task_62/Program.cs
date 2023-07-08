// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];
        int num = 1;
        int rows = 4;
        int cols = 4;
        int rowStart = 0;
        int rowEnd = rows - 1;
        int colStart = 0;
        int colEnd = cols - 1;

        while (num <= rows * cols)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = num;
                num++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = num;
                num++;
            }
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = num;
                num++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = num;
                num++;
            }
            colStart++;
        }

        // Вывод массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}