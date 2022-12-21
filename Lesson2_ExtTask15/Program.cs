// Повторяются вычисления и вывод площади круга по вводимому радиусу r
// до тех пор, пока не введена буква z или Z .

internal partial class Program
{
    private static void Main(string[] args)
    {
        do {
        float r = EnterNumber("Введите радиус круга");
        ShowCircleArea(r);
        System.Console.WriteLine("Нажмите Z чтобы завершить программу или любую клавишу, чтобы продолжить");
        } while (Console.ReadKey(true).Key != ConsoleKey.Z);
    }


    static float EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        float number;
        string stringNumber = Console.ReadLine()!.Trim();
        while (!float.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static void ShowCircleArea(float r){
        System.Console.WriteLine($"Площадь круга с радиусом {r} равна {3.14 * r * r}");
    }

}