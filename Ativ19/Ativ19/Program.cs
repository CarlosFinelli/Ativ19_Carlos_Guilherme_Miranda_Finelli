using System;

namespace Ativ19
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] quarto = new Quartos[10];
            Alunos aluno;
            int opcao = 0, codAluguel = 1, codQuarto;
            while(opcao != 2)
            {
            inicio:
                Console.Clear();
                aluno = new Alunos();
                Console.Write("Digite o nome do aluno: ");
                aluno.nome = Console.ReadLine();
                Console.Clear();
                Console.Write("Insira o email do aluno: ");
                aluno.email = Console.ReadLine();
                Console.Clear();
                Console.Write("Insira o quarto que o aluno deseja ficar (0 a 9): ");
                codQuarto = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (codQuarto > 9)
                {
                    Console.WriteLine("Código de quarto inválido");
                    Console.ReadKey();
                    goto inicio;
                }
                for(int i = 0; i < 10; i++)
                {
                    if (i == codQuarto && quarto[codQuarto] == null)
                    {
                        quarto[codQuarto] = new Quartos(aluno, codAluguel, codQuarto);

                    } else if (i == codQuarto && quarto[codQuarto] != null)
                    {
                        Console.WriteLine("Quarto ocupado.");
                        Console.ReadKey();
                        goto inicio;
                    }
                }
                codAluguel++;
                Console.Clear();
                Console.Write("Deseja alugar mais algum quarto? (1 = Sim, 2 = Não): ");
                opcao = Convert.ToInt16(Console.ReadLine());
            }
            Console.Clear();
            for(var i = 0; i < 10; i++)
            {
                if (quarto[i] == null)
                {
                    continue;
                } else
                {
                    Console.WriteLine($"Aluguel: {quarto[i].aluguel} \n Nome: {quarto[i].aluno.nome} \n Email: {quarto[i].aluno.email} \n Quarto: {quarto[i].codQuarto}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadKey();
        }
    }
}
