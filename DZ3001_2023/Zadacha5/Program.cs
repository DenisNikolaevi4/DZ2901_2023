// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void FillSpiralArray(int[,] array)
{
    int left = 0, right = array.GetLength(1) - 1, top = 0, bottom = array.GetLength(0) - 1, count = 1;
    while (count <= array.Length)
    {
        // слева напрово
        // Console.WriteLine($"{left} <= {right}");
        for (int i = left; i <= right; i++)
            array[top, i] = count++;
        top++;

        // сверху вниз
        // Console.WriteLine($"{top} <= {bottom}");
        for (int i = top; i <= bottom; i++)
            array[i, right] = count++;
        right--;

        // справо налево
        // Console.WriteLine($"{right} >= {left}");
        for (int i = right; i >= left; i--)
            array[bottom, i] = count++;
        bottom--;

        // снизу вверх
        // Console.WriteLine($"{bottom} >= {top}");
        for (int i = bottom; i >= top; i--)
            array[i, left] = count++;
        left++;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int rows = 7;
int columns = 5;
int[,] massive = new int[rows, columns];
FillSpiralArray(massive);
PrintArray(massive);