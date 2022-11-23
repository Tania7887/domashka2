// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Enter the number: ");

int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);


if (numberText.Length > 2){
  Console.WriteLine("Third digit -> " + numberText[2]);
}
else {
  Console.WriteLine("->  No third digit");
}