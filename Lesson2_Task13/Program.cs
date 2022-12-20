// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679[2] -> 6
// -35 -> третьей цифры нет

internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите одно число");
        ShowThirdDigit(number);
        ShowThirdDigitSecondSolution(number);
        ShowThirdDigitThirdSolution(number);


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

    static void ShowThirdDigit(int number)
    {
        int increment = number < 0 ? 1 : 0;
        string str = number.ToString();
        System.Console.WriteLine(str.Length < 3 + increment ? $"{str} -> третьей цифры нет" :
            $"{str} -> {str[2 + increment]}");
    }

    static void ShowThirdDigitSecondSolution(int number)
    {
        int result = number;
        if (number < 0) result *= -1;
        int numberDigits = (int)Math.Floor(Math.Log10(result) + 1);
        if (numberDigits >= 3)
        {
            result = result / (int)Math.Pow(10, numberDigits - 3) % 10; // dunno why result /= don't work here
            System.Console.WriteLine($"{number} -> {result}");
        }
        else System.Console.WriteLine($"{number} -> третьей цифры нет");
    }

    static void ShowThirdDigitThirdSolution(int number)
    {
        int result = number;
        if (result < 0) result *= -1;
        if (result >= 100)
        {
            while (result > 999)
            {
                result /= 10;
            }
            result %= 10;
            System.Console.WriteLine($"{number} -> {result}");
        }
        else System.Console.WriteLine($"{number} -> третьей цифры нет");
    }
    #endregion
}