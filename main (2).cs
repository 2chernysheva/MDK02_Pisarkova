/******************************************************************************


Проверить соотношение: arcsin(1%2)=30 градусов;
Писарькова Богдана 22ИС-21


*******************************************************************************/
using System;
class HelloWorld 
{
  static void Main(string[] args)
  {
      double a = 0.5;
      double b = Math.Round(Math.Asin(a));
      double y = Math.Round(Math.Sin(30*3.14/180));
      
    Console.WriteLine(b);
    Console.WriteLine(y);
  }
}