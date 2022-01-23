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
	O C# é uma linguagem fortemente tipiada. Isso significa que uma vez que uma variável é criada
	o seu tipo não pode ser mudado. 
*/



//=============== Tipagem dinamica ===============\\
/* 
    É possível declarar uma variável sem informar diretamente o seu tipo.
    Para isso usamos var. O que irá definir o tipo da variável é o dado que ela recebe.
    Lembrando que C# possui uma tipagem forte, portanto, uma vez passado o valor da variável
    ela assume a tipagem e não pode ser inserido novo dado com tipagem diferente.
    Exemplo: 
    
*/

//=============== Conversões de cast e tipo ===============\\

