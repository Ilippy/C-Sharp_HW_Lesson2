// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

internal class Program
{
    private static void Main(string[] args)
    {
        int number = new Random().Next(100, 1000);
        System.Console.WriteLine($"Рандомное число {number}");

        // int number = EnterNumber("Введите одно трехзначное число");
        ShowSecondDigit(number);
        ShowSecondDigit(number.ToString());


    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number < 100 || number >= 1000)
        {
            Console.WriteLine("Ошибка! Введите одно трехзначное целое число");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void ShowSecondDigit(int number)
    {
        System.Console.WriteLine($"Вторая цифра числа {number} = {number / 10 % 10}");
    }

    static void ShowSecondDigit(string str)
    {
        System.Console.WriteLine($"Вторая цифра строки {str} = {str[1]}");
    }
}