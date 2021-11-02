using System;
//Array com Struct

struct Carro
{
    public string modelo;
    public string cor;

    public void info()
    {
        Console.WriteLine("Modelo:--{0}", this.modelo);
        Console.WriteLine("Cor:-----{0}", this.cor);
        Console.WriteLine("------------");
    }
}

class Aula45
{
    static void Main()
    {
        {

            Carro[] carros = new Carro[6];

            carros[0].modelo = "Tesla";
            carros[0].cor = "Vermelho";
            carros[1].modelo = "Tesla";
            carros[1].cor = "Prata";
            carros[2].modelo = "FIAT";
            carros[2].cor = "Preto";
            carros[3].modelo = "VW";
            carros[3].cor = "Verde";
            carros[4].modelo = "VW";
            carros[4].cor = "Roxo";
            carros[5].modelo = "Ford";
            carros[5].cor = "Amarelo";

            for (int i = 0; i < carros.Length; i++)
            {
                carros[i].info();
            }
   
        }
    }
}