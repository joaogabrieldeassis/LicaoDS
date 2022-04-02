using System;
namespace joao
{
    class joao
    {
        static void Main15(string[] args)
        {
            double primaryNumber = 0;
            char receiveCharacter;
            while (true)
            {
                Console.WriteLine("Digite o indice da sua empresa com ',' \n");
                primaryNumber = Convert.ToDouble(Console.ReadLine());
                if (primaryNumber <= 0.25)
                {
                    Console.WriteLine("Sua empresa está dentro dos regurlamentos:\n ");
                }
                if (primaryNumber == 0.3)
                {
                    Console.WriteLine("ATENÇÃO TODAS AS INDUSTRIAS DO PRIMEIRO GRUPO ESTÃO SUSPENSAS:\n");
                }
                if (primaryNumber == 0.4)
                {
                    Console.WriteLine("ATENÇÃO TODAS AS INDUSTRIAS DO PRIMEIRO E SEGUNDO GRUPO ESTÃO SUSPENSAS\nSuas atividades:\n");
                }
                if (primaryNumber == 0.5)
                {
                    Console.WriteLine("ATENÇÃO IMEDIATO TODAS AS INDUSTRIAS DE TODOS OS GRUPOS ESTÃO SUSPENSAS:\n");
                }
                Console.WriteLine("Deseja sair do programa S para sim N para não:");
                receiveCharacter = Convert.ToChar(Console.ReadLine());
                if (receiveCharacter == 's' || receiveCharacter == 'S')
                {
                    break;
                }
            }
        }
    }
}