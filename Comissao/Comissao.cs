namespace Programa
{
    public class Comissao
    {
        public void CalcularPorcentagem()
        {
            double comissao = 10.0;
            double comissaoPromocao = 5.0;

            Console.Write("Digite a quantidade vendida: ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário: ");
            double unitario = double.Parse(Console.ReadLine());
            
            Console.Write("Tipo de venda? (Escolha [1]-Normal-(10%) | [2]-Promoção-(5%) | [3]-Mostruario): ");
            var tipo = Console.ReadLine();

            double total = quantidade * unitario;

            Console.WriteLine($"\nO valor do intem é: {total}");

            if (tipo == "1")
            {
                double valorComissao = total * comissao / 100;
                Console.WriteLine($"O Valor da comissão é: {valorComissao}");
            }
            else if(tipo == "2")
            {
                double valorComissao = total * comissaoPromocao / 100;
                Console.WriteLine($"O Valor da Comissão de produto em promoção é: {valorComissao}");
            }
            else
            {
                Console.WriteLine("\nVenda sem comissão");
            }
        }
    }
}