// Проверяется соответствие веса и роста (ввод рост и вес; вывод одного
// из сообщений "Норма", "Нужно похудеть", "Нужно поправиться".
// Нормальный вес (в кг) = (рост (в см) – 100) ± 10%. (оператор if )

internal partial class Program
{
    private static void Main(string[] args)
    {
        int weight = EnterNumber("Введите Ваш вес в кг");
        int height = EnterNumber("Введите Ваш рост в сантиметрах");

        BodyShame(weight, height);
    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine("Ошибка! Введите одно целое число");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void BodyShame(int weight, int height)
    {
        int n = height - 100;
        if (weight >= n - n / 10 && weight <= n + n / 10) 
            System.Console.WriteLine($"При росте {height}кг и весе {weight} - Норма");
        else if(weight < n - n/10) System.Console.WriteLine($"При росте {height}кг и весе {weight} - Нужно поправиться");
        else if(weight > n - n/10) System.Console.WriteLine($"При росте {height}кг и весе {weight} - Нужно похудеть");
        else System.Console.WriteLine($"Error! Weight = {weight} and height = {height}");
    }
}