using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }

        }

        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }

    }
}
