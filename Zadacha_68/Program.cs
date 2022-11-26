/*Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
            n + 1,              если m = 0;
A(m, n) =   A(m-1, 1),          если m>0, n=0;
            A(m-1, A(m, n-1)),  если m>0, n>0.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0)
{
    Console.WriteLine("\nВведенные значения не должны быть меньше 0!!!!! ");
    Console.WriteLine("Введите корректное значение M:");
    m = Convert.ToInt32(Console.ReadLine());
}

if (n < 0)
{
    Console.WriteLine("\nВведенные значения не должны быть меньше 0!!!!! ");
    Console.WriteLine("Введите корректное значение N:");
    n = Convert.ToInt32(Console.ReadLine());
}

if (m >= 0 || n >= 0)
{
    Console.Write("\nЗначение функции Аккермана равно " + Akkerman(m, n));
}




