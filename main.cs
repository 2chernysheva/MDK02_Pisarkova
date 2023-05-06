/******************************************************************************

Вариант №24
Практическая задание 3.
Писарькова Богдана 22ИС-21

*******************************************************************************/
using System;

class Program
{
static void Main(string[] args)
{
double alpha = 1.0; // здесь указываем значение переменной alpha
double beta0 = 0.0; // здесь указываем начальное значение переменной beta
double betax = 1.0; // здесь указываем конечное значение переменной beta
double deltaBeta = 0.1; // здесь указываем шаг изменения переменной beta

for (double beta = beta0; beta <= betax; beta += deltaBeta)
{
double w = (Math.Cos(Math.Pow(alpha, 2)) + Math.Sin(alpha + beta)) / Math.Sqrt(Math.Pow(beta, 3) + Math.Tan(beta));
Console.WriteLine("При beta = " + beta + " значение W равно " + w);
}

Console.ReadLine();
}
}

