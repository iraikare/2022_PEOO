using System;

public class Program {
  public static string Senha(string texto){
    string[] x = texto.Split(' ');
    string senha = "";
    foreach (var y in x){
      var z = y.Length;
      senha += z.ToString();
    }
    return senha;
  }
  public static void Main(string[] args) {
    string textox = Console.ReadLine();
    Console.WriteLine(Senha(textox));
  }
}