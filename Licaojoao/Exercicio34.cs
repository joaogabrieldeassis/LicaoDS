using System;

namespace Licaojoao
{
    class Exercicio34
    {
        static void Main9(string[] args)
        {
            int numeros, nmn, numberOne = 0;
            Console.WriteLine("digite um numero (negativo para sair): ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            if (numberOne >= 0)
            {
                nmn = numberOne;
                numeros = numberOne;

            }
            else if (numberOne >= 0)
            {

                Console.WriteLine("Digite outro numero: ");
                numberOne = Convert.ToInt32(Console.ReadLine());

                if (numberOne > numeros)
                {

                    numeros = numberOne;

                }

                else if (numberOne < nmn && numberOne >= 0)
                {

                    numeros = numberOne;

                }

                Console.WriteLine("\no maior numero foi %d, e o menor foi %d", numeros, nmn);

            }
        }
    }
}