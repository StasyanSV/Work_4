// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите целое число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите целое число B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {A} в натуральной степени числа {B} равно {Gen(A,B)}");


int Gen(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }

    return result;
}