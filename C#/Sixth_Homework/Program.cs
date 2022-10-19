//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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

int CountingPositiveNumbers (int size)
{
    int count = 0;
    int sum = 0;
    while (count < size)
    {
        int number = RetrieveInteger("Input your number: ");
        if (number > 0)
        {
            sum+=1;
        }
        count++;
    }
    return sum;
}

int size = Math.Abs(RetrieveInteger("Input your amount of numbers: "));
int result = CountingPositiveNumbers(size);
Console.WriteLine($"Amount of positive numbers is {result}");
*/
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
static double RetrieveDouble (string msg)
{
    Console.WriteLine(msg);
    while (true)
    {
        if(double.TryParse(Console.ReadLine(), out var correctnumber))
        {
            Console.WriteLine($"Good, your number is {correctnumber}");
            return correctnumber;
        }
        else
        {
            Console.WriteLine("Input is not double, retry, please");
        }
    }
}

void FindIntersectionPoint (double k1, double b1, double k2, double b2)
{
   if (k1 == k2 && b1 != b2)
        {
            Console.WriteLine("Your lines is parallel");
            return;
        } 
   else if (k1 == k2 && b1 == b2)
        {
            Console.WriteLine("Your lines is matching");
            return;
        }
   double x = (b2-b1)/(k1-k2);
   double y = k1 * x + b1;
   Console.WriteLine($"Intersection point is {x}, {y}");
}

double k1 = RetrieveDouble("Input your k1 number: ");
double k2 = RetrieveDouble("Input your k2 number: ");
double b1 = RetrieveDouble("Input your b1 number: ");
double b2 = RetrieveDouble("Input your b2 number: ");
FindIntersectionPoint(k1, b1, k2, b2);
*/