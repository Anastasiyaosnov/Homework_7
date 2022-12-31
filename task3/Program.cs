// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Promt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void AverageColumns(int[,] matrix)
{
    int num = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum1 = 0;
        double count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum1 += matrix[j, i];
            count++;
        }

        double average = sum1 / count;
        Console.Write($"{average:f1} ");

    }
}



int rows = Promt("Сколько будет в матрице строк?");
int columns = Promt("Сколько будет в матрице столбцов?");
int UserMin = Promt("Введите минимальное значение элемента матрицы");
int UserMax = Promt("Введите максимальное значение элемента матрицы");

int[,] UserMatrix = new int[rows, columns];
FillMatrix(UserMatrix, UserMin, UserMax);
PrintMatrix(UserMatrix);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
AverageColumns(UserMatrix);