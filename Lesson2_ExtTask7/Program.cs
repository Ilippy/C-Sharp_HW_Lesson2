// Выводится название предмета по введенной первой букве: ф - физика, м -
// математика, и - история, г - география, б - биология (оператор switch).

internal partial class Program
{
    private static void Main(string[] args)
    {

        char ch = EnterChar("Введите символ из этого массива ['ф', 'м', 'и', 'г','б']");
        PrintSubject(ch);
    }


    static char EnterChar(string str)
    {
        System.Console.WriteLine(str);
        char[] arrayChar = { 'ф', 'м', 'и', 'г', 'б' };
        char ch = Char.ToLower(Console.ReadLine()![0]);
        while (!arrayChar.Contains(ch))
        {
            System.Console.WriteLine($"Ошибка! {str}");
            ch = Char.ToLower(Console.ReadLine()![0]);
        }
        return ch;
    }

    static void PrintSubject(char ch)
    {
        switch (ch)
        {
            case 'ф':
                System.Console.WriteLine($"{ch} - Физика");
                break;
            case 'м':
                System.Console.WriteLine($"{ch} - Математика");
                break;
            case 'и':
                System.Console.WriteLine($"{ch} - История");
                break;
            case 'г':
                System.Console.WriteLine($"{ch} - География");
                break;
            case 'б':
                System.Console.WriteLine($"{ch} - Биология");
                break;
            default:
                System.Console.WriteLine($"Error! Char - {ch}");
                break;
        }
    }
}