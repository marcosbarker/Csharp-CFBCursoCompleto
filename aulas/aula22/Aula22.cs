using System;

class Aula22 {
  static void Main() {
    //loop foreach
    //não atribui, faz leitura de um conjunto de dados

    int[] num = new int[3]{11,22,33};

    foreach (int n in num) {
      Console.WriteLine(n);
    }
  }
}

/*com for
for (int i=0; i < num.Length; i++) {
      Console.WriteLine(num[i]
*/