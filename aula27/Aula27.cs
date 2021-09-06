using System;

class Aula27 {
  //argumento params
  //situacoes: nada, um ou mais de um
  static void Main() {
    
    soma(10, 20);    
  }

  static void soma(params int[]n) { //n é o nome do array
    int res = 0;

    if (n.Length < 1) {
      Console.WriteLine("Não existem valores");

    } else if (n.Length < 2) {
      Console.WriteLine("Valores insuficientes: {0}", n[0]);
    
    } else {
      for (int i = 0; i < n.Length; i++) {
        res += n[i];
      }

        Console.WriteLine("A soma dos valores é {0} ", res);
    }
  }
}