// Вычисляется и выводится в таблицу с шагом 10 км стоимость поездки
// на автомобиле в зависимости от расстояния S (10 – 90 км). С клавиатуры
// вводятся: b - расход бензина на 100 км, c - цена бензина за 1л литр. (цикл for)

internal partial class Program
{
    private static void Main(string[] args)
    {
        int S = 90;
        float b = EnterNumber("Введите расход бензина на 100 км");
        float c = EnterNumber("Введите цену бензина за литр в рублях");

        ShowSumGasCost(S, b, c);
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

    static void ShowSumGasCost(int S, float b, float c)
    {
        float result = 0;
        for(int i = 10; i <= S; i= i + 10){
            result += b/10 * c;
            System.Console.WriteLine($"Вы проехали {i} км и вы потратили {result} рублей за бензин");
        }
    }
}