// Генерируются случайные числа в интервале (– 40, 40) до тех пор,
// пока очередное число не превышает 30. Выводятся только нечетные числа
// и сообщения: отрицательное – положительное ( while, if ).

internal partial class Program
{
    private static void Main(string[] args)
    {
        ShowRandomNumbers();
    }

    static void ShowRandomNumbers()
    {
        Random random = new Random();
        int number;
        while (true)
        {
            number = random.Next(-40, 40);
            //System.Console.WriteLine($"{number} -> {number%2}");
            if (Math.Abs(number) % 2 == 1)
            {
                System.Console.Write($"Число {number} ");
                if (number < 0) System.Console.Write("отрицательное\n");
                else System.Console.Write("положительное\n");
            }
            if (number > 30)
            {
                System.Console.WriteLine($"Выход из цикла, потому что число {number} больше 30");
                break;
            }
        }
    }
}