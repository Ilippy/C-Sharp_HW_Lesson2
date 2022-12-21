// Вычисляется сумма квадратов n натуральных чисел, начиная с k
// (вводятся k и n, цикл for).

// n = 5
// k = 3
// result = 3*3 + 4*4 + 5*5 + 6*6 + 7*7 

// n = 7
// k = -3
// result = (-3*-3 + -2*-2 + -1*-1 + 0*0 )*0 + 1*1 + 2*2 + 3*3

internal partial class Program
{
    private static void Main(string[] args)
    {
        int k = EnterNumber("Введите целое число");
        int n = EnterNumber("Введите целое число больше 0", true);

        SumSquaresNaturalNumbers(k, n);

    }

    static int EnterNumber(string str, bool isN = false)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || isN ? number <= 0 : false)
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void SumSquaresNaturalNumbers(int k, int n)
    {
        int sum = 0;
        for (int i = k; i <= k + n; i++)
        {
            if (i > 0) sum = sum + i * i;
            System.Console.WriteLine($"i = {i}, sum = {sum}");
        }
        System.Console.WriteLine($"сумма квадратов {n} натуральных чисел, начиная с {k} равна {sum}");
    }
}