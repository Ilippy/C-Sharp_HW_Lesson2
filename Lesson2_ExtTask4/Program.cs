// По введенному номеру месяца выводится название поры года (зима, весна,
// лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр ( if ).

// январь и июнь сессия, июль, август каникулы, с сентября по декабрь 1 семестр, с февраля по май 2 семестр

internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите номер месяца");
        TimeToStudy(number);
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

    static void TimeToStudy(int i)
    {

        if (i == 1) System.Console.WriteLine($"{i} -> Зима и сессия");
        else if (i == 2) System.Console.WriteLine($"{i} -> Зима и 2 семестр");
        else if (i >= 3 && i <= 5) System.Console.WriteLine($"{i} -> Осень и 2 семестр");
        else if (i == 6) System.Console.WriteLine($"{i} -> Лето и сессия");
        else if (i == 7 || i == 8) System.Console.WriteLine($"{i} -> Лето и каникулы");
        else if (i >= 9 && i <= 11) System.Console.WriteLine($"{i} -> Весна и 1 семестр");
        else if (i == 12) System.Console.WriteLine($"{i} -> Зима и 1 семестр");
        else System.Console.WriteLine($"{i} -> не месяц");
    }
}