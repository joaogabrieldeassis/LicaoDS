using System;

namespace Licaojoao
{
    class Exercicio33
    {
        static void Main8(string[] args)
        {
            double receber = 0;
            double soma = 0;
            double matricula = 0;
            double notaDaProva = 0;
            int contador = 0;
            char sair = 'n';
            while (true)
            {

                Console.WriteLine("Digite a matricula do aluno");
                matricula = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a nota do aluno");
                notaDaProva = Convert.ToDouble(Console.ReadLine());
                contador++;
                Console.WriteLine("Deseja inserir a nota de outro aluno ?\n S para sim N para não");
                sair = Convert.ToChar(Console.ReadLine());
                soma += notaDaProva;
                if (sair == 'n' || sair == 'N')
                {
                    receber = soma / contador;
                    Console.WriteLine("As médias de notas dos alunos são {0}", receber);
                    break;
                }


            }

        }
    }
}