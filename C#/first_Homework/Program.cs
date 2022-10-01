// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Решение без учета ввода пользователем иных типов данных 
// Console.Write("Введите первое число: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

//Решение с учетом ввода пользователем иных типов данных
/*
Console.WriteLine("Введите два неравных друг другу целых числа");
if(int.TryParse(Console.ReadLine(), out var firstNumber))
{
Console.WriteLine($"Хорошо, ваше число {firstNumber}");
}
else
{
Console.WriteLine("Ввод не является целым числом");
}
if(int.TryParse(Console.ReadLine(), out var secondNumber))
{
Console.WriteLine($"Отлично, ваше число {secondNumber}");
}
else
{
Console.WriteLine("Ввод не является целым числом");
}

if (firstNumber > secondNumber) 
{
    Console.WriteLine($"Большее число {firstNumber}, меньшее число {secondNumber}");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine($"Большее число {secondNumber}, меньшее число {firstNumber}");
}
else 
{
    Console.WriteLine("Введены некорректные или равные значения, попробуйте еще разок");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Решение без учета ввода пользователем иных типов данных 
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

//Решение с учетом ввода пользователем иных типов данных

/*
Console.WriteLine("Введите три неравных друг другу целых числа");
if(int.TryParse(Console.ReadLine(), out var firstNumber))
{
Console.WriteLine($"Хорошо, ваше число {firstNumber}");
}
else
{
Console.WriteLine("Ввод не является целым числом");
}
if(int.TryParse(Console.ReadLine(), out var secondNumber))
{
Console.WriteLine($"Отлично, ваше число {secondNumber}");
}
else
{
Console.WriteLine("Ввод не является целым числом");
}
if(int.TryParse(Console.ReadLine(), out var thirdNumber))
{
Console.WriteLine($"Замечательно, ваше число {thirdNumber}");
}
else
{
Console.WriteLine("Ввод не является целым числом");
}

if (firstNumber > secondNumber && firstNumber > thirdNumber) 
{
    Console.WriteLine($"Максимальное число {firstNumber}");
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine($"Максимальное число {secondNumber}");
}
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine($"Максимальное число {thirdNumber}");
}
else 
{
    Console.WriteLine("Введены некорректные или равные значения, попробуйте еще разок");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Решение без учета ввода пользователем иных типов данных 
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//Решение с учетом ввода пользователем иных типов данных

/*
Console.WriteLine("Введите целое число");
if(int.TryParse(Console.ReadLine(), out var number))
{
Console.WriteLine($"Хорошо, ваше число {number}");
}
else
{
Console.WriteLine("Ввод не является целым числом, повторите еще раз");
return;
}

if (number % 2 == 0) 
{
    Console.WriteLine($"{number} - четное число");
}
else if (number % 2 == 1)
{
    Console.WriteLine($"{number} - не является четным числом");
}
else 
{
    Console.WriteLine("Введено некорректное значение, попробуйте еще разок");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Решение без учета ввода пользователем иных типов данных 
// Console.Write("Введите положительное целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

//Решение с учетом ввода пользователем иных типов данных

/*
Console.WriteLine("Введите положительное целое число");
if(int.TryParse(Console.ReadLine(), out var n))
{
Console.WriteLine($"Хорошо, ваше число {n}");
}
else
{
Console.WriteLine("Ввод не является целым числом, повторите еще раз");
return;
}

int current = 1;

while(current <= n)
{
    if(current % 2 == 0)
        {
            Console.Write(current + "; ");
        }
    current++;
}

*/