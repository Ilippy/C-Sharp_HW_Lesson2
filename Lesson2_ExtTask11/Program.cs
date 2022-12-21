// Вычисляется сумма всех нечетных натуральных чисел от n1 до n2 включительно
// (n1 и n2 вводятся с клавиатуры, цикл for).


internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = EnterNumber("Введите первое целое число");
        int number2 = EnterNumber("Введите второе целое число");

        ShowSumOddNumbers(number1, number2);

    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void ShowSumOddNumbers(int number1, int number2)
    {
        int start, end;
        int sum = 0;
        if (number1 < number2)
        {
            start = number1;
            end = number2;
        }
        else
        {
            start = number2;
            end = number1;
        }
        for (int i = start; i <= end; i++)
        {
            if (i > 0 && i % 2 == 1)
                sum += i;
            System.Console.WriteLine($"i = {i}, sum = {sum}");
        }
        System.Console.WriteLine($"Сумма всех нечетных натуральных чисел от {start} до {end} равно {sum}");
    }
}