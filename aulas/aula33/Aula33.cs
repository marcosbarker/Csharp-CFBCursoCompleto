using System;
//public vs private
//public

class Jogador {
  public int energia; //membros
  public string nome; //membros 

  public Jogador(string nome) { //construtor (parametro de entrada)
    this.nome = nome;
    energia = 100;
  }
}


class Aula33 {
  static void Main() {

    Jogador j1 = new Jogador("Marcos"); //instanciar

    //acessar os elementos da classe
    Console.WriteLine("Nome:....{0}", j1.nome);
    Console.WriteLine("Energia:.{0}", j1.energia);

  }
}