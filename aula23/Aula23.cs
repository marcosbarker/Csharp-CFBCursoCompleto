using System;

class Aula23 {
  static void Main() {
    //metodos para arrays

    int[] vetor1 = new int[5];
    int[] vetor2 = new int[5];
    int[] vetor3 = new int[5];
    int[,] matriz = new int[2,5] {{11,22,00,44,55},{66,77,88,99,00}};

    Console.WriteLine("Random");
    Random rnd = new Random();
    for (int i = 0; i < vetor1.Length; i++) {
      vetor1[i] = rnd.Next(0, 49); //sorteria de 0 ate 49 (50,100) min e max
      //Console.WriteLine(vetor1[i]);
    }

    Console.WriteLine("Elementos do vetor1");
    foreach(int n in vetor1) {
      Console.WriteLine(n);
    }
    Console.WriteLine("__________________________________________________");
    


    //public static int BinarySearch(array, valor);
    //retorna a posição do elemento procurado
    Console.WriteLine("BinarySearch");
    int procurado = 33; //elemento procurado, se retornar negativo, o elemento nao se encontra no array
    int posicao = Array.BinarySearch(vetor1, procurado);
    Console.WriteLine("Valor {0} está na posição {1}", procurado, posicao);
    Console.WriteLine("__________________________________________________");



    //public static void Copy(Array_origem, Array_destino, quantidade de elementos);
    //faz a copia de um array para outro
    Console.WriteLine("Copy");
    Array.Copy(vetor1, vetor2, vetor1.Length); //Length ira copiar todo v1 para v2
    foreach (int n in vetor2) {
      Console.WriteLine(n);
    }
    Console.WriteLine("__________________________________________________");



    //public void CopyTo(Array_destino, a partir desta posicao);
    //todos os elementos do vetor1 serao copiados para o vetor3
    Console.WriteLine("CopyTo");
    vetor1.CopyTo(vetor3,0);//copiar a partir da posicao 0
    foreach (int n in vetor3) {
      Console.WriteLine(n);
    }
    Console.WriteLine("__________________________________________________");



    //public long GetLength(retorna o tamanho indice dimensao);
    Console.WriteLine("GetLongLength");
    long quantidadeElemetosVetor = vetor1.GetLongLength(0);//o 0 se refere a dimensao analizada
    Console.WriteLine("Quantidade de elementos {0}", quantidadeElemetosVetor);
    Console.WriteLine("__________________________________________________");



    //public int GetLowerBound(retorna o menor indice dimensao)
    Console.WriteLine("GetLowerBound");
    int MenorIndiceVetor = vetor1.GetLowerBound(0);
    int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
    Console.WriteLine("Menor indice do vetor1 {0}", MenorIndiceVetor);
    Console.WriteLine("Menor indice da matriz " + MenorIndiceMatriz_D1);
    Console.WriteLine("________________________________");



    //public int GetUpperBound(retorna o maior indice dimensao)
    Console.WriteLine("GetUpperBound");
    int MaiorIndiceVetor = vetor1.GetUpperBound(0);
    int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);//matriz pode usar 0 ou 1
    Console.WriteLine("Menor indice do vetor1 {0}", MaiorIndiceVetor);
    Console.WriteLine("Menor indice da matriz " + MaiorIndiceMatriz_D1);
    Console.WriteLine("________________________________");



    //public object Getvalue(long indice);
    //retorna o valor da posicao que esta no indice indicado
    Console.WriteLine("GetValue");
    int valor0 = Convert.ToInt32(vetor1.GetValue(3));//retorna o valor na posicao de indice 3
    int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
    Console.WriteLine("Valor da posição 3 no vetor1: {0}", valor0);
    Console.WriteLine("__________________________________________________");



    //public static int IndexOf(array, valor);
    //retorna o indice do valor indicado
    //retorna o indice do primeiro valor encontrado (5,5,5) retorna o indice do primeiro 5
    //se o valor nao existir, retora indice negativo
    Console.WriteLine("IndexOf");
    int indice1 = Array.IndexOf(vetor1, 3);// 3 e o valor indicado
    Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
    Console.WriteLine("________________________________");



    //public static int LastIndexOf(array, valor);
    //retorna o indice do valor indicado
    //retorna o indice do ultimo valor encontrado (5,5,5) retorna o indice do ultimo 5
    //se o valor nao existir, retora indice negativo
    Console.WriteLine("LastIndexOf");
    int indice2 = Array.LastIndexOf(vetor1, 3);// 3 e o valor indicado
    Console.WriteLine("Indice do ultimo valor 3: {0}", indice2);
    Console.WriteLine("________________________________");



    //public static void Reverse(array);
    //inverte a ordem dos valores (elementos)
    Console.WriteLine("Reverse");
    Array.Reverse(vetor1);
    foreach (int n in vetor1) {
      Console.WriteLine(n);
    }
    Console.WriteLine("________________________________");



    //public void SetValue(object valor, long posicao);
    //setar o valor em uma posicao
    Console.WriteLine("Set value");
    vetor2.SetValue(99, 0); //adiciona 99 na posicao de indice 0
    for (int i = 0; i < vetor2.Length; i++) {
      //vetor2.SetValue(0, i); //seta 0 para todas as posicoes
    }
    Console.WriteLine("vetor2");
    foreach (int n in vetor2) {
      Console.WriteLine(n);
    }
    Console.WriteLine("________________________________");



    //public static void Sort(array);
    //ordena os valores em ordem crescente
    Console.WriteLine("Sort");
    Array.Sort(vetor1);
    Array.Sort(vetor2);
    Array.Sort(vetor3);
    Console.WriteLine("Vetor1");
    foreach (int n in vetor1) {
      Console.WriteLine(n);
    }
    Console.WriteLine("\nvetor2");
    foreach (int n in vetor2) {
      Console.WriteLine(n);
    }
    Console.WriteLine("\nvetor3");
    foreach (int n in vetor3) {
      Console.WriteLine(n);     
    }
  }
}