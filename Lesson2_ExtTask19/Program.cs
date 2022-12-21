// Генерируются случайные числа в интервале (0, 20) до тех пор,
// пока их сумма не превысит S (вводится с клавиатуры).
// Нумеруются и выводятся эти числа и их сумма ( while, if ).

internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите сумму рандомных чисел");
        ShowRandomNumbers(number);
    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        int number;
        string stringNumber = Console.ReadLine()!.Trim();
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void ShowRandomNumbers(int end)
    {
        Random random = new Random();
        int number, i = 1, sum = 0;
        while (sum < end)
        {
            number = random.Next(0, 21);
            sum += number;
            System.Console.WriteLine($"{i} -> число {number}, сумма = {sum}");
            i++;
        }
    }
}