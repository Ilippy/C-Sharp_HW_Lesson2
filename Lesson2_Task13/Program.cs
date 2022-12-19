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
        // string stringNumber = Console.ReadLine().Trim;
        // ShowThirdDigit(stringNumber);
        int number = EnterNumber("Введите одно число");
        ShowThirdDigit(number);
         

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

    static void ShowThirdDigit(int number){
        int increment = number < 0 ? 1 : 0;
        string str = number.ToString();
        System.Console.WriteLine(str.Length < 3 + increment ? $"{str} -> третьей цифры нет" : 
            $"{str} -> {str[2 + increment]}");
    }

    #endregion
}