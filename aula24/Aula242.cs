using System;
//metodo com parametro com retorno
class Aula24 {
  static void Main() {

    int v1, v2, s;

    v1 = int.Parse(Console.ReadLine());
    v2 = int.Parse(Console.ReadLine());
    s = soma(v1, v2);

    Console.WriteLine("A soma é " + s);
  }

  static int soma(int n1, int n2) { //int no lugar de void retorna um inteiro
    int soma = n1 + n2;
    return soma;
  }
}