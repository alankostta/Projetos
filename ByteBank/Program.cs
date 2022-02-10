using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    public class Program
    {
        public static void Main(String[] args)
        {
            UsarSistema();
            CalcularBonificacao();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("326.753.398.628-89");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("159.753.398-04");
            camila.Nome = "camila";
            camila.Senha = "CA123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "CA123");

        }
        public static void CalcularBonificacao()
        {
            GrenciadorBonificacao gerenciadorBonificacao = new GrenciadorBonificacao();

            Funcionarios.Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionarios.Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionarios.Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionarios.Funcionario camila = new GerenteDeConta("326.175.486-20");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            Console.WriteLine($"Total de bonificações do mês {gerenciadorBonificacao.GetTotalBonificacao()}");
        }
    }
}