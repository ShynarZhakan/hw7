// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j],3}\t");
        }
        Console.WriteLine();
    }
}

void CheckPosition(int[,] array, int number)
{
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                count1++;
                Console.WriteLine($"Это число находится в позиции [{i}, {j}]");
            }
            else count2++;
        }
    if (count1==0 && count2>0) Console.WriteLine("Такого числа нет");
    
}

Console.WriteLine("Введите искомое значение: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int rows = new Random().Next(3, 8);
int colums = new Random().Next(3, 8); ;
int[,] table = new int[rows, colums];
FillArray(table);
PrintTable(table);
Console.WriteLine();
CheckPosition(table, num);

