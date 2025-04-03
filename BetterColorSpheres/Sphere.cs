using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public int Raio {get; private set; }
        public int Contagem {get; private set; } = 0;

        public Color Cor {get; private set; }
        
        public Sphere(Color cor, int raio)
        {
            Cor = cor;
            Raio = raio;

        }

        public void Pop()
        {
            Raio = 0;
        }

        public void Throw()
        {
            if (Raio > 0)
            {
                Contagem ++;
            }
        }

        
    }
}