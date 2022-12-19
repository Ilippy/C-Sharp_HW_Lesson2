﻿// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите одно целое число");
        ShowWeekEnd(number);

    }

    #region Methods
    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine("Ошибка! Введите одно целое число");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void ShowWeekEnd(int i)
    {
        switch (i)
        {
            case > 0 and <= 5:
                Console.WriteLine($"{i} -> нет");
                break;

            case 6:
            case 7:
                Console.WriteLine($"{i} -> да");
                break;
            default:
                Console.WriteLine($"{i} -> не день недели");
                break;
        }

    }
    #endregion
}