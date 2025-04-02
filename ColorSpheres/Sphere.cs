using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color cor;
        private int raio;
        private int contagem;

        public Sphere(Color cor, int raio)
        {
            this.cor = cor;
            this.raio = raio;

            contagem = 0;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if (raio > 0)
            {
                contagem ++;
            }
        }

        public int GetTimesThrown()
        {
            return contagem;
        }

        public Color GetColor()
        {
            return cor;
        }

        public int GetRadius()
        {
            return raio;
        }

    }
}