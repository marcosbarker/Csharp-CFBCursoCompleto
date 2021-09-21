using System;
// herança de classes

class Veiculo { //classe base
  private int rodas;
  public int VelMax; //membros
  private bool ligado; //membros

  public Veiculo(int rodas) {//construtor
    this.rodas = rodas;
  }

  public void ligar() { //metodo
    ligado = true;
  }
  public void desligar() { //metodo
    ligado = false;
  }

//versao com operador ternario
public string getLigado() {
  return (ligado?"sim":"não");
}
/*
  public string getLigado() {
    if (ligado) {
      return "sim";
    } else {
      return "não";
    }
  }
  */
  public int getRodas(){ //metodo
    return rodas;
  }
}

class Carro : Veiculo { // classe que vai herdar : classe sendo herdada
                        // classe derivada : herda classe base
  public string nome;
  public string cor;
  public Carro(string nome, string cor) : base(4) { //inicializando o construtor da classe base
    ligar();
    VelMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}
class Aula35 {
  static void Main() {
    Carro c1 = new Carro("Subaru", "Prata");

    Console.WriteLine(c1.cor);
    Console.WriteLine(c1.nome);
    Console.WriteLine(c1.getRodas());
    Console.WriteLine(c1.VelMax);
    Console.WriteLine(c1.getLigado());
  }
}