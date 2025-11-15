using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Aluno
    {
        public string nome { get; set; }
        public int ra { get; set; }

        public double media { get; protected set; }

        public Aluno(string nome, int ra)
        {
            this.nome = nome;
            this.ra = ra;
        }
        public abstract void calcularMedia();

    }


}
