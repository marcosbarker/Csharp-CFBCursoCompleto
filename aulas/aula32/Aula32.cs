using System;
//this
//this é referencia do objeto
//não pertence ao parametro
class Calculos {
  public int v1; //objeto
  public int v2;
  public Calculos(int v1, int v2) { //metodo (parametros)
    this.v1 = v1;
    this.v2 = v2;
  }
  public int somar() {
    return v1 + v2;
  }
}
class Aula32 {
  static void Main() {

    int v1, v2;
   
    Console.Write("Entre com o primeiro numero: ");
    v1 = int.Parse(Console.ReadLine());

    Console.Write("Entre com o segundo numero: ");
    v2 = int.Parse(Console.ReadLine());

     Calculos c = new Calculos(v1, v2);//declaracao de objeto

     Console.WriteLine("A soma de {0} com {1} é {2}", v1, v2, c.somar());
  }
}