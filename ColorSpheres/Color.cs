using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;

            alpha = 255;
        }

        public byte GetRed()
        {
            return red;
        }

        public byte GetGreen()
        {
            return green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public byte GetGrey()
        {
            int sum = red + green + blue;
            int average = sum / 3;

            return Convert.ToByte(average);
        }
    }
}