// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет

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

void FillMatrix(int[,] matr, int max, int min)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}


int[,] UserMatrix = new int[3, 3];
FillMatrix(UserMatrix, 100, -100);
PrintMatrix(UserMatrix);

int UserRow = Promt("Введите позицию ряда > ");
int UserColumn = Promt("Введите позицию колонки > ");

if (UserRow <= UserMatrix.GetLength(0) && UserColumn <= UserMatrix.GetLength(1))
{
    Console.WriteLine($"Значение элемента массива, расположенного на позиции {UserRow}, {UserColumn} -> {UserMatrix[UserRow - 1, UserColumn - 1]}");
}
else
{
    Console.WriteLine($"{UserRow}, {UserColumn} -> такого элемента в массиве нет");
}
