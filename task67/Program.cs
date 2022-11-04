/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
/*
Задача 65: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
Console.WriteLine("Введите число M");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int userNumberN = Convert.ToInt32(Console.ReadLine());
GetSum(userNumberM, userNumberN);
void GetSum(int Start, int End)
{
    if (Start == End) 
    {
        Console.Write($"{End}, ");
        return;
    }

    GetSum(Start, End - 1);
    Console.Write($"{End}, ");
}

