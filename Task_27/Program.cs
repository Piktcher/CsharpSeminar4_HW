// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum (int number)
{
    int result = 0;
    while (number != 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}

Console.Write("Введите число для расчета суммы его цифр, ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = DigitSum(num);
Console.WriteLine("Сумма цифр введенного числа равна " + sum);