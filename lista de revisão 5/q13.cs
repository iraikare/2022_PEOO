using System;

public class Program {
  public static string RemoverEspacos(string texto){
    string x ="";
    foreach(char i in texto){
      if( i!=' '){
        x+=i;
      }
    }
    return x;
  }
  public static void Main(string[] args) {
    string textox = Console.ReadLine();
    Console.WriteLine(RemoverEspacos(textox));
  }
}