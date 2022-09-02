using System;

public class Program {
  public static double Diagonal(double b, double h){
    double diagonal = Math.Sqrt((b*b)+(h*h));
    return diagonal;
  }

  public static void Main(string[] args) {
    double baseh = double.Parse(Console.ReadLine());
    double altura = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(baseh,altura));
  }
}