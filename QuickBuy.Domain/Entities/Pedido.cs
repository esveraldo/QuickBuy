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
        public DateTime DataPrivisaoEntrega { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                LimparMensagemValidacao();

            AdicionarCritica("Critica -  Pedido não pode ficar sem item de pedido");

        }
    }
}
