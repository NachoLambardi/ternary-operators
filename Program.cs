using System;

namespace TernaryOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      // You bought a new car. It needs a CAR SERVICE after the first 5000 miles.// 
      
      double carMiles = 5000;

      string message = (carMiles <= 5000)  ? "You're car looks like a new one!" : "You need to get your car to the Service or you'll lose the warranty!"; 

      Console.WriteLine(message);
    }
  }
}
