// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = new Random().Next(2, 5);
int column = new Random().Next(2, 5);

Random randomNumber = new Random();
int[,] table = new int[row, column];
int[] number = new int[row * column];
Console.WriteLine("Задан массив: ");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        table[i, j] = new Random().Next(0, 100);
        Console.Write(table[i, j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметиеское каждого столбца: ");

for (int i = 0; i < column; i++)
{
        int sum = 0;
    for (int j = 0; j < row; j++)
    {
        sum += table[j, i];

    }
    Console.WriteLine($"{i + 1}-го: {sum/row}");
}