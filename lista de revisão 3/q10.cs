using System;

public class Program {

  public static void Main(string[] args) {
    string s = "Brasil";
    int i =1;
    while(i<=6){
      s = s.Substring(1) + s.Substring(0,1);
      Console.WriteLine(s);
      i++;
    }
  }
}