using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa
{
    public class PerguntaJogo
    {
        public PerguntaJogo()
        {
            this.Pergunta = "";
            this.Resposta = "";
        }
        public PerguntaJogo(string pergunta, string resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }
        private String pergunta;
        public String Pergunta
        {
            get
            {
                return pergunta;
            }
            set
            {
                pergunta = value.ToUpper();
            }
        }
        private String resposta;
        public String Resposta
        {
            get
            {
                return resposta;
            }
            set
            {
                resposta = value.ToUpper();
            }
        }
    }
}