// Введенная цифра (от 0 до 5) выводится прописью (оператор switch).

internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число от 0 до 5");
        PrintNumber(number);
    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number < 0 || number > 5)
        {
            Console.WriteLine("Ошибка! Введите одно целое число от 0 до 5");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void PrintNumber(int number)
    {
        switch (number)
        {
            case 0:
                System.Console.WriteLine("Ноль");
                break;
            case 1:
                System.Console.WriteLine("Один");
                break;
            case 2:
                System.Console.WriteLine("Два");
                break;
            case 3:
                System.Console.WriteLine("Три");
                break;
            case 4:
                System.Console.WriteLine("Четыре");
                break;
            case 5:
                System.Console.WriteLine("Пять");
                break;
            default:
                System.Console.WriteLine("Ошибка");
                break;
        }
    }
}