// Генерируются два случайных целых числа c и d в интервале [-10 – 10].
// Если оба числа четные, выводится их частное, если оба нечетные - их сумма,
// если одно число четное, а другое нечетное, выводится их произведение ( if ),

internal partial class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int c = random.Next(-10, 11);
        int d = random.Next(-10, 11);

        if (c % 2 == 0 && d % 2 == 0)
            System.Console.WriteLine(c > d ? $"{c} / {d} = {c / d}" :
            $"{d} / {c} = {c / d}");
        else if (c % 2 == 1 && d % 2 == 1)
            System.Console.WriteLine($"{c} + {d} = {c + d}");
        else System.Console.WriteLine($"{c} * {d} = {c * d}");

    }
}