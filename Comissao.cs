namespace Programa
{
    public class Comissao
    {
        public void CalcularPorcentagem()
        {
            double comissao = 10;
            double comissaoPromocao = 5;

            Console.Write("Digite a quantidade vendida: ");
            var quantidade = Console.ReadLine();

            Console.Write("Digite o preço unitário: ");
            var unitario = Console.ReadLine();

            Console.Write("Tipo de venda? (Escolha [1]-Normal-(10%) | [2]-Promoção-(5%) | [3]-Mostruario): ");
            var tipo = Console.ReadLine();

            var total = Convert.ToDouble(quantidade) * Convert.ToDouble(unitario);

            Console.WriteLine("\nO valor do intem é: ",total);

            if (tipo == "1")
            {
                var valorComissao = total * comissao / 100;
                Console.WriteLine("\nO Valor da comissão é: ", valorComissao);
            }
            else if(tipo == "2")
            {
                var valorComissao = total * comissaoPromocao / 100;
                Console.WriteLine("\nO Valor da Comissão de produto em promoção é: ", valorComissao);
            }
            else
            {
                Console.WriteLine("\nVenda sem comissão");
            }
        }
    }
}