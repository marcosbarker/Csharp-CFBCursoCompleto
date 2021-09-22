using System;

class Aula18 {
  static void Main() {
   
    int[,] n = new int[2,2]{{10,15},{30,20}}; //linhas , colunas
    /*
    10 15
    30 20
    */
  Console.Write(n[0,0]);
  Console.WriteLine(" " + n[0,1]);
  Console.Write(n[1,0]);
  Console.WriteLine(" " + n[1,1]);
  }
}