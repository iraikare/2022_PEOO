using System;

public class Program {
  static void Ordenar(bool crescente, ref int a, ref int b, ref int c){
    
    int maior = Math.Max(c,(Math.Max(a,b)));
    int menor = Math.Min(c,(Math.Min(a,b)));
    int medio = 0;
    if (a!= maior|| a!= menor && b!= maior|| b!= menor) medio = c;
    if (a!= maior|| a!= menor && c!= maior|| c!= menor) medio = b;
    if (c!= maior|| c!= menor && b!= maior|| b!= menor) medio = a;
    if (crescente == True){
      a = menor;
      b = medio;
      c = maior;
    }
    else{
      a= maior;
      b = medio;
      c = menor;
    }
  }

  public static void Main(string[] args) {
    string yf = Console.ReadLine();
    bool y = false
    if (yf == '0')
       y = true;
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine(Ordenar(y,ref a,ref b,ref c));
  }
}