using System;
using System.Collections.Generic;
using System.Text;

namespace FuncoesRH.Domain.Entities
{
    public class Instituicao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Contato Contato { get; set; }
    }
}
