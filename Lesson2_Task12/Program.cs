// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = EnterNumber("Введите первое число");
        int number2 = EnterNumber("Введите второе число");



        if (number1 % number2 == 0) Console.WriteLine($"{number1}, {number2} -> кратно");
        else Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {number1 % number2} ");



        ////////
        // int number4 = new Random().Next(10, 100);
        // Console.WriteLine($"Рандомное число №1: {number4}");
        // int number5 = new Random().Next(1, 10);
        // Console.WriteLine($"Рандомное число №2: {number5}");

        // if (number4 % number5 == 0)
        //     Console.WriteLine($"Число {number4} делится на число {number5} без остатка");
        // else Console.WriteLine($"Число {number4} не делится на число {number5} без остатка, остаток {number4 % number5}");
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