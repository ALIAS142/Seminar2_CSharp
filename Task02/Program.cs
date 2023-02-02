// Принимает два числа, выводит кратное ли второе число пепвому;
// Если нет, то выводит остаток.

Console.WriteLine("Enter number one :");
string strnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strnumberA);


Console.WriteLine("Enter numbertwo:");
string strnumberB = Console.ReadLine();
int numberB = Convert.ToInt32(strnumberB);

int result = numberA%numberB;

if (numberA%numberB == 0)
{
     Console.WriteLine("Multiple");
}

else
 {
    Console.WriteLine($"Not multiple, {result}");
 }
