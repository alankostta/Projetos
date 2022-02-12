using System.IO;


namespace Programa
{
    class ProgramaUm
    {
        enum Opcoes { Jogo = 1, Calculadora = 2, Determinante = 3, Comissao = 4, Atualizar = 5, Salvar = 6, Sair = 7 }
        static void Main(String[] args)
        {

            Console.WriteLine("Selecione uma opção do Menu!");
            Console.WriteLine("================================================================================");
            Console.WriteLine("1-Jogo Adivinha| 2-Calculadora| 3-Determinate| 4-Comissão| 5-Atualizar| 6-Salvar");
            Console.WriteLine("================================================================================");

            int index = Convert.ToInt32(Console.ReadLine());
            Opcoes opcaoSelect = (Opcoes)index;

            switch (opcaoSelect)
            {
                case Opcoes.Jogo:
                    ListaDePerguntas jogo = new ListaDePerguntas();
                    jogo.IniciaAdivinha();
                    break;

                case Opcoes.Calculadora:
                    Calculadora calcula = new Calculadora();
                    calcula.InformarValores();
                    break;

                case Opcoes.Determinante:
                    ExerciciosAlgoritmo exerc = new ExerciciosAlgoritmo();
                    exerc.determinante();
                    break;

                case Opcoes.Comissao:
                    Comissao comissao = new Comissao();
                    comissao.CalcularPorcentagem();
                    break;

                case Opcoes.Atualizar:
                    Console.WriteLine("O intem selecionado do menu foi: " + opcaoSelect);
                    break;

                case Opcoes.Salvar:
                    Console.WriteLine("O intem selecionado do menu foi: " + opcaoSelect);
                    break;

                default:
                    Console.WriteLine("O intem selecionado não contém na lista de opções!");
                    break;
            }
        }
    }
}