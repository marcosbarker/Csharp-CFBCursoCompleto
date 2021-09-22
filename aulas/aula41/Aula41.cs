using System;
//assessores GET e SET

class Carro {
  private int velMax;

  public int vm { //propriedade, não utiliza parenteses
    get {         //propriedade especial.  PROPRIEDADE / METODO
        return velMax;
    }
    set {
      if (value < 0) {
        velMax = 0;
      } else if (value > 300) {
        velMax = 300;
      } else {
        velMax = value;
      }
    }
  }
  public Carro() {
    vm = 120;
  }
}
class Aula41 {
  static void Main() {

    Carro c1 = new Carro();
    
    Console.Write("Entre com a velocidade: ");
    c1.vm = int.Parse(Console.ReadLine());

    Console.WriteLine("Velocidade: " + c1.vm);
  
  }
}