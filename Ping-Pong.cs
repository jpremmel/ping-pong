using System;
class  PingPong
{
  static void Main()
  {
    Console.WriteLine("Please enter a number:");
    int userInput = int.Parse(Console.ReadLine());
    for (int i = 1; i <= userInput; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("PING-PONG");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("PING");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("PONG");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}
