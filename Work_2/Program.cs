// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите целое число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Сумма цифр числа {N} равна {Gen(N)} ");

int Gen(int N)
{
    int result = 0;
    int C = 0;

    while (N > 0)
    {
        C = N % 10;
        N = N / 10;
        result += C;
    }

    return result;
}