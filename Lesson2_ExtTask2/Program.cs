// Генерируются два случайных целых числа a и b в интервале [10 – 30].
// Если a > b, выводится их разность, eсли a < b, выводится сумма,
// eсли a == b, выводится сообщение “числа равны”. (оператор if)

internal partial class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int a = random.Next(10, 31);
        int b = random.Next(10, 31);

        if (a > b) System.Console.WriteLine($"{a} - {b} = {a - b}");
        else if (a < b) System.Console.WriteLine($"{a} + {b} = {a + b}");
        else System.Console.WriteLine($"Числа {a} и {b} равны");
    }
}