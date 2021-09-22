using System;
//metodo com parametro sem retorno
class Aula24 {
  static void Main() {

    int v1, v2;

    v1 = int.Parse(Console.ReadLine());
    v2 = int.Parse(Console.ReadLine());
    soma(v1, v2);
  }

  static void soma(int n1, int n2) {
    int soma = n1 + n2;
    Console.Write("A soma é: " + soma);

  }
}