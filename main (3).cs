/******************************************************************************

Вариант №24
Практическое заданиие 2.
Писарькова Богдана 22ИС-21

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите текущую дату в формате dd.MM.yyyy:");
    DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
    Console.WriteLine("Введите количество дней, на которое нужно увеличить дату:");
    int daysToAdd = int.Parse(Console.ReadLine());
    DateTime newDate = currentDate.AddDays(daysToAdd);
    Console.WriteLine("Дата через " + daysToAdd + " дней: " + newDate.ToString("dd.MM.yyyy"));
    }
}
