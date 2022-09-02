using System;

public class Program {
  public static double Menor(double x, double y){
    if (x < y) return x;
    else return y;
    // return x < y ? x : y;
  }

  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(a,b));
  }
}