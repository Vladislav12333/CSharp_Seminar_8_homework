// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array = new int[,]
{
            { 8, 4, 2, 4}, 
            { 1, 4, 7, 2},   
            { 5, 2, 6, 7}, 
            { 5, 9, 2, 3}  
};

int minSumRow = FindRowWithMinSum(array);

Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRow);


static int FindRowWithMinSum(int[,] array)
{
    int minSumRow = 0;
    int minSum = int.MaxValue;

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;

        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }

    return minSumRow;
}