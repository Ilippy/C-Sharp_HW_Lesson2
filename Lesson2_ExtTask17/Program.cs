// Генерируется 10 случайных чисел в интервале (– 20, 20). Выводятся только
// положительные числа и сообщения: четное - нечетное

internal partial class Program
{
    private static void Main(string[] args)
    {
        ShowRandomNumbers(10);
    }

    static void ShowRandomNumbers(int n)
    {
        Random random = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-20, 21);
            if (array[i] > 0)
            {
                System.Console.Write($"Число {array[i]} ");
                if (array[i] % 2 == 0) System.Console.Write("четное\n");
                else System.Console.Write("нечетное\n");
            }
        }
    }
}