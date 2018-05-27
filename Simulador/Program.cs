using System;

namespace Simulador
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro();
            carro.Controle(0, "=");
            carro.Freando(50);
            Console.ReadKey();

        }
    }
}
