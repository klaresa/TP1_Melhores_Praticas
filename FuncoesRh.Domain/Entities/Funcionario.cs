using System;
using System.Collections.Generic;
using System.Text;

namespace FuncoesRH.Domain
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Contato Contato { get; set; }
        int CargaHoraria { get; set; }

        public Funcionario()
        {
            CargaHoraria = 0;
        }

        public void ContabilizarHoras(int horas)
        {
            this.CargaHoraria += horas;
        }

        public int ObterCargaHoraria()
        {
            return this.CargaHoraria;
        }
    }
}
