using System;

class  PingPong
{
  static void Main()
  {
    Console.WriteLine("Please enter a number:");
    int userInput = int.Parse(Console.ReadLine());
    for (int i = 0; i <= userInput; i++)
    {
      Console.WriteLine(i);
    }
  }
}
