using System;
//Herança/Ordem de execução dos construtores
class Base {
  public Base() {
    Console.WriteLine("Construtor da classe base");
  }
}

class Derivada1:Base {
  public Derivada1() {
    Console.WriteLine("Construtor da classe Derivada1");
  }
}

class Derivada2:Derivada1 {
  public Derivada2() {
    Console.WriteLine("Construtor da classe Derivada2");
  }
}

class Aula37 {
  static void Main() {

    //Derivada1 d1 = new Derivada1();
    Derivada2 d2 = new Derivada2();

    //execução a partir da classe base
  }
}