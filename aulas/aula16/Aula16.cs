using System;

class Aula16 {
  static void Main() {
  // comando goto

    int tempo=0;
    char transporte;

    inicio: //label goto + o nome da label
    Console.Clear();

    Console.WriteLine("Belo Horizonte/Mg a Vitoria/ES");
    Console.WriteLine("Escolha o transporte");
    Console.WriteLine("Avião  = A");
    Console.WriteLine("Carro  = C");
    Console.WriteLine("Onibus = O");
    Console.WriteLine("");
    transporte = char.Parse(Console.ReadLine());

    switch(transporte) {
      case 'A':
      case 'a':
        tempo = 50;
        break;
      case 'C':
      case 'c':
        tempo = 480;
        break;
      case 'O':
      case 'o':
        tempo = 660;
        break;
    default:
      tempo = -1;
      break;
    }

    double horas = tempo / 60;

    if (tempo < 0) {
      Console.WriteLine("Transporte indisponivel");
    
    } else {
      Console.WriteLine("Sua viagem levara " + tempo + " minutos (" + horas + ") horas");
    }    

    Console.Write("Calcular outra viagem?[S/n]: ");
    transporte = char.Parse(Console.ReadLine());

    if (transporte == 's' || transporte == 'S') {
      goto inicio; // goto + o nome do label
   
    } else {
      Console.Clear();
      Console.WriteLine("Fim do programa");
    }
  }
}