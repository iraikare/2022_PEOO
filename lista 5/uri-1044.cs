using System;

public class Program {

  public static void Main(string[] args) {
    string abf = Console.ReadLine();
    string [] ab = abf.Split();
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    int c = Math.Max(a,b) % Math.Min(a,b);
    if (c==0) Console.WriteLine("Sao Multiplos");
    else Console.WriteLine("Nao sao Multiplos");
  }
}