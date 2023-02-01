// Программа выводит рандомное трехзначное число и удаляет вторую цифру числа.

int number = new Random().Next (100, 1000);



Console.WriteLine($"number = {number}");

Console.Write($"{number/100} {number%10}");

