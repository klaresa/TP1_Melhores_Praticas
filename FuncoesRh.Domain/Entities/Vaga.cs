using System;
using System.Collections.Generic;
using System.Text;

namespace FuncoesRH.Domain.Entities
{
    public class Vaga
    {
        public Guid Id { get; set; }
        public Instituicao Instituicao { get; set; }
        public int CargaHoraria { get; set; }
    }
}
