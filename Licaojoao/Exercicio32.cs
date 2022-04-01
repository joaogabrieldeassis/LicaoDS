using System;

namespace Licaojoao
{
    class Exercicio32
    {
        static void Main7(string[] args)
        {
            int number = 6;
            int recebeNumber = 0;
            int somaQuadrados = 0;
            Console.WriteLine("Digite um número de 0 a 10");
            //           number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number <= 10)
            {
                for (number = number; number <= 20; number++)
                {
                    if (number % 2 != 0)
                    {
                        recebeNumber = number * 2;
                    }
                }
                somaQuadrados = recebeNumber * recebeNumber;
                Console.WriteLine("");
            }
        }
    }
}