using System;

class Aula17 {
  static void Main() {
    //int n1, n2, n3, n4, n5;
    int[] n = new int[3]; //0-3
    n[0] = 11;
    n[1] = 50;
    n[2] = 78;

  //ou

    int[] num = new int[3]{11, 50, 78};//automaticamente o array tem o tamanho da quantidade de declaracoes

  //outra

  int[] num2 = {11, 50, 78};  

  Console.WriteLine(n[0]);
  Console.WriteLine(num[1]);
  Console.WriteLine(num2[2]);

  }
}