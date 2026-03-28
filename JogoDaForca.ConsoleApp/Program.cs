/*
Requisitos
1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
assim como as letras erradas.
3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
acaba.
4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.

*/

string palavraAleatoria = "MELANCIA"; //string pode ser usada como array

char[] letrasCorretas = new char[8];

for (int contadorLetras = 0; contadorLetras < 8; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

bool jogadorAcertou = false;
int tentativas = 0;

while (jogadorAcertou == false && tentativas < 5)
{
    //Console.Clear();

    for (int contadorLetras = 0; contadorLetras < 8; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }
    Console.Write("\nDigite uma letra: "); //\n é mesma coisa se tivesse o LINE
    char chute = Convert.ToChar(Console.ReadLine()); //armazena apenas um caracter
    tentativas++;

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraAleatoria.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraAleatoria[contadorPalavraSecreta];
        if (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
        }
    }

    //tentar fazer o término do jogo, se palavra aleatoria == letrasCorretas então jogadorAcertou = true

    Console.ReadLine();

}