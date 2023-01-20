// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSum(int M, int N)
{
    if (N < M) return 0;
    return N + PrintSum(M, N - 1);
}




Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());

if (N > M) Console.WriteLine(PrintSum(M, N));
else Console.WriteLine("Второе число меньше первого.");

