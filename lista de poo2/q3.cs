using System;

public class Program {
  public static void Main(string[] args) {
    Viagem x = new Viagem();
    Console.WriteLine("Digite uma distância:");
    x.SetDistancia(double.Parse(Console.ReadLine())); 
    Console.WriteLine("Digite um tempo:");
    x.SetTempo(double.Parse(Console.ReadLine())); 
    Console.WriteLine($"velocidade media = {x.VelocidadeMedia()} km/h");
  }
}

public class Viagem{
  private double distancia;
  private double tempo;
  public void SetDistancia(double d){
    if (d > 0) distancia = d;
  }
  public void SetTempo(double t){
    if (t > 0) tempo = t;
  }
  public double GetDistancia(){
    return distancia;
  }
  public double GetTempo(){
    return tempo;
  }
  public double VelocidadeMedia(){
    double resul = distancia/tempo;
    return resul;
  }
}