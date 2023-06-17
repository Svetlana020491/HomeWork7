int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayMatrix(int[,] matrix) // заполнение двумерного массива 
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArrayMatrix(int[,] matrix) // печать двумерного массива 
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillMatrix(double[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() + random.Next(-10, 10);
        }
        Console.WriteLine();
    }
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]:F1} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Task47()// готова
{
    //Задайте двумерный массив 
    //размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

    // m×n обозначила как int rows и int columns

    int rows = Input("Введите количество строк матрицы: ");
    int columns = Input("Введите количество столбцов матрицы: ");
    double[,] matrix = new double[rows, columns];

    FillMatrix(matrix);
    PrintMatrix(matrix);

}

void Task50()// готова
{
    // Задача 50. Напишите программу, которая на вход принимает индексы 
    // элемента в двумерном массиве, и возвращает значение этого элемента 
    // или же указание, что такого элемента нет.

    int rows = Input("Введите количество строк матрицы: ");
    int columns = Input("Введите количество столбцов матрицы: ");
    int[,] matrix = new int[rows, columns];
    FillArrayMatrix(matrix);
    PrintArrayMatrix(matrix);

    int i = Input("Введите индекс I:  ");
    int j = Input("Введите индекс J:  ");
    if (i > rows && j > columns)
        Console.WriteLine("такого элемента в массиве нет");
    else
        Console.WriteLine($" matrix [{i}, {j}] -> {matrix.GetValue(i, j)} ");
}

void Task52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    int rows = Input("Введите количество строк матрицы: ");
    int columns = Input("Введите количество столбцов матрицы: ");
    int[,] matrix = new int[rows, columns];
    FillArrayMatrix(matrix);
    Console.WriteLine($" ");
    Console.WriteLine($"Среднее арифметическое столбцов: ");


    double avarage = 0;
    for (int j = 0; j < columns; j++)
    {
        //double avarage = 0; // вводим сред. арифм
        for (int i = 0; i < rows; i++)
        {
            avarage = (avarage + matrix[i, j]);
        }
        avarage = avarage / columns;
        Console.Write($" {avarage:F2}\t ");

    }
    Console.WriteLine($"");
    PrintArrayMatrix(matrix);

}

Console.Clear();
Task52();

