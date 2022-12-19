// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// string stringNumber = Console.ReadLine().Trim();
// System.Console.WriteLine($"{stringNumber} -> {stringNumber[0]}{stringNumber[2]}");
// string n ='123';
// n[0] = '1';
// n[1] = '2';
// n[2] = '3';

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {number}");
Console.WriteLine(number / 100 * 10 + number % 10);
