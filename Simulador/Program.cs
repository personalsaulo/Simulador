using System;

namespace Simulador
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            Carro velocidade = new Carro();
            do
            {
                Console.WriteLine("Simulador de Carro");
                Console.WriteLine("1 - Aumentar a Velocidade");
                Console.WriteLine("2 - Diminuir a Velocidade");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine("Aumentando a velocidade:");
                    velocidade.Acelerando(0);
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Aumentando a velocidade:");
                    velocidade.Freando();
                }

            } while (opcao != 3);

        }
    }
}
