//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
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

void ShowNumbers(int number)
{
    if(number > 0) 
    {
        Console.Write(number + " ");
        ShowNumbers(number - 1);
    }
}

int number = Math.Abs(RetrieveInteger("Input your number: "));
ShowNumbers(number);
*/


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
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

int FindSum(int M, int N)
{
    if (M < N) 
    {
        return N + FindSum(M, N - 1);
    }
    else if (M > N)
    {
        return N + FindSum(M, N + 1); 
    }
    else if (M == 0) 
    {
        return (N * (N + 1)) / 2; 
    }           
    else if (N == 0)
    {  
        return (M * (M + 1)) / 2;
    }
    else 
    {
        return M;
    }                       
}


int M = RetrieveInteger("Input your number M: ");
int N = RetrieveInteger("Input your number N: ");
int sum = FindSum(M, N);
Console.WriteLine(sum);

*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
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

int CalculatingOfAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return CalculatingOfAkkerman(m - 1, 1);
    }
    else
    {
        return (CalculatingOfAkkerman(m - 1, CalculatingOfAkkerman(m, n - 1)));
    }
}

int m = Math.Abs(RetrieveInteger("Input your number m: "));
int n = Math.Abs(RetrieveInteger("Input your number n: "));
int akkerman = CalculatingOfAkkerman(m, n);
Console.WriteLine(akkerman);
*/