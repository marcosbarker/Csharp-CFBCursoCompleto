using System;

class Aula12 {
  static void Main() {
    int n1, n2, n3, n4, media;
    n1=n2=n3=n4=media=0; //inicializando todas as variaveis

    //if (se){ }
    Console.WriteLine("Digite a primeira nota: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a terceira nota: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quarta nota: ");
    n4 = int.Parse(Console.ReadLine());

    string resultado = "Reprovado";

    media = (n1 + n2 + n3 + n4) / 4;

    if (media >= 6) {
      resultado = "Aprovado";
    }
    Console.WriteLine("Resultado " + resultado + " media " + media);
  }
}