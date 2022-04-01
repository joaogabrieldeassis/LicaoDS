using System;
namespace LICAOJOAO
{
    class Exercicio31
    {
        static void Main6()
        {
                int receiveNumberPar = 0;
                int receiveNumberImpar = 0;
                int fristNumber = 0;
                char receive;
            while (true)
            {


                Console.WriteLine("Digite o  primeiro valor");
                fristNumber = Convert.ToInt32(Console.ReadLine());

                if (fristNumber > 0)
                {
                    if (fristNumber % 2 == 0)
                    {
                        receiveNumberPar = fristNumber + fristNumber;

                    }
                    else
                    {
                        receiveNumberImpar = fristNumber + fristNumber;

                    }
                }

                Console.WriteLine("Deja digitar outro valor ?\n S para sim ou N para não :  ");
                receive = Convert.ToChar(Console.ReadLine());

                if (receive == 'n' || receive == 'N')
                {

                    Console.WriteLine("A soma dos seus números pares são {0}", receiveNumberPar);
                    Console.WriteLine("A soma dos seus números impares são {0}", receiveNumberImpar);
                    break;
                }

            }
        }
    }
}