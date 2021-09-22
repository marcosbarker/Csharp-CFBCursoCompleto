using System;
//Classes e métodos abstratos
//é uma classe de referencia, serve como base
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
  abstract public void aceleracao();
}

class Carro : Veiculo {
  carro() { //construtor
    
  }
}

class Aula39 { 
  static void Main() {

  }
}