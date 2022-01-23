/*
* Notas e códigos de estudo de C#
* By João Paulo
*/



//=============== tipos primitivos de váriveis ===============\\
/*
        Tipo    |    Tamanho    |    Valores possíveis
    ------------|---------------|---------------------
        bool    |    1 byte     |   true ou false
        byte    |    1 byte     |   0 a 255
        sbyte   |    1 byte     |   -128 a 127
        short   |    2 bytes    |   -32768 a 32767
        unshort |    2 bytes    |    0 a 65535
        int     |    4 bytes    |   -2147483648 a 2147483647
        uint    |    4 bytes    |   0 a 4294967295
        long    |    8 bytes    |   -9223372036854775808L a 9223372036854775807L
        ulong   |    8 bytes    |   0 a 18446744073709551615
        float   |    4 bytes    |   número até 10^38
        double  |    8 bytes    |   número até 10^308
        decimal |   16 bytes    |   numero com até 28 casas decimais
        char    |    2 bytes    |   caracter limitado por aspas simples. Ex.: 'a', 'b'


*/

//=============== string ===============\\
/*
    Além dos tipos primitivos de váriveis temos um tipo espcifico para armazenar textos. 
    Com string conseguimos armazenar qualquer valor q seja delimitado por aspas duplas

*/



//=============== Linguagem fortemente tipada ===============\\
/*
	O C# é uma linguagem fortemente tipiada. Isso significa que uma vez que uma variável é criada e iniciada,
	o seu tipo não pode ser mudado. 
    Temos duas formas de criar e iniciar váriáeis, a tipagem estatica e a dinamica. 
*/

//=============== Tipagem Estática ===============\\
/*
	A tipagem estática se dá quando na declaração da variável ja é passado o seu tipo.
    Por exemplo:
    int numero;
    ou
    char letra;

    poderiamos ainda declar e iniciar a variável recebendo um valor
    nesse caso:
    int numero = 0; // variável do tipo inteiro recebe valor 0
    ou 
    char letra = 'A'; // variável do tipo character recebe A

*/

//=============== Tipagem dinamica ===============\\
/* 
    É possível declarar uma variável sem informar diretamente o seu tipo.
    Para isso usamos var. O que irá definir o tipo da variável é o tipo de valor que ela recebe.
    Lembrando que C# possui uma tipagem forte, portanto, uma vez passado o valor da variável
    ela assume a tipagem e não pode ser inserido novo valor com tipagem diferente.
    Exemplo: 
    var numero; // variável sem tipo (por enquanto)

    adicioando um valor a variável 
    numero = 3; // a váriavel agora só recebe valor inteiro

    o mesmo poderia ser feito com qualquer tipo de dado
    
*/


//=============== Conversões de cast e tipo ===============\\
/*
    E se quissemos fazer com que uma variável do tipo string recebesse algum valor do tipo int. Como fariamos? 
    Para isso temos as conversões. 



*/

