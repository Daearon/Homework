/*
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArray ()
{
    Console.Write("Input your number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input your number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                array[i,j] = new Random().NextDouble();
            }
        }
    return array;
}

void Show2dArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int RetrieveInteger (string msg)
{
    Console.WriteLine(msg);
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out var correctnumber))
        {
            Console.WriteLine($"Good, your number is {correctnumber}");
            return correctnumber;
        }
        else
        {
            Console.WriteLine("Input is not integer, retry, please");
        }
    }
}

int[,] Create2dArray ()
{
    Console.Write("Input your number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input your number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Creating array");

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Console.Write($"Input a {i + 1},{j + 1} element of array: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElement (int row, int column, int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if (row > array.GetLength(0) || column > array.GetLength(1))
            {
                Console.WriteLine("Thank you, user! But your index in another array");
                break;
            }
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
                Console.WriteLine($"Your serched number is {array[i, j]}");
            }
        }
    }
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
int indexofrow = Math.Abs(RetrieveInteger("Input your index of row: "));
int indexofcolumn = Math.Abs(RetrieveInteger("Input your index of column: "));
FindElement(indexofrow, indexofcolumn, myArray);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] Create2dArray (int rows, int columns)
{
    Console.WriteLine("Creating array");

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Console.Write($"Input a {i + 1},{j + 1} element of array: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] FindArithmeticMeanofColumns (int[,] array, int columns)
{
    int sum;
    int[] newArray = new int[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        newArray[i] = sum/array.GetLength(1);
    }
    return newArray;
}

Console.Write("Input your number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2dArray(rows, columns);
Show2dArray(myArray);
int[] newArray = FindArithmeticMeanofColumns(myArray, columns);
ShowArray(newArray);
*/