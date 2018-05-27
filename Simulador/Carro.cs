using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Simulador
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int velocidade { get; set; }


        public void Acelerando(int velocidade)
        {
            if (velocidade <= 50)
            {
                Console.Write("\r{0} Km/h  " , velocidade );
                Thread.Sleep(100);
                //Console.Clear();
                Acelerando(velocidade + 1);
            }
        }
        public void Freando()
        {
            for (int i = 50; i >= 0; i--)
                Console.WriteLine(i + " kM/h");
        }
    }
}
