/*
static int RetrieveInteger (string msg)
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

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
static int FindPaleodrom(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = (result*10) + (number%10);
        number = number / 10;
    }
    return result;
}

int defaultNumber = RetrieveInteger("Input your number: ");
int positiveDefaultNumber = Math.Abs(defaultNumber); 
int paleodrom = FindPaleodrom(positiveDefaultNumber);
if (paleodrom == positiveDefaultNumber)
{
    Console.WriteLine("Yes, your number is paleodrom");
} 
else 
{
    Console.WriteLine("No, your number is not paleodrom");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
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

double FindDistance (double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));
}
double numberxa = RetrieveDouble("Input your xa-coordinate: ");
double numberxb = RetrieveDouble("Input your xb-coordinate: ");
double numberya = RetrieveDouble("Input your ya-coordinate: ");
double numberyb = RetrieveDouble("Input your yb-coordinate: ");
double numberza = RetrieveDouble("Input your za-coordinate: ");
double numberzb = RetrieveDouble("Input your zb-coordinate: ");
Console.WriteLine(FindDistance(numberxa, numberxb, numberya, numberyb, numberza, numberzb));
*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
static int RetrieveInteger (string msg)
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
static void FindCube(int N)
{
    double count = 1;
    while (count < N)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}

int number = RetrieveInteger("Input your number: ");
FindCube(number);
*/