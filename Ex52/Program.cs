// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = new int[3, 4];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 100);
        Console.Write($"{matrix[i, j]} ");

    }
    Console.WriteLine();
}
Console.WriteLine();

for (int n = 0; n < matrix.GetLength(1); n++)
{
    double sum = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {

        sum = sum + matrix[m, n];

    }

    Console.Write(Math.Round(sum / matrix.GetLength(0), 1));
    Console.Write(" ");

}