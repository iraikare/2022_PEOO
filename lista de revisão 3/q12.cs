using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase: ");
    string s = Console.ReadLine();
    string[] sf = s.Split(' ');
    int x = sf.Length;
    Console.WriteLine(x);
  }
}