﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.




Console.Write("Enter the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(day off) -> yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("not day of week");
  }
  else Console.WriteLine("(not a day off) -> no");
}

CheckingTheDayOfTheWeek(dayNumber);