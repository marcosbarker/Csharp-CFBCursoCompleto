using System;

class Aula11 {
  static void Main() {

    //conversao implicita, segura. int para float
    int n1 = 10;
    float n2 = n1 * n1;

    //conversao explicita, operacao de type cast
    float n1 = 10f;
    int n2 = (int)n1;

  }
}