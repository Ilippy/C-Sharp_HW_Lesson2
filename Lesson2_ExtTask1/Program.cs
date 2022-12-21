// Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d
// (используйте тернарный оператор).


// Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d
// (используйте тернарный оператор).


internal class Program
{
    private static void Main(string[] args)
    {
        int number = new Random().Next(20, 100);
        System.Console.WriteLine($"Рандомное число {number}");
        int d = EnterNumber("Введите целое число не равное 0");

        System.Console.WriteLine(number % d == 0 ? $"Число {number} делится на число {d} без остатка" :
            $"Число {number} делится на число {d} с остатком {number % d}");

    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number == 0)
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }
}