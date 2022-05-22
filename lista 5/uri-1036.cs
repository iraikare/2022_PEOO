using System;

public class Program {

  public static void Main(string[] args) {
    string valores = Console.ReadLine();
    string [] valoresf = valores.Split();
    double a = double.Parse(valoresf[0]);
    double b = double.Parse(valoresf[1]);
    double c = double.Parse(valoresf[2]);
    double r1 = (-b + Math.Sqrt(Math.Pow(b,2)-4*a*c))/(2*a);
    double r2 = (-b - Math.Sqrt(Math.Pow(b,2)-4*a*c))/(2*a);
    if (a == 0.0 || (Math.Pow(b,2)-4*a*c)<0.0) Console.WriteLine("Impossivel calcular");
    else{
      Console.WriteLine($"R1 = {r1:0.00000}");
      Console.WriteLine($"R2 = {r2:0.00000}");
    }
  }
}