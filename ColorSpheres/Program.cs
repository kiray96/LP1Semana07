using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Sphere bola = new Sphere(new Color(1, 4, 6), 9);
            bola.Throw();
            bola.Pop();

            Sphere bola1 = new Sphere(new Color(2, 5, 7), 8);
            bola.Throw();
            bola.Throw();

            PrintSphere(bola);
            PrintSphere(bola1);
        }

        private static void PrintSphere(Sphere sphere)
        {
            Color color = sphere.GetColor();

            Console.WriteLine($"Radius: {sphere.GetRadius()}");
            Console.WriteLine($"throws: {sphere.GetTimesThrown()}");
            Console.WriteLine($"Color Red: {color.GetRed()}");
            Console.WriteLine($"Color Green: {color.GetGreen()}");
            Console.WriteLine($"Color Blue: {color.GetBlue()}");
            Console.WriteLine($"Alpha: {color.GetAlpha()}");
            Console.WriteLine($"Grey: {color.GetGrey()}");
        }
    }
}
