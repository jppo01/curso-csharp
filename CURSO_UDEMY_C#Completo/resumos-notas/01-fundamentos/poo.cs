/*
* Notas e códigos de estudo de C#
* By João Paulo
*/


//=============== Object  ===============\\
/*
    Toda classe em C# é uma subclasse object
    Object possui os seguintes metodos:
    - GetType - Retorna o tipo do objeto.
    - Equals - Compara se o objeto é igual ao outro.
    - GetHash - Retorna uma código Hash do Objeto.
    - ToString - Converte o Objeto para string.


    ------------ ToString ------------
    Usar o ToString em uma classe é necessário lançar mão de sobreposição, para isso usamos o override.
    Ex:
        public override string ToString(){
            return "retorno da classe aqui"; 
        }


*/

//=============== Membros Estáticos  ===============\\
/* 

    static permite chamar um metodo de uma classe sem instanciar um objeto pertencente a aquela classe. 

*/

//=============== Construtores ===============\\
/* 
    => É uma operação especial da classe, que executa no momento da
       instanciação do objeto
    => Usos comuns:
        • Iniciar valores dos atributos
        • Permitir ou obrigar que o objeto receba dados / dependências no momento de sua
          instanciação (injeção de dependência)
    => Se um construtor customizado não for especificado, a classe disponibiliza o
       construtor padrão:
        • Produto p = new Produto();
    => É possível especificar mais de um construtor na mesma classe (sobrecarga)
    => Exemplo de Sintex
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    ==> Para gerar a estrutura de um construdor no vsc digite: ctr + tab tab 
*/
//=============== Sobrecarga ===============\\
/* 
    => É possível ter vários vários construtores recebendo quantidade de parametros diferentes, 
       isso é chamado de sobrecarga. Exemplo abaixo:

         public Produto() {
            // esse primeiro é especial pq é o modelo padrão de construtor
        }

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
*/
//=============== Palavra this ===============\\
/* 
    ==> É uma referência para o próprio objeto
    ==> Usos comuns:
        • Diferenciar atributos de variáveis locais (Java)
        • Referenciar outro construtor em um construtor
        • Passar o próprio objeto como argumento na chamada de um método ou construtor 
*/
//=============== Properties ===============\\
/* 
    ==> São definição de métodos encapsulados expondo uma sintaxe similar a atributos. 
*/

