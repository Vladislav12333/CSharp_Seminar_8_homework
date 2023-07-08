// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задаем двумерный массив
int[,] array = {
            { 1, 4, 7, 2},
            { 5, 9, 2, 3},
            { 8, 4, 2, 4}
        };

// Упорядочиваем каждую строку по убыванию
SortRowsDescending(array);

// Выводим отсортированный массив
PrintArray(array);


static void SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        // Используем алгоритм сортировки пузырьком для каждой строки
        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = 0; k < cols - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    // Меняем местами элементы, если текущий элемент меньше следующего
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}