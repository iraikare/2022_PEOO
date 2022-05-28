using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite dois valores inteiros");
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    if (valor1>valor2) Console.WriteLine($"Maior = {valor1}");
    if (valor1<valor2) Console.WriteLine($"Maior = {valor2}");
    if (valor1==valor2) Console.WriteLine($"Números iguais");
  }
}