using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class AlunosFatec : Aluno
    {

        private double nota1 { get; set; }
        private double nota2 { get; set; }


        public AlunosFatec(string nome, int ra, double nota1, double nota2)
            :base(nome, ra)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public override void calcularMedia()
        {
         media = (nota1 + nota2) / 2;
            Console.WriteLine($"\nAluno: {nome} com RA: {ra}");
            Console.WriteLine($"Sua média foi de: {media}");
        }
    }
}
