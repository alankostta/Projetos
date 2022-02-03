using System.IO;

  
  namespace Programa
  {
  class ProgramaUm
    {
        enum Opcoes {Jogo = 1, Deletar = 2, Editar = 3, Listar = 4, Atualizar = 5, Salvar = 6, Sair = 7}
        static void Main(String[]args)
        {
            
            Console.WriteLine("Selecione uma opção do Menu!");
            Console.WriteLine("1-Jogo Adivinha\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar\n6-Salvar");
            
            int index = Convert.ToInt32(Console.ReadLine());
            Opcoes opcaoSelect = (Opcoes)index;
            
            switch(opcaoSelect)
            {
              case Opcoes.Jogo:
              ListaDePerguntas jogo = new ListaDePerguntas();
              jogo.IniciaAdivinha();
              break;

              case Opcoes.Deletar:
              Console.WriteLine("O intem selecionado do menu foi: "+ opcaoSelect);
              break;

              case Opcoes.Editar:
              Console.WriteLine("O intem selecionado do menu foi: "+ opcaoSelect);
              break;

              case Opcoes.Listar:
              Console.WriteLine("O intem selecionado do menu foi: "+ opcaoSelect);
              break;
              
              case Opcoes.Atualizar:
              Console.WriteLine("O intem selecionado do menu foi: "+ opcaoSelect);
              break;

              case Opcoes.Salvar:
              Console.WriteLine("O intem selecionado do menu foi: "+ opcaoSelect);
              break;

              default:
              Console.WriteLine("O intem selecionado não contém na lista de opções!");
              break;

            }
        }
    }
 }