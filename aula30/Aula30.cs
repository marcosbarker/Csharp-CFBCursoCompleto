using System;
//(construtores) e destrutores

public class Jogador {
  public int energia;
  public bool vivo;
  public string nome;
  

//construtor é o metodo que e executado automaticamente quando instanciar um objeto da classe
//sobrecarga de contrutores
   public Jogador() {
    energia = 20;
    vivo = true;
    nome = "Roberto";
  }
  public Jogador(string n) {
    energia = 70;
    vivo = true;
    nome = n;
  }
   public Jogador(string n, int energ) {
    energia = energ;
    vivo = true;
    nome = n;
  }
  public Jogador(string n, int energ, bool viv) {
    energia = energ;
    vivo = viv;
    nome = n;
  }

  public void info() {
    Console.WriteLine("Nome do jogador....{0} ", nome);
    Console.WriteLine("Energia do jogador.{0} ", energia);
    Console.WriteLine("Estado do jogador..{0} \n\n", vivo);
  }
}

class Principal {
  static void Main() {

    Jogador j1 = new Jogador();
    Jogador j2 = new Jogador("Correa");
    Jogador j3 = new Jogador("Marcos", 100);
    Jogador j4 = new Jogador("Paulo", 80, true);

   j1.info();
   j2.info();
   j3.info();
   j4.info();
  }
}