// Выводится название страны и ее столицы по введенной первой букве:
// б – Беларусь, Минск, р – Россия, Москва, л –Литва, Вильнюс (switch)


internal partial class Program
{
    private static void Main(string[] args)
    {
        char ch = EnterChar("Введите символ из этого массива ['б', 'р', 'л']");
        PrintCountry(ch);
    }

    static char EnterChar(string str)
    {
        System.Console.WriteLine(str);
        char[] arrayChar = { 'б', 'р', 'л' };
        char ch = Char.ToLower(Console.ReadLine()![0]);
        while (!arrayChar.Contains(ch))
        {
            System.Console.WriteLine($"Ошибка! {str}");
            ch = Char.ToLower(Console.ReadLine()![0]);
        }
        return ch;
    }

    static void PrintCountry(char ch)
    {
        switch (ch)
        {
            case 'б':
                System.Console.WriteLine($"{ch} - Беларусь, Минск");
                break;
            case 'р':
                System.Console.WriteLine($"{ch} - Россия, Москва");
                break;
            case 'л':
                System.Console.WriteLine($"{ch} - Литва, Вильнюс");
                break;
            default:
                System.Console.WriteLine($"Error! Char - {ch}");
                break;
        }
    }

}