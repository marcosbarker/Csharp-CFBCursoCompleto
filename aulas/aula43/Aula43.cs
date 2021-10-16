using System;
//Interfaces 

public interface Veiculo { //declaracao de inteface 
  void ligar(); //assinaturas de metodo
  void desligar();
  void info();
}

public interface Combate {
  void disparar();
}

class Carro:Veiculo, Combate {
  public bool ligado;
  private int municao;
  public Carro() {
    setMunicao(100);
  }

  public void setMunicao(int qtd) {
    this.municao = qtd;
  }

  public void ligar() {
    this.ligado = true;
  }
  public void desligar() {
    this.ligado = false;
  }

  public void disparar(){

  }

  public void info(){}
}

class Aula43 {
  static void Main() {

    Carro c1 = new Carro();

  }
}