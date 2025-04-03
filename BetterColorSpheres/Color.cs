using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        public byte Red {get; private set; }

        public byte Green {get; private set; }

        public byte Blue {get; private set; }

        public byte Alpha {get; private set; } = 255;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        

        public byte Grey
        {
            get
            {
                int sum = Red + Green + Blue;
                int average = sum / 3;

                return Convert.ToByte(average);
            }
        
        }
        
    }
}