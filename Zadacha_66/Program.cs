/*Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SummaElementsMinMax(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + SummaElementsMinMax(m + 1, n);
}

int SummaElementsMaxMin(int m, int n)
{
    if (m > n)
    {
        return m + SummaElementsMaxMin(m - 1, n);
    }
    return n;
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= n)
{
    Console.Write("\nСумма элементов от M до N равна " + SummaElementsMinMax(m, n));
}

if (m > n)
{
    Console.Write("\nСумма элементов от M до N равна " + SummaElementsMaxMin(m, n));
}
