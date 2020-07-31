using QuickBuy.Domain.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrivisaoEntrega { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                LimparMensagemValidacao();

            AdicionarCritica("Critica -  Pedido não pode ficar sem item de pedido");

        }
    }
}
