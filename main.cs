/******************************************************************************

Вариант №24
Лабораторная работа 3.
Писарькова Богдана 22ИС-21

*******************************************************************************/
using System;
class Program
{
static void Main(string[] args)
{
double x = 1.0; // здесь указываем значение переменной x
double a = 2.0; // здесь указываем значение переменной a
double sum = 0.0; // переменная для хранения суммы ряда
double term = 0.0; // переменная для хранения текущего члена ряда
int n = 1; // счетчик номера члена ряда

do
{
term = (n * x + Math.Pow(a, 2 * n - 1)) / Math.Pow(Math.Sin(a + x), n);
sum += term;
n++;
} while (Math.Abs(term) > 1e-6); // продолжаем вычисления, пока текущий член ряда не станет достаточно маленьким

Console.WriteLine("Сумма ряда: " + sum);
Console.ReadLine();
}
}