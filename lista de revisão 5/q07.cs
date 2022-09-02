using System;

public class Program {
  public static void AntecessorSucessor(int x, out int antecessor, out int sucessor){
    antecessor = x-1;
    sucessor = x+1;
  }
  public static void Main(string[] args) {
    int numero = int.Parse(Console.ReadLine());
    int a;
    int b;
    AntecessorSucessor(numero, out a, out b);
    Console.WriteLine($"{a} , {b}");
  }
}