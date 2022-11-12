// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{ 
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = array.GetLength(1) - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
                Console.WriteLine();
    }
}

int rows = Math.Abs(RetrieveInteger("Input your amount of row: "));
int columns = Math.Abs(RetrieveInteger("Input your amount of column: "));
int minvalue = Math.Abs(RetrieveInteger("Input min value of array: "));
int maxvalue = Math.Abs(RetrieveInteger("Input max value of array: "));
int[,] array = Create2DArrayRandomInt(rows, columns, minvalue, maxvalue);
Show2dArray(array);
SortingArray(array);
Show2dArray(array);
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{ 
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void FindMinimalRow(int[,] array)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"{minSum + 1} строка");
}

int rows = Math.Abs(RetrieveInteger("Input your amount of row: "));
int columns = Math.Abs(RetrieveInteger("Input your amount of column: "));
int minvalue = Math.Abs(RetrieveInteger("Input min value of array: "));
int maxvalue = Math.Abs(RetrieveInteger("Input max value of array: "));
int[,] array = Create2DArrayRandomInt(rows, columns, minvalue, maxvalue);
Show2dArray(array);
FindMinimalRow(array);
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{ 
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void FindProductOfMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < firstMatrix.GetLength(1); n++)
            {
                sum += firstMatrix[i,n] * secondMatrix[n,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}

int rowsoffirstmatrix = Math.Abs(RetrieveInteger("Input amount of row in first matrix: "));
int commonvaluesinmatrix = Math.Abs(RetrieveInteger("Input amount of column in first matrix and amount of row in second matrix: "));
int columnsofsecondmatrix = Math.Abs(RetrieveInteger("Input amount of column in second matrix: "));
int minvalue = Math.Abs(RetrieveInteger("Input min value of arrays: "));
int maxvalue = Math.Abs(RetrieveInteger("Input max value of arrays: "));
int[,] firstMatrix = Create2DArrayRandomInt(rowsoffirstmatrix, commonvaluesinmatrix, minvalue, maxvalue);
int[,] secondMatrix = Create2DArrayRandomInt(commonvaluesinmatrix, columnsofsecondmatrix, minvalue, maxvalue);
int[,] resultMatrix = new int[rowsoffirstmatrix, columnsofsecondmatrix];
Show2dArray(firstMatrix);
Console.WriteLine("");
Show2dArray(secondMatrix);
FindProductOfMatrix(firstMatrix, secondMatrix, resultMatrix);
Show2dArray(resultMatrix);
*/

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
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

int[,,] Create3DArrayRandomInt(int x, int y, int z, int minValue, int maxValue)
{ 
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int n = 0;
            while(n < array.GetLength(2))
            {
                int number = new Random().Next(minValue, maxValue + 1);
                if (SearchElement(array, number)) continue;
                array[i, j, n] = number;
                n++;
            }
        }
    }
    return array;
}

bool SearchElement(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                if (array[i, j, n] == number) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i, j, n]} ({i},{j},{n}) ");
            }
            Console.WriteLine();
        }
    }
}

int x = Math.Abs(RetrieveInteger("Input value of x: "));
int y = Math.Abs(RetrieveInteger("Input value of y: "));
int z = Math.Abs(RetrieveInteger("Input value of z: "));
int[,,] array = Create3DArrayRandomInt(x, y, z, 10, 99);
PrintArray(array);
*/

//Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] CreateArray(int rows, int columns)
{ 
    int[,] array = new int[rows, columns];
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= rows * columns)
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < rows - 1)
        {
            ++j;
        }
        else if (i < j && i + j >= rows - 1)
        {
            ++i;
        }
        else if (i >= j && i + j > rows - 1)
        {
            --j;
        }    
        else
        {
            --i;
        }
        ++number;
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

int[,] array = CreateArray(4, 4);
Show2dArray(array);
*/