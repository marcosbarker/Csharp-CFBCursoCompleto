using System;
//public vs private
//private

class Jogador {
  private int energia; //membros
  private string nome; //membros 

  public Jogador(string nome) { //construtor (parametro de entrada)
    this.nome = nome;
    energia = 100;
  }

  //metodo para obter valores da classe private
  public int getEnergia() {
    return energia;
  }
  public string getNome() {
    return nome;
  }
  public void setEnergia(int e) { //set atribuicao, esta alterando
    if( e < 0) {
      if(energia + e < 0) {
        energia = 0;
      } else {
        energia += e;
      } 
    } else if(e > 0) {
      if(energia + e > 100) {
        energia = 100;
      } else {
        energia += e;
      } 
    }
  }

  class Aula33 {
  static void Main() {

    int e;   
    string nome;

    Console.Write("Entre com o nome: ");
    nome = Console.ReadLine();
    Jogador j1 = new Jogador(nome);
        
    Console.Write("Entre com a energia: ");
    e = int.Parse(Console.ReadLine());
    j1.setEnergia(e);

    //acessar os elementos da classe
    Console.WriteLine("_________________________");
    Console.WriteLine("Nome:....{0}", j1.getNome());
    Console.WriteLine("Energia:.{0}", j1.getEnergia());
  }
}
}