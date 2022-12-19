// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

int number = new Random().Next(0, 1000);
System.Console.WriteLine($"Ранодомное число равно {number}");

if (number % 7 == 0 && number % 23 == 0) System.Console.WriteLine($"{number} -> да");
else System.Console.WriteLine($"{number} -> нет");
System.Console.WriteLine($"Число {number} делится на 7 с остатком {number % 7}");
System.Console.WriteLine($"Число {number} делится на 23 с остатком {number % 23}");

// for (int i = 23; i < 1000; i+=23)   // 161 322 483 644 805 966
// {
//     if (i % 7 == 0) System.Console.Write($"{i} ");
// }  