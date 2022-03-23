using System;
using System.Collections.Generic;
using System.Text;

namespace FuncoesRH.Domain.Entities
{
    public class Funcao
    {
        public Guid Id { get; set; }
        public Vaga Vaga { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
