using System;
// herança de classes

class Veiculo { //classe base
  public int rodas;
  public int VelMax; //membros
  private bool ligado; //membros

  public void ligar() { //metodo
    ligado = true;
  }
  public void desligar() { //metodo
    ligado = false;
  }

  public string getLigado() {
    if (ligado) {
      return "sim";
    } else {
      return "não";
    }
  }
}

class Carro : Veiculo { // classe que vai herdar : classe sendo herdada
                        // classe derivada : herda classe base
  public string nome;
  public string cor;
  public Carro(string nome, string cor) {
    ligar();
    rodas = 4;
    VelMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}
class Aula34 {
  static void Main() {
    Carro c1 = new Carro("Subaru", "Prata");

    Console.WriteLine(c1.cor);
    Console.WriteLine(c1.nome);
    Console.WriteLine(c1.rodas);
    Console.WriteLine(c1.VelMax);
    Console.WriteLine(c1.getLigado());
  }
}