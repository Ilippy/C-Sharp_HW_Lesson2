// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет




internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = EnterNumber("Введите первое число");
        int number2 = EnterNumber("Введите второе число");

        if (number1 == number2 * number2 || number1 * number1 == number2)
            System.Console.WriteLine($"{number1}, {number2} -> да");
        else System.Console.WriteLine($"{number1}, {number2} -> нет");


    }

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
}