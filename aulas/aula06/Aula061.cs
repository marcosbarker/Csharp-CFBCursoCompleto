using System;

class Aula061 {
  static void Main() {
    double valorCompra = 5.50;
    double valorVenda;
    double lucro = 0.1;
    string produto = "Pastel";

    valorVenda = valorCompra + (valorCompra * lucro);

    Console.WriteLine("Produto............:{0,8}", produto); // 0 é o indice e 8 é o espacamento para variavel
    Console.WriteLine("Valor da compra....:{0,8:c}", valorCompra); // :c formato monetario
    Console.WriteLine("Lucro..............:{0,8:p}", lucro); // :p formato de porcentagem
    Console.WriteLine("Valor de venda.....:{0,8:c}", valorVenda);
  }
}