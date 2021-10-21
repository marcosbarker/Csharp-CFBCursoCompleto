using System;
//Struct, pode armazenar tips de dados diferentes

struct Carro {
  public string marca;
  public string modelo;
  public string cor;

  public Carro(string marca, string modelo, string cor) { //construtor
    this.marca = marca;
    this.modelo = modelo;
    this.cor = cor;
  }

  public void info() {
    Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", this.marca, this.modelo, this.cor);
  }
}

class Aula44 {
  static void Main() {

    Carro c1;

    c1.marca = "VW";
    c1.modelo = "Gol";
    c1.cor = "Azul";

    Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", c1.marca, c1.modelo, c1.cor);

//OU

    Carro c2 = new Carro("Fiat", "Uno", "Prata");
    
    Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", c2.marca, c2.modelo, c2.cor);

//OU 

    c1.info();
    c2.info();
  }
}