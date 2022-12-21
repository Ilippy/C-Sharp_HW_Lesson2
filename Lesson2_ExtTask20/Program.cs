// Ежедневно количество бактерий увеличивается на p процентов.
// Через сколько дней количество бактерий увеличится в n раз (ввод p и n ).

internal partial class Program
{
    private static void Main(string[] args)
    {
        double p = EnterNumber("Введите количество увеличения бактерий каждый день в процентах");
        double n = EnterNumber("Введите в сколько раз нужно увеличить бактерии");

        ShowBacteriaPerDay(p, n);
    }

    static double EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        double number;
        string stringNumber = Console.ReadLine()!.Trim();
        while (!double.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void ShowBacteriaPerDay(double p, double n)
    {
        double bacteria = 1, res = 1;
        int i = 1;
        while (res <= bacteria * n)
        {
            res += res * p / 100; 
            System.Console.WriteLine($"День {i}, бактерии {Math.Round(res, 2)}");
            i++;
        }
        System.Console.WriteLine($"Нужно {i} дней, чтобы увеличить количество бактерий в {n} раз с шагом {p}%");
    }
}