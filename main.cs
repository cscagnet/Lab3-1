using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    var celsius = Console.ReadLine();
    double temp = Convert.ToInt32(celsius); 
    double farenheit = (temp * 9 / 5) + 32;
    Console.WriteLine ("Farenheit equivilant for " + temp + " degrees in celsius is " + farenheit);
    if (farenheit < 32)
  {
    Console.WriteLine("This temperature is below freezing temperature of 32 degrees farenheit");
  }
  if (farenheit > 212)
  {
    Console.WriteLine("This temperature is above boiling temperature of 212 degrees farenheit");
  }
  else
  {

  }

  




    

  }
}