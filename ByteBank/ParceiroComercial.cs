namespace ByteBank
{
    public class ParceiroComercial : Sistemas.IAutenticavel
    {
        public string Senha {get; set;}
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}