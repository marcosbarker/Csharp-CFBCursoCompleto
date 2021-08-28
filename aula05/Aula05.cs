using System;
class Aula05 {
  static void Main() {
    int res = 10 + 5;
    //bool res1 = 10 != 5; //operador relacional booleano
    bool res1 = (10 > 5) | (5 < 10);
    //Operadores logicos basicos
    // & = AND / E
    // | = OR / OU
    
    int res2 = 10; 
    res2 += 1; //incremento de 1 ou res2++ (o 1 pode ser personalizado)
    //o incremento funciona com *=  /=  -=  +=

    Console.WriteLine(res1);
  }
}