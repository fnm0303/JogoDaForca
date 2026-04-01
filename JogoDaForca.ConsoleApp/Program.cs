/*
Requisitos
1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
assim como as letras erradas.
3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
acaba.
4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.

*/

using System.Security.Cryptography;

string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length); //não precisa o +1 pq array começa contando do ZERO
string palavraAleatoria = palavras[indiceAleatorio]; //string pode ser usada como array

char[] letrasCorretas = new char[palavraAleatoria.Length];

for (int contadorLetras = 0; contadorLetras < palavraAleatoria.Length; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

bool jogadorAcertou = false;
bool jogadorPerdeu = false;
int contadorErros = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("-----------------------");
    Console.WriteLine("Jogo da Forca");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Erros cometidos: " + contadorErros + " erros");
    Console.Write("Chutes: ");

    for (int contadorLetras = 0; contadorLetras < palavraAleatoria.Length; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.WriteLine("\n------------------------");
    if (contadorErros == 0)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorErros == 1)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |                  "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorErros == 2)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |         |        "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorErros == 3)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|        "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorErros == 4)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorErros == 5)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |        /         ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorErros == 6)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       "); //@ para poder usar a contra barra \
        Console.WriteLine(@" |        / \        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    if (jogadorAcertou)
    {
        Console.WriteLine("Parabéns...Você acertou!");
        break;
    }
    else if (jogadorPerdeu)
    {
        Console.WriteLine($"Que pena, você perdeu...A palavra era {palavraAleatoria}");
        break;
    }

    Console.Write("\nDigite uma letra: "); //\n é a mesma coisa se tivesse o LINE
    char chute = Convert.ToChar(Console.ReadLine().ToUpper()); //armazena apenas um caracter

    bool letraFoiEncontrada = false;

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraAleatoria.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraAleatoria[contadorPalavraSecreta];
        if (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
            letraFoiEncontrada = true;
        }
    }

    if (!letraFoiEncontrada)
        contadorErros++;

    if (contadorErros > 5)
        jogadorPerdeu = true;

    // string palavrasAcertadas = new string(letrasCorretas); podia ser assim
    string palavrasAcertadas = string.Join("", letrasCorretas); //criando um array nenhum espaço entre os itens

    if (palavrasAcertadas == palavraAleatoria)
    {
        Console.WriteLine("Parabéns...Você acertou!");
        jogadorAcertou = true;
    }

}
Console.Write("Digite Enter para sair...");
Console.ReadLine();