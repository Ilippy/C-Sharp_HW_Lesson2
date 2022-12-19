// По введенному номеру выводится название дня недели (1 – пн, 2 –вт,...)
// и сообщение “рабочий день” или “выходной” (операторы switch, if).

internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите целое число от 1 до 7");
        PrintWeekDay(number);
    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number < 1 || number > 7)
        {
            Console.WriteLine("Ошибка! Введите одно целое число от 1 до 7");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }


    static void PrintWeekDay(int number)
    {
        string str;
        if (number > 0 && number <= 5) str = "рабочий день";
        else str = "выходной";

        switch (number)
        {
            case 1:
                System.Console.WriteLine($"{number} - Понедельник {str}");
                break;
            case 2:
                System.Console.WriteLine($"{number} - Вторник {str}");
                break;
            case 3:
                System.Console.WriteLine($"{number} - Среда {str}");
                break;
            case 4:
                System.Console.WriteLine($"{number} - Четверг {str}");
                break;
            case 5:
                System.Console.WriteLine($"{number} - Пятница {str}");
                break;
            case 6:
                System.Console.WriteLine($"{number} - Суббота {str}");
                break;
            case 7:
                System.Console.WriteLine($"{number} - Воскресенье {str}");
                break;
            default:
                System.Console.WriteLine("Ошибка");
                break;
        }
    }
}