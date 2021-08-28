using System;
class Aluno03 {
  static void Main() {
    int num = 0;
    char letra = 'c';
    float valor = 5.3f;
    string nome = "Marcos";

    var aux = nome; //var recebe o tipo da atribuica

    Console.WriteLine("Meu nome é " + aux);

    //multiplas variaveis 

    int num1, num2, res;

    num1 = 10;
    num2 = 10;
    res = num1 * num2;

    Console.WriteLine("A mulplicação de " + num1 + " e " + num2 + " é " + res);
  }
}