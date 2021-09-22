using System;

class Aula21 {
  static void Main() {
    //loop do while ()
    //garante que sera executado pelo menos uma vez
    //executa e depois testa

    string senha = "123";
    string senhaDigitada;
    int tentativas = 0;

   
   do {
      
      Console.Clear();
      Console.Write("Digite a senha: ");
      senhaDigitada = Console.ReadLine();

      tentativas++;

    } while (senha != senhaDigitada);
      Console.WriteLine("Senha correta " + tentativas + " tentativas");

  }
}