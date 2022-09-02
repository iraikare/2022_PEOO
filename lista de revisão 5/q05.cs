using System;

public class Program {
  public static double VolumeLitros(double h, double l, double p){
    double volume = h * l * p;
    return volume;
  }
  public static void Main(string[] args) {
    double altura = double.Parse(Console.ReadLine());
    double largura = double.Parse(Console.ReadLine());
    double profundidade = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeLitros(altura, largura, profundidade));
  }
}