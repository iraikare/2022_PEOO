using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase: ");
    string s = Console.ReadLine();
    int i = 1;
    int x = s.Length;
    while(i<=x){
      Console.WriteLine($"{i} - {s}");
      i++;
    }
  }
}