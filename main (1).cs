/******************************************************************************

Вариант №24
Практическое заданиие 2.
Писарькова Богдана 22ИС-21

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите значения m, n и b:");
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double npnm = Math.Pow(n, m);
    double npua = Math.Pow(n + 1, m + 1);
    double rpua = Math.Sqrt(n + 1);
    double a = npnm > n ? Math.Pow(m, 2) * npnm : 0;
    double T = 0;
    if (a != 0)
    {
        T = Math.Pow(a, 2) * npua > b ? a + b + Math.Sqrt(b) * rpua > b ? a * Math.Cos(a) * rpua - b : 0 : 0;
        
    }
    Console.WriteLine("Результат: T = " + T);
      
  }
}
