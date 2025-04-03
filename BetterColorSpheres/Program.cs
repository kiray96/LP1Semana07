using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Sphere bola = new Sphere(new Color(1, 4, 6), 9);
            bola.Throw();
            bola.Pop();

            Sphere bola1 = new Sphere(new Color(2, 5, 7), 8);
            bola1.Throw();
            bola1.Throw();

            PrintSphere(bola);
            PrintSphere(bola1);
        }

        private static void PrintSphere(Sphere sphere)
        {
            Color color = sphere.Cor;

            Console.WriteLine($"Radius: {sphere.Raio}");
            Console.WriteLine($"throws: {sphere.Contagem}");
            Console.WriteLine($"Color Red: {color.Red}");
            Console.WriteLine($"Color Green: {color.Green}");
            Console.WriteLine($"Color Blue: {color.Blue}");
            Console.WriteLine($"Alpha: {color.Alpha}");
            Console.WriteLine($"Grey: {color.Grey}");
        }
    }
}
