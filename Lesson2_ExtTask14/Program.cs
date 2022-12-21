// В интервале [0, 2 c] с шагом 0.1с вычисляются координаты y = V0 t – g t
// 2
// / 2
// и скорости V = V0 – g t мячика, брошеного вертикально вверх с начальной
// скоростью V0 (V0 вводится с клавиатуры, цикл for).

internal partial class Program
{
    private static void Main(string[] args)
    {
        double v0 = EnterNumber("Введите начальную скорость в км/ч");
        ShowCordinates(v0);
    }

    static double EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        double number;
        string stringNumber = Console.ReadLine()!.Trim();
        while (!double.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }


    private static void ShowCordinates(double v0)
    {
        double g = 9.80665;
        double y;
        for (double i = 0; i <= 2; i += 0.2)
        {
            y = v0 * i - g * (i * i) / 2;
            System.Console.WriteLine($"y = {Math.Round(y, 2)} в {Math.Round(i, 1)}c");
        }
    }
}