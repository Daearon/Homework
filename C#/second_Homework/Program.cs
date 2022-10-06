static int RetrieveInteger (string msg)
{
    Console.WriteLine(msg);
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out var correctnumber))
        {
            Console.WriteLine($"Хорошо, ваше число {correctnumber}");
            return correctnumber;
        }
        else
        {
            Console.WriteLine("Ввод не является целым числом, повторите еще раз");
        }
    }
}

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
static int GetSecondNumber (int num) 
{
    int hundreds = num / 10;
    int secondNumber = hundreds % 10;
    return secondNumber;
}


int number = RetrieveInteger("Введите трехзначное число: ");
int findedSecondNumber = 0;

if (number > 99 && number < 1000) 
{
    findedSecondNumber = GetSecondNumber(number);
}
else 
{
    Console.WriteLine("Ваше число не является трехзначным, попробуйте еще раз");
    return;
}
    
Console.WriteLine($"Вторая цифра из трехзначного числа - это {findedSecondNumber}");
*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
static int GetThirdNumber (int num) 
{
    int thirdNumber = 0;
    if (num > 99)
        {
            while (num >= 1000)
            {
                num/=10;
            }
            thirdNumber = num % 10;
        } 
    return thirdNumber;
}

int number = RetrieveInteger("Введите число: ");
int findedThirdNumber = 0;

if (number < 100) 
{
    Console.WriteLine("Ваше число не является трехзначным");
    return;
} 

findedThirdNumber = GetThirdNumber(number);
Console.WriteLine($"Третья цифра из числа - это {findedThirdNumber}");
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
static bool FindWhatDay (int num) 
{
    bool weekdayOrWeekend;
    if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
    {
        weekdayOrWeekend = false;
    }
    else 
    {
        weekdayOrWeekend = true;
    }
    return weekdayOrWeekend;
}

int number = RetrieveInteger("Введите число от 1 до 7 и мы узнаем, выходной ли это");
bool whatDay;

if (number <= 7 && number > 0) 
{
    whatDay = FindWhatDay(number);
    if (whatDay == false) 
        {
            Console.WriteLine("Нет, у вас будний день");
        } 
    else
        {
            Console.WriteLine("Да, у вас выходной");
        }
}
else 
{
    Console.WriteLine("Вы ввели недопустимое число, попробуйте еще раз");
    return;
}
*/