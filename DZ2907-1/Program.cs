// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Enter 3 numbers
Console.WriteLine("Enter num1 : ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.WriteLine("Enter num2 : ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

Console.WriteLine("Enter num1 : ");
string strNum3 = Console.ReadLine();
int num3 = int.Parse(strNum3);
// Create array
int[] anArray = { num1, num2, num3 };
// Finding max
int m = anArray.Max();

Console.WriteLine($"Максимальное число  {m}");