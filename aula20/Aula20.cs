using System;

class Aula20 {
  static void Main() {
    //loop while (enquanto)
    //uma espressao logica
    
    int[] num2 = new int[3] ;

    int num = 0;

    while (num < num2.Length) {
      Console.WriteLine("Teste repetição " + num);
      num++;
    
    }
    Console.WriteLine("");
    Console.WriteLine("Fim do loop");
  }
}