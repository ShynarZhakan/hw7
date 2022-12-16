// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

void FillArray(int[,] tbl)
{
    for (int i = 0; i < tbl.GetLength(0); i++)
    {
        for (int j = 0; j < tbl.GetLength(1); j++)
        {
            tbl[i, j] = new Random().Next(0, 10);
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

void SortArray(int[,] tbl)
{
    int size = tbl.GetLength(0) * tbl.GetLength(1);
    int[] newArray = new int[size];
    int position = 0;
    for (int i = 0; i < tbl.GetLength(0); i++)
    {
        for (int j = 0; j < tbl.GetLength(1); j++)
        {
            newArray[position] = tbl[i, j];
            position++;
        }
    }
    Array.Sort(newArray);
    int count = 0;
    for (int i = 0; i < tbl.GetLength(0); i++)
    {
        for (int j = 0; j < tbl.GetLength(1); j++)
        {
            tbl[i, j] = newArray[count];
            count++;
        }
    }
}


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[rows, colums];
FillArray(table);
PrintTable(table);
Console.WriteLine();
SortArray(table);
PrintTable(table);
