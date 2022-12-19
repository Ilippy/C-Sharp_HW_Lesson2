// Проверяется правильность введенного логина строго из 5 букв
// и пароля из 6 и более цифр.

internal partial class Program
{
    private static void Main(string[] args)
    {
        string login = EnterLogin("Введите логин из 5 букв");
        int password = EnterPassword("Введите более 6 цифр");

        System.Console.WriteLine($"Ваш логин '{login}' и Ваш пароль '{password}'");
    }

    static string EnterLogin(string str)
    {
        Console.WriteLine(str);
        string log = Console.ReadLine()!.Trim();
        while (log.Length != 5)
        {
            System.Console.WriteLine("Ошибка " + str);
            log = Console.ReadLine()!.Trim();
        }
        return log;
    }

    //Math.Floor(Math.Log10(n) + 1) = n.ToString.Length
    static int EnterPassword(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || Math.Floor(Math.Log10(number) + 1) < 6)
        {
            Console.WriteLine("Ошибка! " + str);
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }
}