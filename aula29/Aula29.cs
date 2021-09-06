using System;
//(construtores) e destrutores

public class Jogador {
  public int energia;
  public bool vivo;
  public string nome;

//construtor é o metodo que e executado automaticamente quando instanciar um objeto da classe
  public Jogador(string n) {
    energia = 100;
    vivo = true;
    nome = n;
  }

  //destrutor, ~ e o nome da classe
  ~Jogador() {
    Console.WriteLine("Jogador destruido");
  }
}

class Principal {
  static void Main() {

    string nome1;

    Console.WriteLine("Entre com o nome do jogado1: ");
    nome1 = Console.ReadLine();

    Jogador j1 = new Jogador(nome1);
    Jogador j2 = new Jogador("Marcos");

    Console.WriteLine("Energia j1 {0}", j1.energia);
    Console.WriteLine("Nome j1 {0}", j1.nome);
  }
}
