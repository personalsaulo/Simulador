using System;
using System.Threading;

namespace Simulador
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int velocidade { get; set; }


        public void Controle(int velocidade, string marca)
        {
            if (velocidade <= 50)
            {

                Console.Write(marca +  "\r{0} Km/h  " , velocidade );
                Thread.Sleep(100);
                Controle(velocidade + 1, marca + "=");
            }
        }

        public void Freando(int velocidade)
        {
            if (velocidade >= 0)
            {
                Console.Write( "\r{0} Km/h  ", velocidade );
                Thread.Sleep(100);
                Freando(velocidade - 1);
            }
        }
    }
}
