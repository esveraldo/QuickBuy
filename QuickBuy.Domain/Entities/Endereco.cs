﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Endereco : Entidade
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            AdicionarCritica("Critica - O cep tem de ser preenchido.");
        }
    }
}
