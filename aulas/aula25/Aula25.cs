using System;

class Aula25 {
  //Passagem de valor por referência
  //ref de referencia
  static void Main() {
    int num = 10;
    dobrar(ref num);
    Console.WriteLine(num);
  }

  static void dobrar(ref int valor) {
    valor *= 2;

  }
}