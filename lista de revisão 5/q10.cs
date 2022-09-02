using System;

public class Program {
  public static string Vogais(string s){
    string x ="";
    foreach(char i in s){
      if( i=='a'|| i=='e'|| i=='i'|| i=='o'|| i=='u'){
        x += i;
      }
    }
    return x;
  }
  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    Console.WriteLine(Vogais(texto));
  }
}