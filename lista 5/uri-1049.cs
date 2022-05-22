using System;

public class Program {

  public static void Main(string[] args) {
    string p1 = Console.ReadLine();
    string p2 = Console.ReadLine();
    string p3 = Console.ReadLine();
    string tipo = "x";
      
    if (p1 =="vertebrado" && p2 == "ave" && p3=="carnivoro") tipo = "aguia";
    if (p1 =="vertebrado" && p2 == "ave" && p3=="onivoro") tipo = "pomba";
    
    if (p1 =="vertebrado" && p2 == "mamifero" && p3=="onivoro") tipo = "homem";
    if (p1 =="vertebrado" && p2 == "mamifero" && p3=="herbivoro") tipo = "vaca";

     if (p1 =="invertebrado" && p2 == "inseto" && p3=="hematofago") tipo = "pulga";
     if (p1 =="invertebrado" && p2 == "inseto" && p3=="herbivoro") tipo = "lagarta";

     if (p1 =="invertebrado" && p2 == "anelideo" && p3=="hematofago") tipo = "sanguessuga";
     if (p1 =="invertebrado" && p2 == "anelideo" && p3=="onivoro") tipo = "minhoca";

    Console.WriteLine(tipo);
  }
}