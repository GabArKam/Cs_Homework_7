// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindIndex(int[,] array)
{
    
    Console.Write("Введите искомый элемент: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int position = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == x) 
                {
                    position = x;
                    Console.WriteLine($"Позиция искомого элемента [{i},{j}]");
                }
        }
            if(position == 0) Console.WriteLine($"Искомый элемент отсутствует");
}



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
FindIndex(array);