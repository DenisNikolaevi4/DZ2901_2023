// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Random randomNumber = new Random();
double[,] massive = new double[row, column];
Console.WriteLine("Полученный массив: ");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        massive[i, j] = Math.Round((randomNumber.NextDouble() * randomNumber.Next(-100, 100)), 1);
        Console.Write(massive[i, j] + "  ");
    }
    Console.WriteLine();
}

