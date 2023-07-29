// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter num1 : ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);
Console.WriteLine("Enter num2 : ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);
if (num1 > num2)
{
    Console.WriteLine($"{num1}>{num2}     Большее число {num1}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num1}<{num2}     Большее число {num2}");
}
else 
{
    Console.WriteLine($"{num1}={num2} Числа равны");
}