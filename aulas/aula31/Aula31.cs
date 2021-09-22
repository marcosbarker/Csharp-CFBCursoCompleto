using System;
//classes static
//classe stetic nao permite o uso de construtores
//para acessar [momeDaClasse].[membro]
//classe static tem que ter membros static
//uma classe nao static pode ter um ou mais membros static
static public class Jogador {
  static public int energia;
  static public bool vivo;
  static public string nome;
  

   static public void iniciar(string n) {
    energia = 20;
    vivo = true;
    nome = n;
  }


 static public void info() {
    Console.WriteLine("Nome do jogador....{0} ", nome);
    Console.WriteLine("Energia do jogador.{0} ", energia);
    Console.WriteLine("Estado do jogador..{0} \n\n", vivo);
  }
}

class Inimigo {
  static public bool alerta; //static valera para todos utilizando a classe
  public string nome;
  public Inimigo(string n) {
    alerta = false;
    nome = n;
  }
  public void info() {
    Console.WriteLine(nome);
    Console.WriteLine(alerta);
    Console.WriteLine("_____________________________");
  }
}

class Principal {
  static void Main() {
  
   Jogador.iniciar("Marcos");
   Jogador.info();

   Inimigo i1 = new Inimigo("Predador");
   Inimigo i2 = new Inimigo("Smaug");
   Inimigo i3 = new Inimigo("Vingador");

   Inimigo.alerta = true; //acesso a partir da classe
                          //static, mesma posicao na memoria, vale para todos
   i1.info();
   i2.info();
   i3.info();
  }
}