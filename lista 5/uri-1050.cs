using System;

public class Program {

  public static void Main(string[] args) {
    string ddd = Console.ReadLine();
    string re = "DDD nao cadastrado";
    if (ddd == "61") re = "Brasilia";
    if (ddd == "71") re = "Salvador";
    if (ddd == "11") re = "Sao Paulo";
    if (ddd == "21") re = "Rio de Janeiro";
    if (ddd == "32") re = "Juiz de Fora";
    if (ddd == "19") re = "Campinas";
    if (ddd == "27") re = "Vitoria";
    if (ddd == "31") re = "Belo Horizonte";
    Console.WriteLine(re);
  }
}