using System;

public class Program {
  public static double VelocidadeMedia(double distancia, string tempo){
    string[] x = tempo.Split(':');
    double y = double.Parse(x[0]);
    double w = double.Parse(x[1]);
    double z = double.Parse(x[2]);
    double hora = y + (w/60) + (z/3600);
    double dist = distancia/hora;
    return dist;
  }
  public static void Main(string[] args) {
    double dis = double.Parse(Console.ReadLine());
    string tem = Console.ReadLine();
    Console.WriteLine(VelocidadeMedia(dis, tem));
  }
}
