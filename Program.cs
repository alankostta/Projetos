
namespace CRUD
{
    public class Program
    {
      static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t====GERENCIADOR DE JOGOS====\n");
            Console.WriteLine("====SELECIONE UMA FUNCIONALIDADE DO SISTEMA====");
            Console.WriteLine("[1]-CADASTRAR JOGO");
            Console.WriteLine("[2]-EXCLUIR JOGO");
            Console.WriteLine("[3]-ALTERAR JOGO");
            Console.WriteLine("[4]-LOCALIZAR UM JOGO POR NOME");
            Console.WriteLine("[5]-LISTAR JOGOS POR GENERO");
            Console.WriteLine("[6]-LISTAR JOGOS POR CONSOLE");
            Console.WriteLine("[7]-LISTAR JOGOS TODOS OS JOGOS");
            Console.WriteLine("[8]-SAIR DO SISTEMA");
            Console.WriteLine("OPÇÃO: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }
        static void ShowMenuPrincipal()
        {
            ListaDeJogos listajogos = new ListaDeJogos();
            List<Jogo> lista = new List<Jogo>();
            string nomejogo = "";
            int id = 0;

            Jogo jogo = new Jogo(1,"Ty Runner","Jogo de corrida infinita",TipoGenero.Aventura,TipoConsole.Outro);
            listajogos.Inserir(jogo);
            jogo = new Jogo(2, "Jackpot", "caca-niquel", TipoGenero.Casual, TipoConsole.Outro);
            listajogos.Inserir(jogo);
            jogo = new Jogo(3, "Faroeste Zumbi", "Jogo de tiro", TipoGenero.Acao, TipoConsole.PC);
            listajogos.Inserir(jogo);

            Console.Clear();
            Console.WriteLine("\t\t\t====BEM VINDO AO GESTOR DE JOGOS====\n");
            Console.WriteLine("====INSIRA AS INFORMAÇÕES NA DEVIDA SEQUÊNCIA====");

            int opcao = 0;

            while (opcao != 8)
            {
                opcao = ShowMenu();
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        jogo = new Jogo();
                        Console.WriteLine("INFORME NÚMERO DO JOGO: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("INFORME NOME DO JOGO");
                        jogo.Nome = Console.ReadLine();

                        Console.WriteLine("DESCRIÇÃO DO JOGO");
                        jogo.Descricao = Console.ReadLine();

                        Console.WriteLine(@"INFORME GENERO DO JOGO\n[0]-AÇÃO\n[1]-AVENTURA\n 
                        [2]-CASUAL\n[3]-PUZZI\n[4]-ESTRATEGIA\n[5]-OUTROS: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(@"INFORME TIPO DE CONSOLE\n[0]-PS4\n[1]-PS5\n[2]-SWITCH\n
                        [3]-XBOX-360\n[4]-XBOX-ONE\n[5]-PC\n[6]-OUTROS: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listajogos.Inserir(jogo))
                        {
                            Console.WriteLine("JOGO INSERIDO!!!");
                        }
                        else
                        {
                            Console.WriteLine("JOGO NÃO INSERIDO!!!");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.WriteLine("EXCLUIR JOGO, INFORME O NÚMERO DO JOGO:");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (listajogos.Excluir(id))
                        {
                            Console.WriteLine("JOGO EXCLUIDO COM SUCESSO!!!");
                        }
                        else
                        {
                            Console.WriteLine("JOGO NÃO EXCLUIDO!!!");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("ALTERAR JOGO");
                        jogo = new Jogo();

                        Console.WriteLine("INFORME O NÚMERO DO JOGO: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("INFORME O NOME DO JOGO: ");
                        jogo.Nome = Console.ReadLine();

                        Console.WriteLine("INFORME O ESTILO DO JOGO: ");
                        jogo.Descricao = Console.ReadLine();

                        Console.WriteLine(@"INFORME GENERO DO JOGO\n[0]-AÇÃO\n[1]-AVENTURA\n 
                        [2]-CASUAL\n[3]-PUZZI\n[4]-ESTRATEGIA\n[5]-OUTROS:");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(@"INFORME TIPO DE CONSOLE\n[0]-PS4\n[1]-PS5\n[2]-SWITCH\n
                        [3]-XBOX-360\n[4]-XBOX-ONE\n[5]-PC\n[6]-OUTROS: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listajogos.Alterar(jogo))
                        {
                            Console.WriteLine("JOGO ALTERADO COM SUCESSO!!!");
                        }
                        else
                        {
                            Console.WriteLine("ERRO NÃO FOI POSSÍVEL ALTERAR JOGO");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("LOCALIZAR JOGO");
                        Console.WriteLine("INFORME O NOME DO JOGO: ");
                        nomejogo = Console.ReadLine();

                        lista = listajogos.Localizar(nomejogo);

                        foreach (var jog in lista)
                        {
                            Console.WriteLine($@"NÚMERO:{jog.Id}\nNOME:{jog.Nome}\n
                        DESCRIÇÃO:{jog.Descricao}\nGENERO:{jog.Genero}\nCONSOLE{jog.Console}");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("LISTAR TODOS OS GENEROS DE JOGOS");

                        Console.Write(@"[0]-AÇÃO\n[1]-AVENTURA\n[2]-CASUAL\n
                        [3]-PUZZI\n[4]-ESTRATEGIA\n[5]-OUTROS: ");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());

                        foreach (var jog in lista)
                        {
                            Console.WriteLine($@"NÚMERO:{jog.Id}\nNOME:{jog.Nome}\n
                        DESCRIÇÃO:{jog.Descricao}\nGENERO:{jog.Genero}\nCONSOLE{jog.Console}");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("LISTAR TODOS OS CONSOLES");

                        Console.Write(@"INFORME TIPO DE CONSOLE\n[0]-PS4\n[1]-PS5\n[2]-SWITCH\n
                        [3]-XBOX-360\n[4]-XBOX-ONE\n[5]-PC\n[6]-OUTROS: ");
                        TipoConsole console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        lista = listajogos.ListarPorConsole(console);

                        foreach (var jog in lista)
                        {
                            Console.WriteLine($@"NÚMERO:{jog.Id}\nNOME:{jog.Nome}\n
                        DESCRIÇÃO:{jog.Descricao}\nGENERO:{jog.Genero}\nCONSOLE{jog.Console}");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine("LISTAR TODOS OS JOGOS");
                        foreach (var jog in listajogos.Jogos)
                        {
                            Console.WriteLine($@"NÚMERO:{jog.Id}\nNOME:{jog.Nome}\n
                        DESCRIÇÃO:{jog.Descricao}\nGENERO:{jog.Genero}\nCONSOLE{jog.Console}");
                        }
                        Console.WriteLine("PRESCIONE QUALQUER TECLA PARA CONTINUAR!");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("OBRIGADO POR USAR NOSSO SISTEMA");
                        opcao = 8;
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            ShowMenuPrincipal();
        }
    }
}
