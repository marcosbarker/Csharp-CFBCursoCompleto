using System;

class Aula09 {
  public static void Main() {

    //operacao bitwise
    // << desloca em 1 os 5 ultimos bits da direita para esquerda, dobra o valor
    // >> desloca em 1 os 5 ultimos bits direita para direita, reduz o valor pela metade

    int numEsquerda = 10;
    int numDireita = 10;
    
    numEsquerda = numEsquerda << 1;
    numDireita = numDireita >> 1;
    
    Console.WriteLine("BitWise a direita  de 10 >>  " + numDireita);
    Console.WriteLine("BitWise a esquerda de 10 << " + numEsquerda);
  }
}