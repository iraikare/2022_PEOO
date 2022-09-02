using System;

public class Program {
  public static double VolumeEsfera(double r){
    double volume = 4.0/3.0 * 3.14 * Math.Pow(r,3);
    return volume;
  }
  public static void Main(string[] args) {
    double raio = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(raio));
  }
}