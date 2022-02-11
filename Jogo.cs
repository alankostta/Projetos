namespace CRUD
{
    public enum TipoGenero { Acao, Aventura, Casual, Puzze, Estrategia, Outro }
    public enum TipoConsole { PS4, PS5, Switch, Xbox_360, Xbox_One, PC, Outro }
    public class Jogo
    {
        private int id;
        private string nome;
        private string descricao;
        public TipoConsole Console { get; set; }
        public TipoGenero Genero { get; set; }
        public Jogo()
        {
            this.Id = 0;
            this.Nome = " ";
            this.Descricao = " ";
            this.Genero = TipoGenero.Outro;
            this.Console = TipoConsole.Outro;
        }
        public Jogo(int id, string nome, string descricao, TipoGenero genero, TipoConsole console)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Console = console;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                {
                    Id = value;
                }
                else
                {
                    throw new Exception("Permitido apenas números positivos");
                }
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value.ToUpper();
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value.ToUpper();
            }
        }
    }
}