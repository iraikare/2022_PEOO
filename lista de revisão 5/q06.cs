using System;

public class Program {
  public static double Frete(double massa, double distancia){
    double frete = (massa * distancia) / 100.00;
    return frete;
  }
  public static void Main(string[] args) {
    double massa1 = double.Parse(Console.ReadLine());
    double distancia1 = double.Parse(Console.ReadLine());
    Console.WriteLine(Frete(massa1, distancia1));
  }
}