//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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

void NumberPow(int number, int degree)
{
    Console.WriteLine(Math.Pow(number, degree));
}

int number = RetrieveInteger("Input your number: ");
int degree = RetrieveInteger("Input your degree: ");
NumberPow(number, degree);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
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

int FindSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number%10;
        number/=10;
    }
    return sum;
}

int number = RetrieveInteger("Input your number: ");
int positiveNumber = Math.Abs(number);
int result = FindSum(positiveNumber);
Console.WriteLine($"Sum of digit in your number is {result}");
*/


//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
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

int size = RetrieveInteger("Input your amount of elements: ");
int positiveSize = Math.Abs(size);
int min = RetrieveInteger("Input minimal value for your array: ");
int max = RetrieveInteger("Input maximal value for your array: ");

int[] userArray = CreateRandomArray(positiveSize, min, max);
ShowArray(userArray);
*/