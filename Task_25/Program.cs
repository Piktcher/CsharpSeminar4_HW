// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumPower(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Введите число А, ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B, ");
int num2 = Convert.ToInt32(Console.ReadLine());

double powered = NumPower(num1, num2);
Console.WriteLine("Результат возведения числа А в степень В равен " + powered);
