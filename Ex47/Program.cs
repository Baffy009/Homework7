// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Ведите размер массива через Enter: ");
double[,] array = new double[InputIntNumber(),InputIntNumber()];
FillArray(array);
PrintArray(array);

int InputIntNumber()
{
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
}

void FillArray(double[,] matrixArray)
{
    int rows = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrixArray[i, j] = Math.Round(Convert.ToDouble(rand.Next(-10, 10)) + rand.NextDouble(), 2);
        }
    }
}

void PrintArray(double[,] matrixArray)
{
    int rows = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrixArray[i, j]} ");
        }
        Console.WriteLine();
    }
}