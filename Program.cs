//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
string numberFirst = Console.ReadLine() ??"";
int number1 = int.Parse(numberFirst);
int result1 = number1;

Console.WriteLine("Введите второе число число");
string numberSecond = Console.ReadLine();
int number2 = int.Parse(numberSecond);
int result2 = number2;

Console.WriteLine("Введите третье число число");
string numberThird = Console.ReadLine();
int number3 = int.Parse(numberThird);
int result3 = number3;

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"число {number1} максимльное");
}
if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"число {number2} максимльное");
}
if (number3 > number1 && number3 > number2)
    Console.WriteLine($"число {number3} максимльное");