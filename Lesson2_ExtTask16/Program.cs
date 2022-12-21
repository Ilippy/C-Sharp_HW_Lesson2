// Генерируется 8 случайных чисел в интервале (– 30, 30). Выводятся эти числа
// и сообщения: отрицательное – положительное, четное – нечетное ( for, if ).
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = GenerateNumbers(8);
        ShowArray(array);
    }


    static int[] GenerateNumbers(int arrayLength)
    {
        Random random = new Random();
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
            array[i] = random.Next(-30, 31);
        return array;
    }

    static void ShowArray(int[] array)
    {
        foreach (int number in array)
        {
            System.Console.Write($"Число {number} ");
            if (number < 0) System.Console.Write("отрицательное, ");
            else System.Console.Write("положительное, ");
            if (number % 2 == 0) System.Console.Write("четное\n");
            else System.Console.Write("нечетное\n");
        }

    }
}