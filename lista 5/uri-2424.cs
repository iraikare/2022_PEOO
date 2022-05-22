using System;

public class Program {

  public static void Main(string[] args) {
    string xyf = Console.ReadLine();
    string [] xy = xyf.Split();
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);
    if (x>= 0 && x<=432 && y>=0 && y<=468) Console.WriteLine("dentro");
    else Console.WriteLine("fora");
  }
}