using System;
using System.Collections.Generic;
using System.Text;

namespace Ativ19
{
    class Quartos
    {
        public Alunos aluno { get; set; }
        public int aluguel { get; set; }
        public int codQuarto { get; set; }
        public bool ocupado = false;
        public Quartos(Alunos aluno, int codAluguel, int codQuarto)
        {
            this.aluno = aluno;
            this.aluguel = codAluguel;
            this.ocupado = true;
            this.codQuarto = codQuarto;
        }
    }
}
