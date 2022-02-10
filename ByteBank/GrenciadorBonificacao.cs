using ByteBank.Funcionarios;
namespace ByteBank
{
    public class GrenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionarios.Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}