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

