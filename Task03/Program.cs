// Программа выводит случайное число из [10, 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);

int number1 = number/10;
int number2 = number%10;

Console.WriteLine($"number = {number}");


if (number1 > number2)
{
     Console.WriteLine($"number1 {number1} bigger then number2 {number2}");
}


else 
if (number1 < number2)
{
     Console.WriteLine($"number2 {number2} bigger then number1 {number1}");
}

else 
{
     Console.WriteLine($"number1 {number1} equal number2 {number2}");
}