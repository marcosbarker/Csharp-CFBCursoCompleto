using System;
//membros Protected
class Veiculo { //classe base
  public int velAtual; 
  private int velMax; 
  protected bool ligado;

  public Veiculo(int velMax) { //construtor
    velAtual = 0;
    this.velMax = velMax;
    ligado = false;
  }
  public int getVelMax() { //metodo
    return velMax;
  }
  public string getLigado() { 
    return (ligado?"sim":"não");
  }
}

class Carro : Veiculo { // classe derivada
  public string nome;
  public Carro(string nome, int velMax) : base(velMax) { //inicializa um contrutor da classe base com um parametro
    this.nome = nome;
    ligado = false;
  }
}

class Aula36 {
  static void Main() {

    Carro carro = new Carro("Xsara", 140);

    Console.WriteLine(carro.nome);
    Console.WriteLine(carro.getVelMax());
    Console.WriteLine(carro.getLigado());
  }
}