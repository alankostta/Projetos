using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa
{
    public class ListaDePerguntas
    {
        public void IniciaAdivinha()
        {
            List<NovaPergunta> perguntas;

            perguntas = CriarPerguntas();
            Random rand = new Random();

            int i = rand.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[i];

            int tentativas = 0;
            Boolean flag = false;
            string resp = "";

            while (tentativas <= 3 && flag == false)
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                Console.Write("Resposta: ");

                resp = Console.ReadLine();
                resp = resp.ToUpper();

                if (resp == pergunta.Resposta)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Você errou!!!Dica: " + pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabens você ganhou!!!\n\n");

                Console.WriteLine("                    OOOOOOOOOOOOOO                     \n");
                Console.WriteLine("                OOOOOOOOOOOOOOOOOOOOO                 \n");
                Console.WriteLine("              OOOOOOO OOOOOOOOO OOOOOOO               \n");
                Console.WriteLine("            OOOOOOO    OOOOOOO    OOOOOOO             \n");
                Console.WriteLine("          OOOOOOOO  (#) OOOOO  (#) OOOOOOOO          \n");
                Console.WriteLine("         OOOOOOOOOOO  OOOOOOOOO  OOOOOOOOOOO         \n");
                Console.WriteLine("        OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO         \n");
                Console.WriteLine("        OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO         \n");
                Console.WriteLine("        OOOO  OOOOOOOOOOOOOOOOOOOOOOOOO  OOOO         \n");
                Console.WriteLine("         OOOO  OOOOOOOOOOOOOOOOOOOOOOO  OOOO          \n");
                Console.WriteLine("          OOOO   OOOOOOOOOOOOOOOOOOOO  OOOO           \n");
                Console.WriteLine("           OOOOO   OOOOOOOOOOOOOOO   OOOO             \n");
                Console.WriteLine("            OOOOOO   OOOOOOOOO   OOOOOO               \n");
                Console.WriteLine("               OOOOO           OOOOOO                  \n");
                Console.WriteLine("                    OOOOOOOOOOOO                      \n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Que pena!!! Você perdeu o jogo.\n\n");

                Console.WriteLine("     \\|/ ____ \\|/     \n");
                Console.WriteLine("       @~/ ,. \\~@      \n");
                Console.WriteLine("      /_( \\__/ )_\\    \n");
                Console.WriteLine("         \\__U_/        \n");
            }
            Console.ReadKey();
        }
        public List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();

            lista.Add(new NovaPergunta("O que significa RGB?", "Vermelho, Verde, Azul", "Cores"));
            lista.Add(new NovaPergunta("Qual é a cor do ceu?", "Azul", "Informe uma cor que comece com a letra A"));
            lista.Add(new NovaPergunta("Qual o endereço do site de pesquisas", "www.google.com", "oo"));
            lista.Add(new NovaPergunta("Qual o stream mais popular ?", "WWW.youtube.com", "vc no tubo"));
            lista.Add(new NovaPergunta("Qual plataforma é mais popular para ver filmes?", "NetFlix", "Cor vermelha"));
            lista.Add(new NovaPergunta("Qual plataforma mais popular para ouvir musicas?", "Spotify", "Icone verde"));
            lista.Add(new NovaPergunta("Qual a melhor linguagem de programação?", "C#", "Microsoft"));
            lista.Add(new NovaPergunta("Qual filme Stallone volta da guerra?", "Rambo programado para matar", "Faca"));
            lista.Add(new NovaPergunta("De quem é essa frase? I am back", "Arnold Schwarzenegger", "Tora"));
            lista.Add(new NovaPergunta("Cores do capacete tricampeão da F1 brasileiro", "Senna", "manhas de domingo"));
            return lista;
        }
    }
}