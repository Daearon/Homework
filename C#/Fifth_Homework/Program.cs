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

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }

    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int size = Math.Abs(RetrieveInteger("Input your amount of elements: "));

int[] userArray = CreateRandomArray(size);
ShowArray(userArray);
int result = FindEvenNumbers(userArray);
Console.WriteLine($"Amount of even numbers in your array is {result}");
*/
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

int size = Math.Abs(RetrieveInteger("Input your amount of elements: "));
int min = RetrieveInteger("Input minimal value for your array: ");
int max = RetrieveInteger("Input maximal value for your array: ");

int[] userArray = CreateRandomArray(size, min, max);
ShowArray(userArray);
int result = FindSum(userArray);
Console.WriteLine($"Sum of odd numbers in your array is {result}");
*/
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble();
    }

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMin (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int size = Math.Abs(RetrieveInteger("Input your amount of elements: "));

double[] userArray = CreateRandomArray(size);
ShowArray(userArray);
double minvalue = FindMin(userArray);
double maxvalue = FindMax(userArray);
Console.WriteLine($"{minvalue}, {maxvalue}");
double result = maxvalue - minvalue; 
Console.WriteLine($"Difference of max and min values in your array is {result}");
*/

// Найдите произведение пар чисел в массиве. Парой считаются первый и последний элемент. Результат в новый массив. 
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] FindProduct (int[] array, int[] newArray, bool even)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }
    if (even == false)
    {
        newArray[newArray.Length - 1] = array[array.Length/2];
    }
    return newArray;
}

int size = Math.Abs(RetrieveInteger("Input your amount of elements: "));
int min = RetrieveInteger("Input minimal value for your array: ");
int max = RetrieveInteger("Input maximal value for your array: ");
int[] userArray = CreateRandomArray(size, min, max);
ShowArray(userArray);
bool even = userArray.Length % 2 == 0;
int newSize = userArray.Length/2;
if (even == false)
{
    newSize++;
}
int[] newArray = new int[newSize];
newArray = FindProduct(userArray, newArray, even);
ShowArray(newArray);
*/