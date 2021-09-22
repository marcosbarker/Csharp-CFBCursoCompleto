using System;

class Aula26 {
  //argumento out
  //possibilita mais de uma saida no return
  static void Main() {
    int divid, divis, quoc, rest;

    Console.Write("Entre com o dividendo: ");
    divid = int.Parse(Console.ReadLine());
    Console.Write("Entre com o divisor: ");
    divis = int.Parse(Console.ReadLine());

    quoc = divide(divid, divis, out rest);

    Console.WriteLine("{0} / {1}: quociente = {2} e resto = {3}", divid, divis, quoc, rest);
  }

  static int divide(int dividendo, int divisor, out int resto) {
    int quociente;
    quociente = dividendo / divisor;
    resto = dividendo % divisor;
    return quociente;
  }  
}