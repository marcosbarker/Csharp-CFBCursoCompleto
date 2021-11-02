using System;
//Métodos que retornam objetos

class Galinha
{
    private string nomeGalinha;
    private int numOvo;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar()
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }

}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;

    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo(s) criado(s):-- {0}", this.numOvo);
        Console.WriteLine("Nome galinha: {0}", this.minhaGalinha);
    }

}

class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Benedita");
        Galinha g2 = new Galinha("Fluflu");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();
    }
}