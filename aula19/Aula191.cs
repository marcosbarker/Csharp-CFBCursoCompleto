using System;

class Aula19 {
  static void Main() {

    int[] num = new int[10]; 

    for (int i=0; i < num.Length; i++) {
      num[i] = 0;

      Console.WriteLine("Teste de repetição, valor: " + num[i]);
    }
  }
}