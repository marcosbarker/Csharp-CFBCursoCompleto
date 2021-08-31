using System;

class Aula08 {
  public static void Main() {
    int v1, v2, v3, soma;
    string nome;

    Console.Write("Digite o primeiro valor: ");
    v1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o primeiro valor: ");
    v2 = Convert.ToInt32(Console.ReadLine());

    soma = v1 + v2;

    Console.WriteLine("");
    Console.WriteLine("O resultado de " + v1 + " + " + v2 + " é " + soma);
    Console.WriteLine("O resultado de {0} + {1} é {2}", v1, v2, soma);
  }
}