using System;
//Classes e métodos abstratos
//é uma classe de referencia, serve como base para classes derivadas
//não é implementado o comportamento do metodo
//quem herda a classe abstrata é obrigado a implementar os metodos
//não se pode instanciar objetos de uma classe abstrata

abstract class Veiculo { //classe base abstrata
  protected int velMaxima;
  protected int velAtual;
  protected bool ligado;

  public Veiculo() { //construtor
    ligado = false;
    velAtual = 0;
  }
  public void setLigado(bool ligado) { 
    this.ligado = ligado;
  }
  public int getVelAtual() {
    return velAtual;
  }
   abstract public void aceleracao(int mult);
}

class Carro : Veiculo {
  public Carro() { //construtor
    velMaxima = 120;
  }
  override public void aceleracao(int mult) {
    velAtual += 10 * mult;
  }
}

class Aula39 { 
  static void Main() {

    Carro carro1 = new Carro();

    carro1.aceleracao(1);

    Console.WriteLine("Velocidade atual: " + carro1.getVelAtual());
  }
}