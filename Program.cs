namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Insira quantos alunos você quer cadastrar: ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            List<AlunosFatec> lista = new List<AlunosFatec>();

            for(int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine($"\n ----- Cadastro do aluno {i + 1} ----");

                Console.Write("\nNome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("\nRA: ");
                int ra = int.Parse(Console.ReadLine());

                Console.Write("\nNota 1: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("\nNota 2: ");
                double nota2 = double.Parse(Console.ReadLine());

                AlunosFatec aluno = new AlunosFatec(nome, ra, nota1, nota2);

                lista.Add( aluno );

            }

            foreach(AlunosFatec af in lista)
            {
                af.calcularMedia();
            }
        }
    }
}
