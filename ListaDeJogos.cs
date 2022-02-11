namespace CRUD
{
    public class ListaDeJogos
    {
        private List<Jogo> jogos;
        public ListaDeJogos()
        {
            jogos = new List<Jogo>();
        }
        public List<Jogo> Jogos
        {
            get
            {
                return jogos;
            }
        }
        public Boolean Inserir(Jogo jogo)
        {
            Boolean resultado = true;

            try
            {
                Jogo jog = jogos.Find(x => x.Id == jogo.Id);
                if (jog == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }
        public Boolean Alterar(Jogo jogo)
        {
            Boolean resultado = false;

            Jogo jog = jogos.Find(x => x.Id == jogo.Id);
            if (jog != null)
            {
                jog.Nome = jogo.Nome;
                jog.Descricao = jogo.Descricao;
                jog.Genero = jogo.Genero;
                jog.Console = jogo.Console;
                resultado = true;

            }
            return resultado;
        }
        public Boolean Excluir(int id)
        {
            Boolean resultado = false;
            Jogo jog = jogos.Find(x => x.Id == id);

            if (jog != null)
            {
                resultado = jogos.Remove(jog);
            }
            return resultado;
        }
        public List<Jogo> Localizar(string nome)
        {
            List<Jogo> listaJogo = jogos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return listaJogo;
        }
        public List<Jogo> ListarPorGenero(TipoGenero genero)
        {
            List<Jogo> listaJogo = jogos.FindAll(x => x.Genero.Equals(genero));
            return listaJogo;
        }
        public List<Jogo> ListarPorConsole(TipoConsole console)
        {
            List<Jogo> listaJogo = jogos.FindAll(x => x.Console.Equals(console));
            return listaJogo;
        }
    }
}