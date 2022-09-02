using System;

public class Program {
  public static double AreaCirculo(double raio){
    double area = 3.14 * (raio*raio);
    return area;
  }

  public static void Main(string[] args) {
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(x));
  }
}