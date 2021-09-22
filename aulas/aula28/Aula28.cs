using System;
//classes e objetos
  class Aula28 { 
    static void Main() {
      Jogador j1 = new Jogador();
      Jogador j2 = new Jogador();

      Console.Write("Entre com a energia do Jogador 1: ");
      j1.energia = int.Parse(Console.ReadLine());

      Console.Write("Entre com a energia do Jogador 2: ");
      j2.energia = int.Parse(Console.ReadLine());

      Console.WriteLine("Energia do Jogador 1: {0}", j1.energia);
      Console.WriteLine("Energia do Jogador 2: {0}", j2.energia);
  }

  public class Jogador {//se não declarar [modificador da classe] o padrao e 'public'
    public int energia  = 0;
    public bool vivo = true;
  }
}