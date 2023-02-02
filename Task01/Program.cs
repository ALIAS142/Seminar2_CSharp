// Программа выводит рандомное трехзначное число и удаляет вторую цифру числа.

int number = new Random().Next (100, 1000);



Console.WriteLine($"number = {number}");

Console.WriteLine($"{number/100}{number%10}");

int result = (number/100) * 10 + (number%10);
Console.Write(result);