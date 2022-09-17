/* Задача 64: Задайте значения M и N.
 Напишите программу, которая выведет 
 все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
 */

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
Natural(n, count);


void Natural(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Natural(n, count + 1);
        Console.Write(count + " ");
    }
}
/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m = Natural("Введите M: ");
int n = Natural("Введите N: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp=0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int Natural(string a) 
{
  Console.Write(a);
  int b = int.Parse(Console.ReadLine());
  return b;
}

/* Задача 68: Напишите программу вычисления функции
 Аккермана с помощью рекурсии. Даны два 
 неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9 */


Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
AkkermanFunction(m,n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}