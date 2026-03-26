/*
Requisitos
1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
assim como as letras erradas.
3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
acaba.
4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.

*/

string palavraAleatoria = "MELANCIA";

bool jogadorAcertou = false;

while (jogadorAcertou == false)
{
    Console.WriteLine("Digite uma letra: ");
    char letra = Convert.ToChar(Console.ReadLine()); //armazena apenas um caracter


}