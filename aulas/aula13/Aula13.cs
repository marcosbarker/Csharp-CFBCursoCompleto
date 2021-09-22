using System;

class Aula13 {
  static void Main() {
    //if (se)  else (se não)

  int n1, n2, n3, n4, media;
    n1=n2=n3=n4=media=0; //inicializando todas as variaveis

  string resultado;

    Console.WriteLine("Digite a primeira nota: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a terceira nota: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quarta nota: ");
    n4 = int.Parse(Console.ReadLine());

    

    media = (n1 + n2 + n3 + n4) / 4;

    if (media >= 6) {
      resultado = "Aprovado";

    } else if (media <= 4) {
      resultado = "Reprovado";
    
    } else {
      resultado = "Recuperação";
    }

    Console.WriteLine("Resultado " + resultado + " media " + media);
  }  
}

/*
 if (media < 4) {
      resultado = "Reprovado";

    } else if (media < 6) {
      resultado = "Recuperação";
    
    } else {
      resultado = "Aprovado";
    }
*/