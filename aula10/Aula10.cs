using System;

class Aula10 {

  enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};
  static void Main() {

    DiasSemana ds = DiasSemana.Domingo;
    
    DiasSemana ds = (DiasSemana)0; //por indice

    int ds = (int)DiasSemana.Domingo; //sai indice, 0

  }
}