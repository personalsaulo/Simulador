using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int velocidade { get; set; }


        public void Acelerando()
        {
            for(int i = 0; i <=50; i++)
                Console.WriteLine(i + " kM/h");

        }
        public void Freando()
        {
            for (int i = 50; i >= 0; i--)
                Console.WriteLine(i + " kM/h");
        }
    }
}
