## Estrutura da classe

[ModificadorClasse] class NomeDaClasse {
    // variaveis / propriedades
    [EspecificadorAcesso] tipo NomeDaPropriedade;

    //Metodos da classe
[EspecificadorDeAcesso] retorno NomeDoMetodo([arg1, arg2...]){
    //corpo do metodo
    }
}
<br><br>

## Exemplo de Classe:

public class Teste {
    public string teste = "";
    public int teste1 = 0;
  }
}



### tipo e retorno: 
- void, int, bool, string, char...
<br><br>

### Modificador de Classe: Define a visibilidade da classe
- public: Pública, sem restrição de visualização
- abstract: Classe-Base para outras classes, não podem ser 
            instanciados objetos desta classe
- sealed: Classe não pode ser herdada
- static: Classe não permite a instanciação de objetos e seus
          membros devem ser static
<br><br>

### Especificadores de Acesso: ONde um membro da classe pode ser acessado
- public: Sem restrição de acesso
- private: Só podem ser acessados pela propria classe
- protected: Podem ser acessados na propria classe e nas classes derivadas
- abstract: Os metodos nao tem implementação somente cabeçalhos
- sealed: O metodo nao pode ser redefinido
- virtual: O metodo pode ser redefinido em uma classe derivada
- static: O metodo pode ser chamado mesmo sem a instanciação de um objeto 
